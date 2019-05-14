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
            this.backgroundWorkerHentData = new System.ComponentModel.BackgroundWorker();
            this.wizardTabcontrol1 = new HentRestgaeld.WizardTabcontrol();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.userControlLogon1 = new HentRestgaeld.UserControlLogon();
            this.tabPageChoice = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxDataType = new System.Windows.Forms.ComboBox();
            this.tabPageInput = new System.Windows.Forms.TabPage();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelInput = new System.Windows.Forms.LinkLabel();
            this.linkLabelOutput = new System.Windows.Forms.LinkLabel();
            this.statusStrip1.SuspendLayout();
            this.wizardTabcontrol1.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageChoice.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(991, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 25);
            this.toolStripStatusLabel1.Text = "OK";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(853, 580);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(112, 35);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "&Næste";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonTilbage
            // 
            this.buttonTilbage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTilbage.Location = new System.Drawing.Point(731, 580);
            this.buttonTilbage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTilbage.Name = "buttonTilbage";
            this.buttonTilbage.Size = new System.Drawing.Size(112, 35);
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
            // backgroundWorkerHentData
            // 
            this.backgroundWorkerHentData.WorkerReportsProgress = true;
            this.backgroundWorkerHentData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerHentData_DoWork);
            this.backgroundWorkerHentData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorkerHentData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
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
            this.wizardTabcontrol1.Location = new System.Drawing.Point(20, 18);
            this.wizardTabcontrol1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wizardTabcontrol1.Name = "wizardTabcontrol1";
            this.wizardTabcontrol1.SelectedIndex = 0;
            this.wizardTabcontrol1.Size = new System.Drawing.Size(955, 554);
            this.wizardTabcontrol1.TabIndex = 2;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.userControlLogon1);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 29);
            this.tabPageLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageLogin.Size = new System.Drawing.Size(947, 521);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // userControlLogon1
            // 
            this.userControlLogon1.AutoSize = true;
            this.userControlLogon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlLogon1.Location = new System.Drawing.Point(4, 5);
            this.userControlLogon1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlLogon1.Miljoe = HentRestgaeld.Miljoe.Test;
            this.userControlLogon1.Name = "userControlLogon1";
            this.userControlLogon1.PartID = null;
            this.userControlLogon1.Password = null;
            this.userControlLogon1.Size = new System.Drawing.Size(939, 511);
            this.userControlLogon1.TabIndex = 0;
            // 
            // tabPageChoice
            // 
            this.tabPageChoice.Controls.Add(this.comboBoxDataType);
            this.tabPageChoice.Controls.Add(this.label5);
            this.tabPageChoice.Controls.Add(this.tableLayoutPanel4);
            this.tabPageChoice.Location = new System.Drawing.Point(4, 29);
            this.tabPageChoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageChoice.Name = "tabPageChoice";
            this.tabPageChoice.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageChoice.Size = new System.Drawing.Size(947, 521);
            this.tabPageChoice.TabIndex = 3;
            this.tabPageChoice.Text = "tabPageChoice";
            this.tabPageChoice.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hvad vil du hente?";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // comboBoxDataType
            // 
            this.comboBoxDataType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDataType.FormattingEnabled = true;
            this.comboBoxDataType.Location = new System.Drawing.Point(148, 14);
            this.comboBoxDataType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDataType.Name = "comboBoxDataType";
            this.comboBoxDataType.Size = new System.Drawing.Size(793, 28);
            this.comboBoxDataType.TabIndex = 1;
            // 
            // tabPageInput
            // 
            this.tabPageInput.Location = new System.Drawing.Point(4, 29);
            this.tabPageInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageInput.Name = "tabPageInput";
            this.tabPageInput.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageInput.Size = new System.Drawing.Size(947, 521);
            this.tabPageInput.TabIndex = 4;
            this.tabPageInput.Text = "tabPageInput";
            this.tabPageInput.UseVisualStyleBackColor = true;
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.tableLayoutPanel3);
            this.tabPageResult.Location = new System.Drawing.Point(4, 29);
            this.tabPageResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageResult.Size = new System.Drawing.Size(947, 521);
            this.tabPageResult.TabIndex = 2;
            this.tabPageResult.Text = "tabPageResult";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.linkLabelInput, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.linkLabelOutput, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 11);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(110, 76);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // linkLabelInput
            // 
            this.linkLabelInput.AutoSize = true;
            this.linkLabelInput.Location = new System.Drawing.Point(4, 0);
            this.linkLabelInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelInput.Name = "linkLabelInput";
            this.linkLabelInput.Size = new System.Drawing.Size(102, 20);
            this.linkLabelInput.TabIndex = 0;
            this.linkLabelInput.TabStop = true;
            this.linkLabelInput.Text = "Forespørgsel";
            this.linkLabelInput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // linkLabelOutput
            // 
            this.linkLabelOutput.AutoSize = true;
            this.linkLabelOutput.Location = new System.Drawing.Point(4, 38);
            this.linkLabelOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelOutput.Name = "linkLabelOutput";
            this.linkLabelOutput.Size = new System.Drawing.Size(41, 20);
            this.linkLabelOutput.TabIndex = 1;
            this.linkLabelOutput.TabStop = true;
            this.linkLabelOutput.Text = "Svar";
            this.linkLabelOutput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // FormHentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 654);
            this.Controls.Add(this.buttonTilbage);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.wizardTabcontrol1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHentData";
            this.Text = "Hent restgæld";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.wizardTabcontrol1.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabPageChoice.ResumeLayout(false);
            this.tabPageChoice.PerformLayout();
            this.tabPageResult.ResumeLayout(false);
            this.tabPageResult.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonTilbage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerValidateParty;
        private System.ComponentModel.BackgroundWorker backgroundWorkerHentData;
        private System.Windows.Forms.TabPage tabPageInput;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.LinkLabel linkLabelInput;
        private System.Windows.Forms.LinkLabel linkLabelOutput;
        private System.Windows.Forms.TabPage tabPageChoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageLogin;
        private WizardTabcontrol wizardTabcontrol1;
        private UserControlLogon userControlLogon1;
        private System.Windows.Forms.ComboBox comboBoxDataType;
    }
}

