namespace HentRestgaeld
{
    partial class FormHentData
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonTilbage = new System.Windows.Forms.Button();
            this.backgroundWorkerValidateParty = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerHentRestgaeld = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerOmregningskurstabeller = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerEgneKurser = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerAlleKurser = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerPriser = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSatser = new System.ComponentModel.BackgroundWorker();
            this.tabPageInput = new System.Windows.Forms.TabPage();
            this.userControlOmregningstabelInput1 = new HentRestgaeld.UserControlOmregningstabelInput();
            this.userControlRestgaeldInput1 = new HentRestgaeld.UserControlRestgaeldInput();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelInput = new System.Windows.Forms.LinkLabel();
            this.linkLabelOutput = new System.Windows.Forms.LinkLabel();
            this.tabPageChoice = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDataType = new System.Windows.Forms.ComboBox();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.userControlLogon1 = new HentRestgaeld.UserControlLogon();
            this.wizardTabcontrol1 = new HentRestgaeld.WizardTabcontrol();
            this.statusStrip1.SuspendLayout();
            this.tabPageInput.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPageChoice.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.wizardTabcontrol1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 281);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(560, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel1.Text = "OK";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(468, 255);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "&Næste";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonTilbage
            // 
            this.buttonTilbage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTilbage.Location = new System.Drawing.Point(387, 255);
            this.buttonTilbage.Name = "buttonTilbage";
            this.buttonTilbage.Size = new System.Drawing.Size(75, 23);
            this.buttonTilbage.TabIndex = 0;
            this.buttonTilbage.Text = "&Tilbage";
            this.buttonTilbage.UseVisualStyleBackColor = true;
            this.buttonTilbage.Click += new System.EventHandler(this.ButtonTilbage_Click);
            // 
            // backgroundWorkerValidateParty
            // 
            this.backgroundWorkerValidateParty.WorkerReportsProgress = true;
            this.backgroundWorkerValidateParty.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerValidateParty_DoWork);
            this.backgroundWorkerValidateParty.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerValidateParty_ProgressChanged);
            this.backgroundWorkerValidateParty.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerValidateParty_RunWorkerCompleted);
            // 
            // backgroundWorkerHentRestgaeld
            // 
            this.backgroundWorkerHentRestgaeld.WorkerReportsProgress = true;
            this.backgroundWorkerHentRestgaeld.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerHentRestgaeld_DoWork);
            this.backgroundWorkerHentRestgaeld.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorkerHentRestgaeld.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // backgroundWorkerOmregningskurstabeller
            // 
            this.backgroundWorkerOmregningskurstabeller.WorkerReportsProgress = true;
            this.backgroundWorkerOmregningskurstabeller.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerOmregningskurstabeller_DoWork);
            this.backgroundWorkerOmregningskurstabeller.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorkerOmregningskurstabeller.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // backgroundWorkerEgneKurser
            // 
            this.backgroundWorkerEgneKurser.WorkerReportsProgress = true;
            // 
            // backgroundWorkerAlleKurser
            // 
            this.backgroundWorkerAlleKurser.WorkerReportsProgress = true;
            // 
            // backgroundWorkerPriser
            // 
            this.backgroundWorkerPriser.WorkerReportsProgress = true;
            // 
            // backgroundWorkerSatser
            // 
            this.backgroundWorkerSatser.WorkerReportsProgress = true;
            // 
            // tabPageInput
            // 
            this.tabPageInput.Controls.Add(this.userControlOmregningstabelInput1);
            this.tabPageInput.Controls.Add(this.userControlRestgaeldInput1);
            this.tabPageInput.Location = new System.Drawing.Point(4, 22);
            this.tabPageInput.Margin = new System.Windows.Forms.Padding(1);
            this.tabPageInput.Name = "tabPageInput";
            this.tabPageInput.Padding = new System.Windows.Forms.Padding(1);
            this.tabPageInput.Size = new System.Drawing.Size(528, 211);
            this.tabPageInput.TabIndex = 4;
            this.tabPageInput.Text = "tabPageInput";
            this.tabPageInput.UseVisualStyleBackColor = true;
            // 
            // userControlOmregningstabelInput1
            // 
            this.userControlOmregningstabelInput1.AutoSize = true;
            this.userControlOmregningstabelInput1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlOmregningstabelInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlOmregningstabelInput1.GyldigFraDato = new System.DateTime(((long)(0)));
            this.userControlOmregningstabelInput1.Location = new System.Drawing.Point(1, 1);
            this.userControlOmregningstabelInput1.Name = "userControlOmregningstabelInput1";
            this.userControlOmregningstabelInput1.Size = new System.Drawing.Size(526, 209);
            this.userControlOmregningstabelInput1.TabIndex = 2;
            // 
            // userControlRestgaeldInput1
            // 
            this.userControlRestgaeldInput1.AutoSize = true;
            this.userControlRestgaeldInput1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlRestgaeldInput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRestgaeldInput1.Kontrolkode = null;
            this.userControlRestgaeldInput1.Laanenummer = null;
            this.userControlRestgaeldInput1.Location = new System.Drawing.Point(1, 1);
            this.userControlRestgaeldInput1.Margin = new System.Windows.Forms.Padding(1);
            this.userControlRestgaeldInput1.Name = "userControlRestgaeldInput1";
            this.userControlRestgaeldInput1.Pantnummer = null;
            this.userControlRestgaeldInput1.Realkreditinstitut = FRestgaeld6.Kodeliste4.PRI;
            this.userControlRestgaeldInput1.Size = new System.Drawing.Size(526, 209);
            this.userControlRestgaeldInput1.TabIndex = 1;
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.tableLayoutPanel3);
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(528, 211);
            this.tabPageResult.TabIndex = 2;
            this.tabPageResult.Text = "tabPageResult";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.linkLabelInput, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.linkLabelOutput, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(73, 50);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // linkLabelInput
            // 
            this.linkLabelInput.AutoSize = true;
            this.linkLabelInput.Location = new System.Drawing.Point(3, 0);
            this.linkLabelInput.Name = "linkLabelInput";
            this.linkLabelInput.Size = new System.Drawing.Size(67, 13);
            this.linkLabelInput.TabIndex = 0;
            this.linkLabelInput.TabStop = true;
            this.linkLabelInput.Text = "Forespørgsel";
            this.linkLabelInput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // linkLabelOutput
            // 
            this.linkLabelOutput.AutoSize = true;
            this.linkLabelOutput.Location = new System.Drawing.Point(3, 25);
            this.linkLabelOutput.Name = "linkLabelOutput";
            this.linkLabelOutput.Size = new System.Drawing.Size(29, 13);
            this.linkLabelOutput.TabIndex = 1;
            this.linkLabelOutput.TabStop = true;
            this.linkLabelOutput.Text = "Svar";
            this.linkLabelOutput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // tabPageChoice
            // 
            this.tabPageChoice.Controls.Add(this.tableLayoutPanel4);
            this.tabPageChoice.Location = new System.Drawing.Point(4, 22);
            this.tabPageChoice.Margin = new System.Windows.Forms.Padding(1);
            this.tabPageChoice.Name = "tabPageChoice";
            this.tabPageChoice.Padding = new System.Windows.Forms.Padding(1);
            this.tabPageChoice.Size = new System.Drawing.Size(528, 211);
            this.tabPageChoice.TabIndex = 3;
            this.tabPageChoice.Text = "tabPageChoice";
            this.tabPageChoice.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxDataType, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(520, 203);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hvad vil du hente?";
            // 
            // comboBoxDataType
            // 
            this.comboBoxDataType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDataType.FormattingEnabled = true;
            this.comboBoxDataType.Location = new System.Drawing.Point(263, 3);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(254, 21);
            this.comboBoxDataType.TabIndex = 0;
            this.comboBoxDataType.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataType_SelectedIndexChanged);
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.userControlLogon1);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(528, 211);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // userControlLogon1
            // 
            this.userControlLogon1.AutoSize = true;
            this.userControlLogon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlLogon1.Location = new System.Drawing.Point(3, 3);
            this.userControlLogon1.Margin = new System.Windows.Forms.Padding(1);
            this.userControlLogon1.Miljoe = HentRestgaeld.Miljoe.Test;
            this.userControlLogon1.Name = "userControlLogon1";
            this.userControlLogon1.PartID = null;
            this.userControlLogon1.Password = null;
            this.userControlLogon1.Size = new System.Drawing.Size(522, 205);
            this.userControlLogon1.TabIndex = 0;
            // 
            // wizardTabcontrol1
            // 
            this.wizardTabcontrol1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardTabcontrol1.Controls.Add(this.tabPageLogin);
            this.wizardTabcontrol1.Controls.Add(this.tabPageChoice);
            this.wizardTabcontrol1.Controls.Add(this.tabPageInput);
            this.wizardTabcontrol1.Controls.Add(this.tabPageResult);
            this.wizardTabcontrol1.Location = new System.Drawing.Point(12, 12);
            this.wizardTabcontrol1.Name = "wizardTabcontrol1";
            this.wizardTabcontrol1.SelectedIndex = 0;
            this.wizardTabcontrol1.Size = new System.Drawing.Size(536, 237);
            this.wizardTabcontrol1.TabIndex = 2;
            // 
            // FormHentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 303);
            this.Controls.Add(this.buttonTilbage);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.wizardTabcontrol1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormHentData";
            this.Text = "Hent restgæld";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPageInput.ResumeLayout(false);
            this.tabPageInput.PerformLayout();
            this.tabPageResult.ResumeLayout(false);
            this.tabPageResult.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPageChoice.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.wizardTabcontrol1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonTilbage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerValidateParty;
        private System.ComponentModel.BackgroundWorker backgroundWorkerHentRestgaeld;
        private System.ComponentModel.BackgroundWorker backgroundWorkerOmregningskurstabeller;
        private System.ComponentModel.BackgroundWorker backgroundWorkerEgneKurser;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAlleKurser;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPriser;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSatser;
        private System.Windows.Forms.TabPage tabPageInput;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.LinkLabel linkLabelInput;
        private System.Windows.Forms.LinkLabel linkLabelOutput;
        private System.Windows.Forms.TabPage tabPageChoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBoxDataType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageLogin;
        private WizardTabcontrol wizardTabcontrol1;
        private UserControlRestgaeldInput userControlRestgaeldInput1;
        private UserControlLogon userControlLogon1;
        private UserControlOmregningstabelInput userControlOmregningstabelInput1;
    }
}

