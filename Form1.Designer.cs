namespace PF2e_Probability_Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numDex = new System.Windows.Forms.NumericUpDown();
            this.numStr = new System.Windows.Forms.NumericUpDown();
            this.labelDex = new System.Windows.Forms.Label();
            this.grpPlayer = new System.Windows.Forms.GroupBox();
            this.btnTestCalculation = new System.Windows.Forms.Button();
            this.grpSkills = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbPerception = new System.Windows.Forms.ComboBox();
            this.cbIntimidation = new System.Windows.Forms.ComboBox();
            this.cbDeception = new System.Windows.Forms.ComboBox();
            this.cbAcrobatics = new System.Windows.Forms.ComboBox();
            this.cbAthletics = new System.Windows.Forms.ComboBox();
            this.labelAthletics = new System.Windows.Forms.Label();
            this.labelAcrobatics = new System.Windows.Forms.Label();
            this.labelDeception = new System.Windows.Forms.Label();
            this.labelIntimidation = new System.Windows.Forms.Label();
            this.labelPerception = new System.Windows.Forms.Label();
            this.labelWeapon = new System.Windows.Forms.Label();
            this.cbWeapon = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPlayername = new System.Windows.Forms.Label();
            this.textPlayerName = new System.Windows.Forms.TextBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.labelStr = new System.Windows.Forms.Label();
            this.numCha = new System.Windows.Forms.NumericUpDown();
            this.labelCha = new System.Windows.Forms.Label();
            this.numWis = new System.Windows.Forms.NumericUpDown();
            this.labelCon = new System.Windows.Forms.Label();
            this.labelWis = new System.Windows.Forms.Label();
            this.numCon = new System.Windows.Forms.NumericUpDown();
            this.numInt = new System.Windows.Forms.NumericUpDown();
            this.labelInt = new System.Windows.Forms.Label();
            this.grpTarget = new System.Windows.Forms.GroupBox();
            this.numAC = new System.Windows.Forms.NumericUpDown();
            this.labelAC = new System.Windows.Forms.Label();
            this.numWill = new System.Windows.Forms.NumericUpDown();
            this.labelWill = new System.Windows.Forms.Label();
            this.labelFort = new System.Windows.Forms.Label();
            this.numRef = new System.Windows.Forms.NumericUpDown();
            this.labelRef = new System.Windows.Forms.Label();
            this.numFort = new System.Windows.Forms.NumericUpDown();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.conditionsTarget = new PF2e_Probability_Calculator.ConditionTable();
            this.conditionsPlayer = new PF2e_Probability_Calculator.ConditionTable();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStr)).BeginInit();
            this.grpPlayer.SuspendLayout();
            this.grpSkills.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInt)).BeginInit();
            this.grpTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFort)).BeginInit();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // numDex
            // 
            this.numDex.Location = new System.Drawing.Point(86, 97);
            this.numDex.Name = "numDex";
            this.numDex.Size = new System.Drawing.Size(57, 20);
            this.numDex.TabIndex = 0;
            this.numDex.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDex.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // numStr
            // 
            this.numStr.Location = new System.Drawing.Point(86, 71);
            this.numStr.Name = "numStr";
            this.numStr.Size = new System.Drawing.Size(56, 20);
            this.numStr.TabIndex = 1;
            this.numStr.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numStr.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // labelDex
            // 
            this.labelDex.AutoSize = true;
            this.labelDex.Location = new System.Drawing.Point(28, 99);
            this.labelDex.Name = "labelDex";
            this.labelDex.Size = new System.Drawing.Size(51, 13);
            this.labelDex.TabIndex = 2;
            this.labelDex.Text = "Dexterity:";
            // 
            // grpPlayer
            // 
            this.grpPlayer.Controls.Add(this.btnCalculate);
            this.grpPlayer.Controls.Add(this.btnTestCalculation);
            this.grpPlayer.Controls.Add(this.conditionsPlayer);
            this.grpPlayer.Controls.Add(this.grpSkills);
            this.grpPlayer.Controls.Add(this.groupBox1);
            this.grpPlayer.Location = new System.Drawing.Point(12, 12);
            this.grpPlayer.Name = "grpPlayer";
            this.grpPlayer.Size = new System.Drawing.Size(453, 460);
            this.grpPlayer.TabIndex = 3;
            this.grpPlayer.TabStop = false;
            this.grpPlayer.Text = "Player";
            // 
            // btnTestCalculation
            // 
            this.btnTestCalculation.Location = new System.Drawing.Point(246, 357);
            this.btnTestCalculation.Name = "btnTestCalculation";
            this.btnTestCalculation.Size = new System.Drawing.Size(75, 23);
            this.btnTestCalculation.TabIndex = 1;
            this.btnTestCalculation.Text = "Test Calc";
            this.btnTestCalculation.UseVisualStyleBackColor = true;
            this.btnTestCalculation.Click += new System.EventHandler(this.Button1_Click);
            // 
            // grpSkills
            // 
            this.grpSkills.Controls.Add(this.tableLayoutPanel1);
            this.grpSkills.Location = new System.Drawing.Point(166, 29);
            this.grpSkills.Name = "grpSkills";
            this.grpSkills.Size = new System.Drawing.Size(280, 199);
            this.grpSkills.TabIndex = 16;
            this.grpSkills.TabStop = false;
            this.grpSkills.Text = "Proficiencies";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbPerception, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbIntimidation, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbDeception, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbAcrobatics, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbAthletics, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAthletics, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAcrobatics, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDeception, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelIntimidation, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPerception, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelWeapon, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbWeapon, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 180);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // cbPerception
            // 
            this.cbPerception.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPerception.FormattingEnabled = true;
            this.cbPerception.Items.AddRange(new object[] {
            "Untrained (+0)",
            "Trained (+2)",
            "Expert (+4)",
            "Master (+6)",
            "Legendary (+8)"});
            this.cbPerception.Location = new System.Drawing.Point(140, 111);
            this.cbPerception.MaxDropDownItems = 5;
            this.cbPerception.Name = "cbPerception";
            this.cbPerception.Size = new System.Drawing.Size(131, 21);
            this.cbPerception.TabIndex = 17;
            this.cbPerception.SelectedIndexChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // cbIntimidation
            // 
            this.cbIntimidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbIntimidation.FormattingEnabled = true;
            this.cbIntimidation.Items.AddRange(new object[] {
            "Untrained (+0)",
            "Trained (+2)",
            "Expert (+4)",
            "Master (+6)",
            "Legendary (+8)"});
            this.cbIntimidation.Location = new System.Drawing.Point(140, 84);
            this.cbIntimidation.MaxDropDownItems = 5;
            this.cbIntimidation.Name = "cbIntimidation";
            this.cbIntimidation.Size = new System.Drawing.Size(131, 21);
            this.cbIntimidation.TabIndex = 22;
            this.cbIntimidation.SelectedIndexChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // cbDeception
            // 
            this.cbDeception.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDeception.FormattingEnabled = true;
            this.cbDeception.Items.AddRange(new object[] {
            "Untrained (+0)",
            "Trained (+2)",
            "Expert (+4)",
            "Master (+6)",
            "Legendary (+8)"});
            this.cbDeception.Location = new System.Drawing.Point(140, 57);
            this.cbDeception.MaxDropDownItems = 5;
            this.cbDeception.Name = "cbDeception";
            this.cbDeception.Size = new System.Drawing.Size(131, 21);
            this.cbDeception.TabIndex = 21;
            this.cbDeception.SelectedIndexChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // cbAcrobatics
            // 
            this.cbAcrobatics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAcrobatics.FormattingEnabled = true;
            this.cbAcrobatics.Items.AddRange(new object[] {
            "Untrained (+0)",
            "Trained (+2)",
            "Expert (+4)",
            "Master (+6)",
            "Legendary (+8)"});
            this.cbAcrobatics.Location = new System.Drawing.Point(140, 3);
            this.cbAcrobatics.MaxDropDownItems = 5;
            this.cbAcrobatics.Name = "cbAcrobatics";
            this.cbAcrobatics.Size = new System.Drawing.Size(131, 21);
            this.cbAcrobatics.TabIndex = 16;
            this.cbAcrobatics.SelectedIndexChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // cbAthletics
            // 
            this.cbAthletics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAthletics.FormattingEnabled = true;
            this.cbAthletics.Items.AddRange(new object[] {
            "Untrained (+0)",
            "Trained (+2)",
            "Expert (+4)",
            "Master (+6)",
            "Legendary (+8)"});
            this.cbAthletics.Location = new System.Drawing.Point(140, 30);
            this.cbAthletics.MaxDropDownItems = 5;
            this.cbAthletics.Name = "cbAthletics";
            this.cbAthletics.Size = new System.Drawing.Size(131, 21);
            this.cbAthletics.TabIndex = 20;
            this.cbAthletics.SelectedIndexChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // labelAthletics
            // 
            this.labelAthletics.AutoSize = true;
            this.labelAthletics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAthletics.Location = new System.Drawing.Point(3, 27);
            this.labelAthletics.Name = "labelAthletics";
            this.labelAthletics.Size = new System.Drawing.Size(131, 27);
            this.labelAthletics.TabIndex = 16;
            this.labelAthletics.Text = "Athletics:";
            this.labelAthletics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAcrobatics
            // 
            this.labelAcrobatics.AutoSize = true;
            this.labelAcrobatics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAcrobatics.Location = new System.Drawing.Point(3, 0);
            this.labelAcrobatics.Name = "labelAcrobatics";
            this.labelAcrobatics.Size = new System.Drawing.Size(131, 27);
            this.labelAcrobatics.TabIndex = 15;
            this.labelAcrobatics.Text = "Acrobatics:";
            this.labelAcrobatics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeception
            // 
            this.labelDeception.AutoSize = true;
            this.labelDeception.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDeception.Location = new System.Drawing.Point(3, 54);
            this.labelDeception.Name = "labelDeception";
            this.labelDeception.Size = new System.Drawing.Size(131, 27);
            this.labelDeception.TabIndex = 17;
            this.labelDeception.Text = "Deception:";
            this.labelDeception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIntimidation
            // 
            this.labelIntimidation.AutoSize = true;
            this.labelIntimidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIntimidation.Location = new System.Drawing.Point(3, 81);
            this.labelIntimidation.Name = "labelIntimidation";
            this.labelIntimidation.Size = new System.Drawing.Size(131, 27);
            this.labelIntimidation.TabIndex = 18;
            this.labelIntimidation.Text = "Intimidation:";
            this.labelIntimidation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPerception
            // 
            this.labelPerception.AutoSize = true;
            this.labelPerception.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPerception.Location = new System.Drawing.Point(3, 108);
            this.labelPerception.Name = "labelPerception";
            this.labelPerception.Size = new System.Drawing.Size(131, 27);
            this.labelPerception.TabIndex = 19;
            this.labelPerception.Text = "Perception:";
            this.labelPerception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWeapon
            // 
            this.labelWeapon.AutoSize = true;
            this.labelWeapon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWeapon.Location = new System.Drawing.Point(3, 135);
            this.labelWeapon.Name = "labelWeapon";
            this.labelWeapon.Size = new System.Drawing.Size(131, 20);
            this.labelWeapon.TabIndex = 23;
            this.labelWeapon.Text = "Weapon:";
            this.labelWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbWeapon
            // 
            this.cbWeapon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWeapon.FormattingEnabled = true;
            this.cbWeapon.Items.AddRange(new object[] {
            "Untrained (+0)",
            "Trained (+2)",
            "Expert (+4)",
            "Master (+6)",
            "Legendary (+8)"});
            this.cbWeapon.Location = new System.Drawing.Point(140, 138);
            this.cbWeapon.Name = "cbWeapon";
            this.cbWeapon.Size = new System.Drawing.Size(131, 21);
            this.cbWeapon.TabIndex = 24;
            this.cbWeapon.SelectedIndexChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPlayername);
            this.groupBox1.Controls.Add(this.textPlayerName);
            this.groupBox1.Controls.Add(this.labelLevel);
            this.groupBox1.Controls.Add(this.numLevel);
            this.groupBox1.Controls.Add(this.labelStr);
            this.groupBox1.Controls.Add(this.numStr);
            this.groupBox1.Controls.Add(this.numCha);
            this.groupBox1.Controls.Add(this.labelDex);
            this.groupBox1.Controls.Add(this.labelCha);
            this.groupBox1.Controls.Add(this.numDex);
            this.groupBox1.Controls.Add(this.numWis);
            this.groupBox1.Controls.Add(this.labelCon);
            this.groupBox1.Controls.Add(this.labelWis);
            this.groupBox1.Controls.Add(this.numCon);
            this.groupBox1.Controls.Add(this.numInt);
            this.groupBox1.Controls.Add(this.labelInt);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 233);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // labelPlayername
            // 
            this.labelPlayername.AutoSize = true;
            this.labelPlayername.Location = new System.Drawing.Point(41, 22);
            this.labelPlayername.Name = "labelPlayername";
            this.labelPlayername.Size = new System.Drawing.Size(38, 13);
            this.labelPlayername.TabIndex = 17;
            this.labelPlayername.Text = "Name:";
            // 
            // textPlayerName
            // 
            this.textPlayerName.Location = new System.Drawing.Point(85, 19);
            this.textPlayerName.Name = "textPlayerName";
            this.textPlayerName.Size = new System.Drawing.Size(57, 20);
            this.textPlayerName.TabIndex = 16;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(43, 47);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(36, 13);
            this.labelLevel.TabIndex = 15;
            this.labelLevel.Text = "Level:";
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(86, 45);
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(56, 20);
            this.numLevel.TabIndex = 14;
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // labelStr
            // 
            this.labelStr.AutoSize = true;
            this.labelStr.Location = new System.Drawing.Point(30, 73);
            this.labelStr.Name = "labelStr";
            this.labelStr.Size = new System.Drawing.Size(50, 13);
            this.labelStr.TabIndex = 3;
            this.labelStr.Text = "Strength:";
            // 
            // numCha
            // 
            this.numCha.Location = new System.Drawing.Point(86, 201);
            this.numCha.Name = "numCha";
            this.numCha.Size = new System.Drawing.Size(57, 20);
            this.numCha.TabIndex = 12;
            this.numCha.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCha.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // labelCha
            // 
            this.labelCha.AutoSize = true;
            this.labelCha.Location = new System.Drawing.Point(26, 203);
            this.labelCha.Name = "labelCha";
            this.labelCha.Size = new System.Drawing.Size(53, 13);
            this.labelCha.TabIndex = 13;
            this.labelCha.Text = "Charisma:";
            // 
            // numWis
            // 
            this.numWis.Location = new System.Drawing.Point(85, 175);
            this.numWis.Name = "numWis";
            this.numWis.Size = new System.Drawing.Size(57, 20);
            this.numWis.TabIndex = 10;
            this.numWis.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWis.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // labelCon
            // 
            this.labelCon.AutoSize = true;
            this.labelCon.Location = new System.Drawing.Point(15, 125);
            this.labelCon.Name = "labelCon";
            this.labelCon.Size = new System.Drawing.Size(65, 13);
            this.labelCon.TabIndex = 7;
            this.labelCon.Text = "Constitution:";
            // 
            // labelWis
            // 
            this.labelWis.AutoSize = true;
            this.labelWis.Location = new System.Drawing.Point(31, 177);
            this.labelWis.Name = "labelWis";
            this.labelWis.Size = new System.Drawing.Size(48, 13);
            this.labelWis.TabIndex = 11;
            this.labelWis.Text = "Wisdom:";
            // 
            // numCon
            // 
            this.numCon.Location = new System.Drawing.Point(85, 123);
            this.numCon.Name = "numCon";
            this.numCon.Size = new System.Drawing.Size(57, 20);
            this.numCon.TabIndex = 6;
            this.numCon.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCon.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // numInt
            // 
            this.numInt.Location = new System.Drawing.Point(85, 149);
            this.numInt.Name = "numInt";
            this.numInt.Size = new System.Drawing.Size(57, 20);
            this.numInt.TabIndex = 8;
            this.numInt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numInt.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // labelInt
            // 
            this.labelInt.AutoSize = true;
            this.labelInt.Location = new System.Drawing.Point(16, 151);
            this.labelInt.Name = "labelInt";
            this.labelInt.Size = new System.Drawing.Size(64, 13);
            this.labelInt.TabIndex = 9;
            this.labelInt.Text = "Intelligence:";
            // 
            // grpTarget
            // 
            this.grpTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTarget.Controls.Add(this.numAC);
            this.grpTarget.Controls.Add(this.labelAC);
            this.grpTarget.Controls.Add(this.conditionsTarget);
            this.grpTarget.Controls.Add(this.numWill);
            this.grpTarget.Controls.Add(this.labelWill);
            this.grpTarget.Controls.Add(this.labelFort);
            this.grpTarget.Controls.Add(this.numRef);
            this.grpTarget.Controls.Add(this.labelRef);
            this.grpTarget.Controls.Add(this.numFort);
            this.grpTarget.Location = new System.Drawing.Point(471, 12);
            this.grpTarget.Name = "grpTarget";
            this.grpTarget.Size = new System.Drawing.Size(160, 460);
            this.grpTarget.TabIndex = 4;
            this.grpTarget.TabStop = false;
            this.grpTarget.Text = "Target 1";
            // 
            // numAC
            // 
            this.numAC.Location = new System.Drawing.Point(63, 100);
            this.numAC.Name = "numAC";
            this.numAC.Size = new System.Drawing.Size(57, 20);
            this.numAC.TabIndex = 7;
            this.numAC.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numAC.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // labelAC
            // 
            this.labelAC.AutoSize = true;
            this.labelAC.Location = new System.Drawing.Point(33, 102);
            this.labelAC.Name = "labelAC";
            this.labelAC.Size = new System.Drawing.Size(24, 13);
            this.labelAC.TabIndex = 8;
            this.labelAC.Text = "AC:";
            // 
            // numWill
            // 
            this.numWill.Location = new System.Drawing.Point(63, 74);
            this.numWill.Name = "numWill";
            this.numWill.Size = new System.Drawing.Size(57, 20);
            this.numWill.TabIndex = 4;
            this.numWill.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numWill.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // labelWill
            // 
            this.labelWill.AutoSize = true;
            this.labelWill.Location = new System.Drawing.Point(30, 76);
            this.labelWill.Name = "labelWill";
            this.labelWill.Size = new System.Drawing.Size(27, 13);
            this.labelWill.TabIndex = 5;
            this.labelWill.Text = "Will:";
            // 
            // labelFort
            // 
            this.labelFort.AutoSize = true;
            this.labelFort.Location = new System.Drawing.Point(6, 24);
            this.labelFort.Name = "labelFort";
            this.labelFort.Size = new System.Drawing.Size(51, 13);
            this.labelFort.TabIndex = 3;
            this.labelFort.Text = "Fortitude:";
            // 
            // numRef
            // 
            this.numRef.Location = new System.Drawing.Point(63, 48);
            this.numRef.Name = "numRef";
            this.numRef.Size = new System.Drawing.Size(57, 20);
            this.numRef.TabIndex = 0;
            this.numRef.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRef.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // labelRef
            // 
            this.labelRef.AutoSize = true;
            this.labelRef.Location = new System.Drawing.Point(17, 50);
            this.labelRef.Name = "labelRef";
            this.labelRef.Size = new System.Drawing.Size(40, 13);
            this.labelRef.TabIndex = 2;
            this.labelRef.Text = "Reflex:";
            // 
            // numFort
            // 
            this.numFort.Location = new System.Drawing.Point(63, 22);
            this.numFort.Name = "numFort";
            this.numFort.Size = new System.Drawing.Size(56, 20);
            this.numFort.TabIndex = 1;
            this.numFort.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numFort.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // grpResults
            // 
            this.grpResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResults.Controls.Add(this.textBox1);
            this.grpResults.Location = new System.Drawing.Point(12, 478);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(619, 439);
            this.grpResults.TabIndex = 5;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Probabilities";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(613, 420);
            this.textBox1.TabIndex = 0;
            // 
            // conditionsTarget
            // 
            this.conditionsTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionsTarget.AutoScroll = true;
            this.conditionsTarget.Location = new System.Drawing.Point(0, 142);
            this.conditionsTarget.MinimumSize = new System.Drawing.Size(154, 0);
            this.conditionsTarget.Name = "conditionsTarget";
            this.conditionsTarget.Size = new System.Drawing.Size(154, 312);
            this.conditionsTarget.TabIndex = 6;
            // 
            // conditionsPlayer
            // 
            this.conditionsPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionsPlayer.AutoScroll = true;
            this.conditionsPlayer.Location = new System.Drawing.Point(6, 258);
            this.conditionsPlayer.MinimumSize = new System.Drawing.Size(150, 0);
            this.conditionsPlayer.Name = "conditionsPlayer";
            this.conditionsPlayer.Size = new System.Drawing.Size(154, 196);
            this.conditionsPlayer.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(246, 328);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 929);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpTarget);
            this.Controls.Add(this.grpPlayer);
            this.Name = "MainForm";
            this.Text = "PF2e Probability Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStr)).EndInit();
            this.grpPlayer.ResumeLayout(false);
            this.grpSkills.ResumeLayout(false);
            this.grpSkills.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInt)).EndInit();
            this.grpTarget.ResumeLayout(false);
            this.grpTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFort)).EndInit();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDex;
        private System.Windows.Forms.NumericUpDown numStr;
        private System.Windows.Forms.Label labelDex;
        private System.Windows.Forms.GroupBox grpPlayer;
        private System.Windows.Forms.Label labelStr;
        private System.Windows.Forms.GroupBox grpTarget;
        private System.Windows.Forms.NumericUpDown numWill;
        private System.Windows.Forms.Label labelWill;
        private System.Windows.Forms.Label labelFort;
        private System.Windows.Forms.NumericUpDown numRef;
        private System.Windows.Forms.Label labelRef;
        private System.Windows.Forms.NumericUpDown numFort;
        private System.Windows.Forms.NumericUpDown numCha;
        private System.Windows.Forms.Label labelCha;
        private System.Windows.Forms.NumericUpDown numWis;
        private System.Windows.Forms.Label labelWis;
        private System.Windows.Forms.NumericUpDown numInt;
        private System.Windows.Forms.Label labelInt;
        private System.Windows.Forms.NumericUpDown numCon;
        private System.Windows.Forms.Label labelCon;
        private System.Windows.Forms.GroupBox grpSkills;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelAcrobatics;
        private System.Windows.Forms.ComboBox cbAcrobatics;
        private System.Windows.Forms.ComboBox cbIntimidation;
        private System.Windows.Forms.ComboBox cbDeception;
        private System.Windows.Forms.ComboBox cbAthletics;
        private System.Windows.Forms.Label labelAthletics;
        private System.Windows.Forms.Label labelDeception;
        private System.Windows.Forms.Label labelIntimidation;
        private System.Windows.Forms.Label labelPerception;
        private System.Windows.Forms.ComboBox cbPerception;
        private ConditionTable conditionsPlayer;
        private ConditionTable conditionsTarget;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.NumericUpDown numAC;
        private System.Windows.Forms.Label labelAC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelWeapon;
        private System.Windows.Forms.ComboBox cbWeapon;
        private System.Windows.Forms.Button btnTestCalculation;
        private System.Windows.Forms.Label labelPlayername;
        private System.Windows.Forms.TextBox textPlayerName;
        private System.Windows.Forms.Button btnCalculate;
    }
}

