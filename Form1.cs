using System;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;

namespace PF2e_Probability_Calculator
{
    public partial class MainForm : Form
    {
        readonly Player player = new Player("CLASP");
        readonly NPC npc = new NPC("Enemy1");
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LoadSettingsFromFile();
            if (!Debugger.IsAttached)
            {
                btnCalculate.Visible = false;
                btnTestCalculation.Visible = false;
            }
        }

        private void LoadSettingsFromFile()
        {
            player.ReadFromFile();

            textPlayerName.DataBindings.Add("Text", player, "CharName", false, DataSourceUpdateMode.OnPropertyChanged);
            numLevel.DataBindings.Add("Value", player.attributes, "Level", false, DataSourceUpdateMode.OnPropertyChanged);
            numStr.DataBindings.Add("Value", player.attributes.Strength, "Score", false, DataSourceUpdateMode.OnPropertyChanged); 
            numDex.DataBindings.Add("Value", player.attributes.Dexterity, "Score", false, DataSourceUpdateMode.OnPropertyChanged);
            numCon.DataBindings.Add("Value", player.attributes.Constitution, "Score", false, DataSourceUpdateMode.OnPropertyChanged);
            numInt.DataBindings.Add("Value", player.attributes.Intelligence, "Score", false, DataSourceUpdateMode.OnPropertyChanged);
            numWis.DataBindings.Add("Value", player.attributes.Wisdom, "Score", false, DataSourceUpdateMode.OnPropertyChanged);
            numCha.DataBindings.Add("Value", player.attributes.Charisma, "Score", false, DataSourceUpdateMode.OnPropertyChanged);

            cbAcrobatics.DataBindings.Add("SelectedIndex", player.attributes.Acrobatics, "Rank", false, DataSourceUpdateMode.OnPropertyChanged);
            cbAthletics.DataBindings.Add("SelectedIndex", player.attributes.Athletics, "Rank", false, DataSourceUpdateMode.OnPropertyChanged);
            cbDeception.DataBindings.Add("SelectedIndex", player.attributes.Deception, "Rank", false, DataSourceUpdateMode.OnPropertyChanged);
            cbIntimidation.DataBindings.Add("SelectedIndex", player.attributes.Intimidation, "Rank", false, DataSourceUpdateMode.OnPropertyChanged);
            cbPerception.DataBindings.Add("SelectedIndex", player.attributes.Perception, "Rank", false, DataSourceUpdateMode.OnPropertyChanged);
            cbWeapon.DataBindings.Add("SelectedIndex", player.attributes.WeaponProficiency, "Rank", false, DataSourceUpdateMode.OnPropertyChanged);

            numRef.DataBindings.Add("Value", npc.attributes, "Reflex", false, DataSourceUpdateMode.OnPropertyChanged);
            numWill.DataBindings.Add("Value", npc.attributes, "Will", false, DataSourceUpdateMode.OnPropertyChanged);
            numFort.DataBindings.Add("Value", npc.attributes, "Fortitude", false, DataSourceUpdateMode.OnPropertyChanged);
            numAC.DataBindings.Add("Value", npc.attributes, "AC", false, DataSourceUpdateMode.OnPropertyChanged);

            CalculateProbability(); 
        }       
        

        private void CalculateProbability()
        {
            Probability probability = new Probability(player, npc, conditionsPlayer.conditions, conditionsTarget.conditions);

            ProbabilityCalc chanceAttack = probability.MeleeAttackStr();
            ProbabilityCalc chanceTrip = probability.TripCheck();
            ProbabilityCalc chanceDisarm = probability.DisarmCheck();
            ProbabilityCalc chanceGrapple = new ProbabilityCalc((int)((player.attributes.Strength.Mod + player.attributes.Athletics.Mod(player.attributes.Level) - (10 + npc.attributes.Fortitude))));
            ProbabilityCalc chanceStunS = new ProbabilityCalc((int)(npc.attributes.Fortitude - (10 + player.attributes.Strength.Mod + player.attributes.ClassProficiency)));

            textBox1.Text = "";
            textBox1.AppendText(chanceAttack.ToString("chanceAttack") + Environment.NewLine);            
            textBox1.AppendText(chanceTrip.ToString("chanceTrip") + Environment.NewLine);
            textBox1.AppendText(chanceDisarm.ToString("chanceDisarm") + Environment.NewLine);
            textBox1.AppendText(chanceGrapple.ToString("chanceGrapple") + Environment.NewLine);
            textBox1.AppendText(chanceStunS.ToString("chanceStunS") + Environment.NewLine);
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(
            () => CalculateProbability()));
        }

        private void CheckConditionsChanged_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(
            () => CalculateProbability()));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Test Chance calculation
            bool equal = true;
            ushort count = 1000;
            Random rnd = new Random();
            textBox1.Clear();
            while (equal && count-- > 0)
            {
                //Random input values
                int str = (int)rnd.Next(-5, 5);                
                uint level = (uint)rnd.Next(1, 20);
                uint weapProf = (uint)rnd.Next(0, 4) * 2 + level;
                uint ac = (uint)rnd.Next(8, 30);
                uint athlProf = (uint)rnd.Next(0, 4) * 2 + level;
                uint refl = (uint)rnd.Next(0, 20);
                uint fort = (uint)rnd.Next(0, 20);

                ProbabilityCalc atk = new ProbabilityCalc((int)(str + weapProf - ac));  
                ProbabilityCalc trip = new ProbabilityCalc((int)(str + athlProf - (refl + 10)));
                ProbabilityCalc grapple = new ProbabilityCalc((int)(str + athlProf - (fort + 10)));
                ProbabilityCalc stuns = new ProbabilityCalc((int)(fort - (10 + str + weapProf)));

                if (!atk.EqualToCount(atk.TotalModifier))
                {                 
                    textBox1.AppendText(atk.ToString("Atk"));
                    equal = false;
                }

                if (!trip.EqualToCount(trip.TotalModifier))
                {
                    textBox1.AppendText(trip.ToString("Trip"));
                    equal = false;
                }

                if (!grapple.EqualToCount(grapple.TotalModifier))
                {
                    textBox1.AppendText(grapple.ToString("Grapple"));
                    equal = false;
                }

                if (!stuns.EqualToCount(stuns.TotalModifier))
                {
                    textBox1.AppendText(stuns.ToString("StunS"));
                    equal = false;
                }

                if (!equal)
                {
                    textBox1.AppendText("str: " + str + ", weapProf: " + weapProf + ", level: " + level + ", ac: " + ac + ", athlProf: " + athlProf + ", refl: " + refl + ", fort: " + fort + Environment.NewLine);                    
                }

            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.WriteToFile();
            npc.WriteToFile();
        }
    }    
}
