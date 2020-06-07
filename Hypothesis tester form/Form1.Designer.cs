namespace Hypothesis_tester_form
{
    partial class MainScreen
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.binomialTab = new System.Windows.Forms.TabPage();
            this.runBtn1 = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.successRate = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.conclusion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BinH0Res = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.probLbl = new System.Windows.Forms.Label();
            this.testType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.H0_bin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.normalTab = new System.Windows.Forms.TabPage();
            this.testTypeChange = new System.Windows.Forms.RadioButton();
            this.testTypeDecrease = new System.Windows.Forms.RadioButton();
            this.testTypeIncrease = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.runBtn2 = new System.Windows.Forms.Button();
            this.normConcl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.H0_normRes = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataMode = new System.Windows.Forms.CheckBox();
            this.sampleData = new System.Windows.Forms.TextBox();
            this.dataLbl = new System.Windows.Forms.Label();
            this.sampleMean = new System.Windows.Forms.NumericUpDown();
            this.sampleMeanLbl = new System.Windows.Forms.Label();
            this.allowDecimal = new System.Windows.Forms.CheckBox();
            this.mu = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.signLev = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.stdDev = new System.Windows.Forms.NumericUpDown();
            this.nNormLbl = new System.Windows.Forms.Label();
            this.nNorm = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.signLevBin = new System.Windows.Forms.NumericUpDown();
            this.tabControl.SuspendLayout();
            this.binomialTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.successRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H0_bin)).BeginInit();
            this.normalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signLev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNorm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signLevBin)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.binomialTab);
            this.tabControl.Controls.Add(this.normalTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1145, 648);
            this.tabControl.TabIndex = 0;
            // 
            // binomialTab
            // 
            this.binomialTab.Controls.Add(this.label16);
            this.binomialTab.Controls.Add(this.signLevBin);
            this.binomialTab.Controls.Add(this.label15);
            this.binomialTab.Controls.Add(this.runBtn1);
            this.binomialTab.Controls.Add(this.n);
            this.binomialTab.Controls.Add(this.label7);
            this.binomialTab.Controls.Add(this.successRate);
            this.binomialTab.Controls.Add(this.label6);
            this.binomialTab.Controls.Add(this.conclusion);
            this.binomialTab.Controls.Add(this.label5);
            this.binomialTab.Controls.Add(this.BinH0Res);
            this.binomialTab.Controls.Add(this.label3);
            this.binomialTab.Controls.Add(this.probLbl);
            this.binomialTab.Controls.Add(this.testType);
            this.binomialTab.Controls.Add(this.label2);
            this.binomialTab.Controls.Add(this.H0_bin);
            this.binomialTab.Controls.Add(this.label1);
            this.binomialTab.Location = new System.Drawing.Point(8, 39);
            this.binomialTab.Name = "binomialTab";
            this.binomialTab.Padding = new System.Windows.Forms.Padding(3);
            this.binomialTab.Size = new System.Drawing.Size(1129, 601);
            this.binomialTab.TabIndex = 0;
            this.binomialTab.Text = "Binomial test";
            this.binomialTab.UseVisualStyleBackColor = true;
            // 
            // runBtn1
            // 
            this.runBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runBtn1.Location = new System.Drawing.Point(915, 521);
            this.runBtn1.Name = "runBtn1";
            this.runBtn1.Size = new System.Drawing.Size(121, 45);
            this.runBtn1.TabIndex = 22;
            this.runBtn1.Text = "Compute!";
            this.runBtn1.UseVisualStyleBackColor = true;
            this.runBtn1.Click += new System.EventHandler(this.runBtn1_Click);
            // 
            // n
            // 
            this.n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.Location = new System.Drawing.Point(466, 244);
            this.n.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.n.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(120, 44);
            this.n.TabIndex = 21;
            this.n.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n.ValueChanged += new System.EventHandler(this.n_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 37);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total number of trials:";
            // 
            // successRate
            // 
            this.successRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successRate.Location = new System.Drawing.Point(466, 175);
            this.successRate.Name = "successRate";
            this.successRate.Size = new System.Drawing.Size(120, 44);
            this.successRate.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(436, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "Number of success from trial:";
            // 
            // conclusion
            // 
            this.conclusion.AutoSize = true;
            this.conclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conclusion.Location = new System.Drawing.Point(203, 415);
            this.conclusion.Name = "conclusion";
            this.conclusion.Size = new System.Drawing.Size(843, 37);
            this.conclusion.TabIndex = 17;
            this.conclusion.Text = "There is/isn\'t enough evidence to reject the null hypothesis";
            this.conclusion.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "H0";
            // 
            // BinH0Res
            // 
            this.BinH0Res.AutoSize = true;
            this.BinH0Res.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinH0Res.Location = new System.Drawing.Point(23, 329);
            this.BinH0Res.Name = "BinH0Res";
            this.BinH0Res.Size = new System.Drawing.Size(113, 37);
            this.BinH0Res.TabIndex = 15;
            this.BinH0Res.Text = "[result]";
            this.BinH0Res.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 37);
            this.label3.TabIndex = 14;
            this.label3.Text = "Conclusion:";
            // 
            // probLbl
            // 
            this.probLbl.AutoSize = true;
            this.probLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probLbl.Location = new System.Drawing.Point(530, 101);
            this.probLbl.Name = "probLbl";
            this.probLbl.Size = new System.Drawing.Size(35, 37);
            this.probLbl.TabIndex = 13;
            this.probLbl.Text = "p";
            // 
            // testType
            // 
            this.testType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testType.FormattingEnabled = true;
            this.testType.Items.AddRange(new object[] {
            "<",
            ">",
            "≠"});
            this.testType.Location = new System.Drawing.Point(436, 98);
            this.testType.Name = "testType";
            this.testType.Size = new System.Drawing.Size(88, 45);
            this.testType.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "H1: p";
            // 
            // H0_bin
            // 
            this.H0_bin.DecimalPlaces = 3;
            this.H0_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H0_bin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.H0_bin.Location = new System.Drawing.Point(436, 32);
            this.H0_bin.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.H0_bin.Name = "H0_bin";
            this.H0_bin.Size = new System.Drawing.Size(151, 44);
            this.H0_bin.TabIndex = 10;
            this.H0_bin.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.H0_bin.ValueChanged += new System.EventHandler(this.H0_bin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "H0: p =";
            // 
            // normalTab
            // 
            this.normalTab.Controls.Add(this.nNorm);
            this.normalTab.Controls.Add(this.nNormLbl);
            this.normalTab.Controls.Add(this.stdDev);
            this.normalTab.Controls.Add(this.label14);
            this.normalTab.Controls.Add(this.label13);
            this.normalTab.Controls.Add(this.signLev);
            this.normalTab.Controls.Add(this.label11);
            this.normalTab.Controls.Add(this.testTypeChange);
            this.normalTab.Controls.Add(this.testTypeDecrease);
            this.normalTab.Controls.Add(this.testTypeIncrease);
            this.normalTab.Controls.Add(this.label9);
            this.normalTab.Controls.Add(this.runBtn2);
            this.normalTab.Controls.Add(this.normConcl);
            this.normalTab.Controls.Add(this.label10);
            this.normalTab.Controls.Add(this.H0_normRes);
            this.normalTab.Controls.Add(this.label12);
            this.normalTab.Controls.Add(this.dataMode);
            this.normalTab.Controls.Add(this.sampleData);
            this.normalTab.Controls.Add(this.dataLbl);
            this.normalTab.Controls.Add(this.sampleMean);
            this.normalTab.Controls.Add(this.sampleMeanLbl);
            this.normalTab.Controls.Add(this.allowDecimal);
            this.normalTab.Controls.Add(this.mu);
            this.normalTab.Controls.Add(this.label8);
            this.normalTab.Location = new System.Drawing.Point(8, 39);
            this.normalTab.Name = "normalTab";
            this.normalTab.Padding = new System.Windows.Forms.Padding(3);
            this.normalTab.Size = new System.Drawing.Size(1129, 601);
            this.normalTab.TabIndex = 1;
            this.normalTab.Text = "Normal test";
            this.normalTab.UseVisualStyleBackColor = true;
            // 
            // testTypeChange
            // 
            this.testTypeChange.AutoSize = true;
            this.testTypeChange.Location = new System.Drawing.Point(917, 226);
            this.testTypeChange.Name = "testTypeChange";
            this.testTypeChange.Size = new System.Drawing.Size(118, 29);
            this.testTypeChange.TabIndex = 27;
            this.testTypeChange.TabStop = true;
            this.testTypeChange.Text = "Change";
            this.testTypeChange.UseVisualStyleBackColor = true;
            this.testTypeChange.CheckedChanged += new System.EventHandler(this.testTypeChange_CheckedChanged);
            // 
            // testTypeDecrease
            // 
            this.testTypeDecrease.AutoSize = true;
            this.testTypeDecrease.Location = new System.Drawing.Point(917, 190);
            this.testTypeDecrease.Name = "testTypeDecrease";
            this.testTypeDecrease.Size = new System.Drawing.Size(135, 29);
            this.testTypeDecrease.TabIndex = 26;
            this.testTypeDecrease.TabStop = true;
            this.testTypeDecrease.Text = "Decrease";
            this.testTypeDecrease.UseVisualStyleBackColor = true;
            this.testTypeDecrease.CheckedChanged += new System.EventHandler(this.testTypeDecrease_CheckedChanged);
            // 
            // testTypeIncrease
            // 
            this.testTypeIncrease.AutoSize = true;
            this.testTypeIncrease.Location = new System.Drawing.Point(917, 154);
            this.testTypeIncrease.Name = "testTypeIncrease";
            this.testTypeIncrease.Size = new System.Drawing.Size(125, 29);
            this.testTypeIncrease.TabIndex = 25;
            this.testTypeIncrease.TabStop = true;
            this.testTypeIncrease.Text = "Increase";
            this.testTypeIncrease.UseVisualStyleBackColor = true;
            this.testTypeIncrease.CheckedChanged += new System.EventHandler(this.testTypeIncrease_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(669, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 37);
            this.label9.TabIndex = 24;
            this.label9.Text = "Alternate hypo.:";
            // 
            // runBtn2
            // 
            this.runBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runBtn2.Location = new System.Drawing.Point(915, 521);
            this.runBtn2.Name = "runBtn2";
            this.runBtn2.Size = new System.Drawing.Size(121, 45);
            this.runBtn2.TabIndex = 23;
            this.runBtn2.Text = "Compute!";
            this.runBtn2.UseVisualStyleBackColor = true;
            this.runBtn2.Click += new System.EventHandler(this.runBtn2_Click);
            // 
            // normConcl
            // 
            this.normConcl.AutoSize = true;
            this.normConcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normConcl.Location = new System.Drawing.Point(193, 458);
            this.normConcl.Name = "normConcl";
            this.normConcl.Size = new System.Drawing.Size(843, 37);
            this.normConcl.TabIndex = 21;
            this.normConcl.Text = "There is/isn\'t enough evidence to reject the null hypothesis";
            this.normConcl.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 37);
            this.label10.TabIndex = 20;
            this.label10.Text = "H0";
            // 
            // H0_normRes
            // 
            this.H0_normRes.AutoSize = true;
            this.H0_normRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H0_normRes.Location = new System.Drawing.Point(13, 372);
            this.H0_normRes.Name = "H0_normRes";
            this.H0_normRes.Size = new System.Drawing.Size(113, 37);
            this.H0_normRes.TabIndex = 19;
            this.H0_normRes.Text = "[result]";
            this.H0_normRes.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 37);
            this.label12.TabIndex = 18;
            this.label12.Text = "Conclusion:";
            // 
            // dataMode
            // 
            this.dataMode.AutoSize = true;
            this.dataMode.Location = new System.Drawing.Point(242, 218);
            this.dataMode.Name = "dataMode";
            this.dataMode.Size = new System.Drawing.Size(218, 29);
            this.dataMode.TabIndex = 7;
            this.dataMode.Text = "Use data instead?";
            this.dataMode.UseVisualStyleBackColor = true;
            this.dataMode.CheckedChanged += new System.EventHandler(this.dataMode_CheckedChanged);
            // 
            // sampleData
            // 
            this.sampleData.Enabled = false;
            this.sampleData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleData.Location = new System.Drawing.Point(113, 294);
            this.sampleData.Name = "sampleData";
            this.sampleData.Size = new System.Drawing.Size(532, 44);
            this.sampleData.TabIndex = 6;
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Enabled = false;
            this.dataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLbl.Location = new System.Drawing.Point(13, 297);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(94, 37);
            this.dataLbl.TabIndex = 5;
            this.dataLbl.Text = "Data:";
            // 
            // sampleMean
            // 
            this.sampleMean.AutoSize = true;
            this.sampleMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleMean.Location = new System.Drawing.Point(242, 145);
            this.sampleMean.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.sampleMean.Minimum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            -2147483648});
            this.sampleMean.Name = "sampleMean";
            this.sampleMean.Size = new System.Drawing.Size(391, 44);
            this.sampleMean.TabIndex = 4;
            // 
            // sampleMeanLbl
            // 
            this.sampleMeanLbl.AutoSize = true;
            this.sampleMeanLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleMeanLbl.Location = new System.Drawing.Point(13, 147);
            this.sampleMeanLbl.Name = "sampleMeanLbl";
            this.sampleMeanLbl.Size = new System.Drawing.Size(223, 37);
            this.sampleMeanLbl.TabIndex = 3;
            this.sampleMeanLbl.Text = "Sample mean:";
            // 
            // allowDecimal
            // 
            this.allowDecimal.AutoSize = true;
            this.allowDecimal.Location = new System.Drawing.Point(20, 218);
            this.allowDecimal.Name = "allowDecimal";
            this.allowDecimal.Size = new System.Drawing.Size(175, 29);
            this.allowDecimal.TabIndex = 2;
            this.allowDecimal.Text = "Allow decimal";
            this.allowDecimal.UseVisualStyleBackColor = true;
            this.allowDecimal.CheckedChanged += new System.EventHandler(this.allowDecimal_CheckedChanged);
            // 
            // mu
            // 
            this.mu.AutoSize = true;
            this.mu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mu.Location = new System.Drawing.Point(242, 6);
            this.mu.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.mu.Minimum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            -2147483648});
            this.mu.Name = "mu";
            this.mu.Size = new System.Drawing.Size(391, 44);
            this.mu.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "Past mean:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(639, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(270, 37);
            this.label11.TabIndex = 28;
            this.label11.Text = "Significance level:";
            // 
            // signLev
            // 
            this.signLev.DecimalPlaces = 1;
            this.signLev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signLev.Location = new System.Drawing.Point(915, 6);
            this.signLev.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.signLev.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.signLev.Name = "signLev";
            this.signLev.Size = new System.Drawing.Size(96, 44);
            this.signLev.TabIndex = 29;
            this.signLev.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1017, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 37);
            this.label13.TabIndex = 30;
            this.label13.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(287, 37);
            this.label14.TabIndex = 31;
            this.label14.Text = "Past std. deviation:";
            // 
            // stdDev
            // 
            this.stdDev.AutoSize = true;
            this.stdDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdDev.Location = new System.Drawing.Point(299, 78);
            this.stdDev.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.stdDev.Minimum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            -2147483648});
            this.stdDev.Name = "stdDev";
            this.stdDev.Size = new System.Drawing.Size(391, 44);
            this.stdDev.TabIndex = 32;
            this.stdDev.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nNormLbl
            // 
            this.nNormLbl.AutoSize = true;
            this.nNormLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNormLbl.Location = new System.Drawing.Point(696, 80);
            this.nNormLbl.Name = "nNormLbl";
            this.nNormLbl.Size = new System.Drawing.Size(287, 37);
            this.nNormLbl.TabIndex = 33;
            this.nNormLbl.Text = "Number in sample:";
            // 
            // nNorm
            // 
            this.nNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nNorm.Location = new System.Drawing.Point(989, 78);
            this.nNorm.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.nNorm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNorm.Name = "nNorm";
            this.nNorm.Size = new System.Drawing.Size(121, 44);
            this.nNorm.TabIndex = 34;
            this.nNorm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(624, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(270, 37);
            this.label15.TabIndex = 23;
            this.label15.Text = "Significance level:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1002, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 37);
            this.label16.TabIndex = 32;
            this.label16.Text = "%";
            // 
            // signLevBin
            // 
            this.signLevBin.DecimalPlaces = 1;
            this.signLevBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signLevBin.Location = new System.Drawing.Point(900, 32);
            this.signLevBin.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.signLevBin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.signLevBin.Name = "signLevBin";
            this.signLevBin.Size = new System.Drawing.Size(96, 44);
            this.signLevBin.TabIndex = 31;
            this.signLevBin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 648);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(1171, 719);
            this.Name = "MainScreen";
            this.Text = "Hypothesis Tester";
            this.tabControl.ResumeLayout(false);
            this.binomialTab.ResumeLayout(false);
            this.binomialTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.successRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H0_bin)).EndInit();
            this.normalTab.ResumeLayout(false);
            this.normalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signLev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNorm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signLevBin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage binomialTab;
        private System.Windows.Forms.Label conclusion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BinH0Res;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label probLbl;
        private System.Windows.Forms.ComboBox testType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown H0_bin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage normalTab;
        private System.Windows.Forms.NumericUpDown n;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown successRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown mu;
        private System.Windows.Forms.CheckBox allowDecimal;
        private System.Windows.Forms.NumericUpDown sampleMean;
        private System.Windows.Forms.Label sampleMeanLbl;
        private System.Windows.Forms.CheckBox dataMode;
        private System.Windows.Forms.TextBox sampleData;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.Label normConcl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label H0_normRes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button runBtn1;
        private System.Windows.Forms.Button runBtn2;
        private System.Windows.Forms.RadioButton testTypeChange;
        private System.Windows.Forms.RadioButton testTypeDecrease;
        private System.Windows.Forms.RadioButton testTypeIncrease;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown signLev;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown stdDev;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nNorm;
        private System.Windows.Forms.Label nNormLbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown signLevBin;
        private System.Windows.Forms.Label label15;
    }
}