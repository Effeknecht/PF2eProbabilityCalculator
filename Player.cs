using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace PF2e_Probability_Calculator
{
    public class Player : Character<PCAttributes>
    {
        public Player(string name) : base(name)
        {
            
        }
    }

    public class NPC : Character<NPCAttributes>
    {
        public NPC(string name) : base(name)
        {
            
        }
    }

    public class Character<T> where T : new()
    {
        public T attributes;
        public string CharName { get; set; }

        public Character(string name)
        {
            attributes = new T();
            CharName = name;
        }
        public void ReadFromFile()
        {
            if (File.Exists($"pf2e.{CharName}.json"))
            {
                string jsonString = File.ReadAllText($"pf2e.{CharName}.json");
                if (!string.IsNullOrEmpty(jsonString)) attributes = JsonSerializer.Deserialize <T> (jsonString);
            }
        }

        public void WriteToFile()
        {
            string jsonString = JsonSerializer.Serialize(attributes);
            File.WriteAllText($"pf2e.{CharName}.json", jsonString);
        }
    }

    public class PCAttributes
    {        
        public uint Level { get; set; }
        public CharClass Class { get; set; }
        public Skill WeaponProficiency { get; set; }
        public uint ClassProficiency { get { return GetClassProficiency(); } }

        //Ability scores
        public Ability Strength { get; set; }
        public Ability Dexterity { get; set; }
        public Ability Constitution { get; set; }
        public Ability Wisdom { get; set; }
        public Ability Intelligence { get; set; }
        public Ability Charisma { get; set; }

        //Skill proficiency
        public Skill Acrobatics { get; set; }
        public Skill Athletics { get; set; }
        public Skill Deception { get; set; }
        public Skill Intimidation { get; set; }
        public Skill Perception { get; set; }

        public PCAttributes()
        {
            Level = 1;
            Class = CharClass.Monk;
            WeaponProficiency = new Skill(1);

            Strength = new Ability();
            Dexterity = new Ability();
            Constitution = new Ability();
            Wisdom = new Ability();
            Intelligence = new Ability();
            Charisma = new Ability();

            Acrobatics = new Skill();
            Athletics = new Skill();
            Deception = new Skill();
            Intimidation = new Skill();
            Perception = new Skill();
        }

        private uint GetClassProficiency()
        {
            switch (Class)
            {
                case CharClass.Alchemist:
                case CharClass.Champion:
                case CharClass.Gunslinger:
                case CharClass.Inventor:
                case CharClass.Monk:
                case CharClass.Ranger:                           
                case CharClass.Thaumaturge:
                    {
                        if (Level >= 17) return Level + 6;
                        else if (Level >= 9) return Level + 4;
                        else return Level + 2;
                    }

                case CharClass.Barbarian:
                case CharClass.Fighter:
                case CharClass.Rogue:
                    {
                        if (Level >= 19) return Level + 6;
                        else if (Level >= 11) return Level + 4;
                        else return Level + 2;
                    }

                case CharClass.Investigator:
                case CharClass.Swashbuckler:
                    {
                        if (Level >= 19) return Level + 6;
                        else if (Level >= 9) return Level + 4;
                        else return Level + 2;
                    }

                case CharClass.Kineticist:
                    {
                        if (Level >= 19) return Level + 8;
                        else if (Level >= 15) return Level + 6;
                        else if (Level >= 7) return Level + 4;
                        else return Level + 2;
                    }

                default: return 0;
            }
        }
    }

    public class NPCAttributes
    {
        //Last target 1 modifiers
        public int Reflex { get; set; }
        public int Will { get; set; }
        public int Fortitude { get; set; }
        public uint AC { get; set; }

        public NPCAttributes()
        {
            Reflex = 5;
            Will = 5;
            Fortitude = 5;
            AC = 20;
        }
    }

    public enum CharClass
    {
        Alchemist,        
        Barbarian,
        Bard,
        Champion,
        Cleric,
        Druid,
        Fighter,
        Gunslinger,
        Inventor,
        Investigator,
        Kineticist,
        Magus,
        Monk,
        Oracle,
        Psychic,
        Ranger,
        Rogue,
        Sorcerer,
        Summoner,
        Swashbuckler,
        Thaumaturge,
        Witch,
        Wizard
    }

    public class Skill
    {
        public uint Rank { get; set; }

        public int Mod(uint level)
        {
            if (Rank == 0)
            {
                return 0;
            }
            else
            {
                return (int)(Rank * 2 + level);
            }
        }

        public Skill(uint rank) => Rank = rank;
        public Skill() => Rank = 0;
    }

    public class Ability
    {
        public uint Score { get; set; }
        public int Mod { get { return ((int)Score / 2) - 5; } }

        public Ability(uint score) => Score = score;
        public Ability() => Score = 10;
    }

    public class ProbabilityCalc : IEquatable<ProbabilityCalc>
    {
        public double Fumble { get; set; }
        public double Fail { get; set; }
        public double Success { get; set; }
        public double Crit { get; set; }
        public int TotalModifier { get; set; }

        public static bool operator ==(ProbabilityCalc c1, ProbabilityCalc c2)
        {
            return c1.Crit.Equals(c2.Crit) && c1.Success.Equals(c2.Success) && c1.Fail.Equals(c2.Fail) && c1.Fumble.Equals(c2.Fumble);
        }

        public static bool operator !=(ProbabilityCalc c1, ProbabilityCalc c2)
        {
            return !(c1 == c2);
        }

        public bool Equals(ProbabilityCalc other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return Crit.Equals(other.Crit)
                   && Success.Equals(other.Success)
                   && Fail.Equals(other.Fail)
                   && Fumble.Equals(other.Fumble);
        }
        public override bool Equals(object obj) => Equals(obj as ProbabilityCalc);

        public override int GetHashCode() => HashCode.Combine(Crit, Success, Fail, Fumble);

        public bool EqualToCount(int totalModifier)
        {
            //Nur zum debuggen
            int countCrit = 0, countSuccess = 0, countFail = 0, countFumble = 0;
            if (1 + totalModifier < 0) countFumble++;
            else if (1 + totalModifier < 10) countFail++;
            else countSuccess++;

            if (20 + totalModifier >= 0) countCrit++;
            else if (20 + totalModifier > -10) countSuccess++;
            else countFail++;

            for (int d20 = 2; d20 < 20; d20++)
            {
                int roll = d20 + totalModifier;
                if (roll >= 10) countCrit++;
                else if (roll >= 0) countSuccess++;
                else if (roll > -10) countFail++;
                else countFumble++;
            }

            bool equal = (Fumble == countFumble / 20.0);
            equal &= (Fail == countFail / 20.0);
            equal &= (Success == countSuccess / 20.0);
            equal &= (Crit == countCrit / 20.0);

            return equal;
        }

        public ProbabilityCalc(int totalModifier)
        {
            TotalModifier = totalModifier;
            Calculate();
        }

        public ProbabilityCalc(int bonus, int dc)
        {
            TotalModifier = bonus - dc;
            Calculate();
        }

        private void Calculate()
        {
            //Fumble:  -10 >= d20 + TotalModifier      
            //Fail:    -10 <  d20 + TotalModifier < 0
            //Success:   0 <= d20 + TotalModifier < 10
            //Crit:         d20 + TotalModifier >= 10  
            //Aber bei 1 Crit->Success->Fail->Fumble
            //Und bei 20 Fumble->Fail->Success->Crit

            int thresholdCrit = 10 - TotalModifier;
            int thresholdSuccess = -TotalModifier;
            int thresholdFail = -10 - TotalModifier;

            if (1 <= thresholdFail)
            {
                if (20 >= thresholdSuccess)
                {
                    Crit = 1 / 20.0;
                    Success = (20 - thresholdSuccess) / 20.0;
                    Fail = (thresholdSuccess - thresholdFail - 1) / 20.0;
                    Fumble = thresholdFail / 20.0;

                }
                else if (20 > thresholdFail)
                {
                    Crit = 0.0;
                    Success = 1 / 20.0;
                    Fail = (20 - thresholdFail - 1) / 20.0;
                    Fumble = thresholdFail / 20.0;

                }
                else
                {
                    Crit = 0.0;
                    Success = 0.0;
                    Fail = 1 / 20.0;
                    Fumble = 19 / 20.0;
                }

            }
            else if (1 < thresholdSuccess)
            {
                Fumble = 1 / 20.0;
                Fail = (thresholdSuccess - 2) / 20.0;
                Success = (thresholdCrit - thresholdSuccess) / 20.0;
                Crit = (1 + 20 - thresholdCrit) / 20.0;

            }
            else if (1 < thresholdCrit)
            {
                Fumble = 0.0;
                Fail = 1 / 20.0;
                Success = (thresholdCrit - 2) / 20.0;
                Crit = (1 + 20 - thresholdCrit) / 20.0;

            }
            else
            {
                Fumble = 0.0;
                Fail = 0.0;
                Success = 1 / 20.0;
                Crit = 19 / 20.0;
            }
        }

        public string ToString(string name)
        {
            string FumbleRolls = string.Format("{0,7}", " ");
            string FailRolls = string.Format("{0,7}", " ");
            string SuccessRolls = string.Format("{0,7}", " ");
            string CritRolls = string.Format("{0,7}", " ");

            int FumbleMax = 0;
            int FailMax = 0;
            int SuccessMax = 0;

            if (Fumble > 0.0)
            {
                FumbleMax = (int)(Fumble * 20);
                FumbleRolls = (Fumble > 0.05) ? $" 1 - {FumbleMax,2}" : $"{1,7}";
            }

            if (Fail > 0.0)
            {
                FailMax = FumbleMax + (int)(Fail * 20);
                FailRolls = (Fail > 0.05) ? $"{FumbleMax + 1,2} - {FailMax,2}" : $"{FailMax,7}";
            }

            if (Success > 0.0)
            {
                SuccessMax = FailMax + (int)(Success * 20);
                SuccessRolls = (Success > 0.05) ? $"{FailMax + 1,2} - {SuccessMax,2}" : $"{SuccessMax,7}";
            }

            if (Crit > 0.0)
            {
                CritRolls = (Crit > 0.05) ? $"{SuccessMax + 1,2} - 20" : $"{20,7}";
            }

            return $"{name,15}: Fumble({Fumble * 100,2}%), Fail({Fail * 100,2}%), Success({Success * 100,2}%), Crit({Crit * 100,2}%), TotalModifier: {TotalModifier,3}{Environment.NewLine}" +
                   $"{FumbleRolls,28}{FailRolls,11}{SuccessRolls,14}{CritRolls,11}{Environment.NewLine}";
        }
    }

    public class Probability
    {
        private readonly PCAttributes PC;
        private readonly NPCAttributes NPC;
        private readonly Conditions PCCond;
        private readonly Conditions NPCCond;

        private readonly bool DC11Flat;
        private readonly bool DC5Flat;
        private readonly bool isFlatFooted;

        public ProbabilityCalc MeleeAttackStr()
        {
            int pcMod = -(int)(PCCond.Enfeebled + PCCond.Frightened + (PCCond.Prone ? 2 : 0) + NPCCond.Sickened);
            int ncMod = -(int)(NPCCond.Clumsy + (NPCCond.Fatigued ? 1 : 0) + NPCCond.Frightened + NPCCond.Sickened + (NPCCond.Unconscious ? 4 : 0) + (isFlatFooted ? 2 : 0));

            return new ProbabilityCalc(PC.Strength.Mod + PC.WeaponProficiency.Mod(PC.Level) + pcMod, (int)NPC.AC + ncMod);
        }

        public ProbabilityCalc TripCheck()
        {            
            int pcMod = -(int)(PCCond.Enfeebled + PCCond.Frightened + (PCCond.Prone ? 2 : 0) + PCCond.Sickened);            
            int ncMod = -(int)(NPCCond.Clumsy + (NPCCond.Fatigued ? 1 : 0) + NPCCond.Frightened + NPCCond.Sickened + (NPCCond.Unconscious ? 4 : 0));            

            return new ProbabilityCalc(PC.Strength.Mod + PC.Athletics.Mod(PC.Level) + pcMod, 10 + NPC.Reflex + ncMod);
        }

        public ProbabilityCalc DisarmCheck()
        {
            return TripCheck();
        }

        public Probability(Player player, NPC target, Conditions playerConditions, Conditions targetConditions)
        {
            PC = player.attributes;
            PCCond = playerConditions;
            NPC = target.attributes;
            NPCCond = targetConditions;

            DC11Flat = (PCCond.Blinded || NPCCond.Hidden || NPCCond.Invisible || NPCCond.Unnoticed || NPCCond.Undetected);
            DC5Flat = (PCCond.Dazzled || NPCCond.Concealed);
            isFlatFooted = (PCCond.Hidden || PCCond.Invisible || PCCond.Undetected || PCCond.Unnoticed || NPCCond.Blinded || NPCCond.FlatFooted || NPCCond.Grabbed || NPCCond.Paralyzed || NPCCond.Prone || NPCCond.Restrained || NPCCond.Unconscious);
        }
    }
}
