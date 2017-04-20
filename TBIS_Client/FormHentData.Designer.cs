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
            this.wizardTabcontrol1 = new HentRestgaeld.WizardTabcontrol();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPartID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMiljoe = new System.Windows.Forms.ComboBox();
            this.tabPagePantident = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxKontrolkode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLaanenummer = new System.Windows.Forms.TextBox();
            this.textBoxPantnummer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRealkreditinstitut = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelInput = new System.Windows.Forms.LinkLabel();
            this.linkLabelOutput = new System.Windows.Forms.LinkLabel();
            this.statusStrip1.SuspendLayout();
            this.wizardTabcontrol1.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPagePantident.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 37, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1261, 22);
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
            this.buttonNext.Location = new System.Drawing.Point(1016, 553);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(200, 55);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "&Næste";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonTilbage
            // 
            this.buttonTilbage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTilbage.Location = new System.Drawing.Point(800, 553);
            this.buttonTilbage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonTilbage.Name = "buttonTilbage";
            this.buttonTilbage.Size = new System.Drawing.Size(200, 55);
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
            this.backgroundWorkerHentRestgaeld.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerHentRestgaeld_ProgressChanged);
            this.backgroundWorkerHentRestgaeld.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerHentRestgaeld_RunWorkerCompleted);
            // 
            // wizardTabcontrol1
            // 
            this.wizardTabcontrol1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wizardTabcontrol1.Controls.Add(this.tabPageLogin);
            this.wizardTabcontrol1.Controls.Add(this.tabPagePantident);
            this.wizardTabcontrol1.Controls.Add(this.tabPage1);
            this.wizardTabcontrol1.Location = new System.Drawing.Point(32, 29);
            this.wizardTabcontrol1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.wizardTabcontrol1.Name = "wizardTabcontrol1";
            this.wizardTabcontrol1.SelectedIndex = 0;
            this.wizardTabcontrol1.Size = new System.Drawing.Size(1197, 510);
            this.wizardTabcontrol1.TabIndex = 2;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.tableLayoutPanel1);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 40);
            this.tabPageLogin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPageLogin.Size = new System.Drawing.Size(1189, 466);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPartID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxMiljoe, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1144, 277);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Miljø";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Location = new System.Drawing.Point(580, 127);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(556, 38);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxPartID
            // 
            this.textBoxPartID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPartID.Location = new System.Drawing.Point(580, 67);
            this.textBoxPartID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxPartID.Name = "textBoxPartID";
            this.textBoxPartID.Size = new System.Drawing.Size(556, 38);
            this.textBoxPartID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PartID";
            // 
            // comboBoxMiljoe
            // 
            this.comboBoxMiljoe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMiljoe.FormattingEnabled = true;
            this.comboBoxMiljoe.Location = new System.Drawing.Point(580, 7);
            this.comboBoxMiljoe.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxMiljoe.Name = "comboBoxMiljoe";
            this.comboBoxMiljoe.Size = new System.Drawing.Size(556, 39);
            this.comboBoxMiljoe.TabIndex = 0;
            this.comboBoxMiljoe.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMiljoe_SelectedIndexChanged);
            // 
            // tabPagePantident
            // 
            this.tabPagePantident.Controls.Add(this.tableLayoutPanel2);
            this.tabPagePantident.Location = new System.Drawing.Point(4, 40);
            this.tabPagePantident.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPagePantident.Name = "tabPagePantident";
            this.tabPagePantident.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPagePantident.Size = new System.Drawing.Size(1189, 466);
            this.tabPagePantident.TabIndex = 1;
            this.tabPagePantident.Text = "Pantid";
            this.tabPagePantident.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxKontrolkode, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLaanenummer, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxPantnummer, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxRealkreditinstitut, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 14);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1144, 420);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // textBoxKontrolkode
            // 
            this.textBoxKontrolkode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKontrolkode.Location = new System.Drawing.Point(580, 187);
            this.textBoxKontrolkode.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxKontrolkode.Name = "textBoxKontrolkode";
            this.textBoxKontrolkode.Size = new System.Drawing.Size(556, 38);
            this.textBoxKontrolkode.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 180);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 31);
            this.label10.TabIndex = 7;
            this.label10.Text = "Kontrolkode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lånenummer";
            // 
            // textBoxLaanenummer
            // 
            this.textBoxLaanenummer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLaanenummer.Location = new System.Drawing.Point(580, 127);
            this.textBoxLaanenummer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxLaanenummer.Name = "textBoxLaanenummer";
            this.textBoxLaanenummer.Size = new System.Drawing.Size(556, 38);
            this.textBoxLaanenummer.TabIndex = 2;
            // 
            // textBoxPantnummer
            // 
            this.textBoxPantnummer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPantnummer.Location = new System.Drawing.Point(580, 67);
            this.textBoxPantnummer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxPantnummer.Name = "textBoxPantnummer";
            this.textBoxPantnummer.Size = new System.Drawing.Size(556, 38);
            this.textBoxPantnummer.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(394, 31);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ejendomsnummer/Pantnummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Realkreditinstitut";
            // 
            // comboBoxRealkreditinstitut
            // 
            this.comboBoxRealkreditinstitut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRealkreditinstitut.FormattingEnabled = true;
            this.comboBoxRealkreditinstitut.Location = new System.Drawing.Point(580, 7);
            this.comboBoxRealkreditinstitut.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxRealkreditinstitut.Name = "comboBoxRealkreditinstitut";
            this.comboBoxRealkreditinstitut.Size = new System.Drawing.Size(556, 39);
            this.comboBoxRealkreditinstitut.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Size = new System.Drawing.Size(1189, 466);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPageResult";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.linkLabelInput, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.linkLabelOutput, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(19, 17);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1141, 417);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // linkLabelInput
            // 
            this.linkLabelInput.AutoSize = true;
            this.linkLabelInput.Location = new System.Drawing.Point(8, 0);
            this.linkLabelInput.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.linkLabelInput.Name = "linkLabelInput";
            this.linkLabelInput.Size = new System.Drawing.Size(173, 31);
            this.linkLabelInput.TabIndex = 0;
            this.linkLabelInput.TabStop = true;
            this.linkLabelInput.Text = "Forespørgsel";
            this.linkLabelInput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // linkLabelOutput
            // 
            this.linkLabelOutput.AutoSize = true;
            this.linkLabelOutput.Location = new System.Drawing.Point(8, 60);
            this.linkLabelOutput.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.linkLabelOutput.Name = "linkLabelOutput";
            this.linkLabelOutput.Size = new System.Drawing.Size(70, 31);
            this.linkLabelOutput.TabIndex = 1;
            this.linkLabelOutput.TabStop = true;
            this.linkLabelOutput.Text = "Svar";
            this.linkLabelOutput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // FormHentRestgaeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 668);
            this.Controls.Add(this.buttonTilbage);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.wizardTabcontrol1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormHentRestgaeld";
            this.Text = "Hent restgæld";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.wizardTabcontrol1.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPagePantident.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private WizardTabcontrol wizardTabcontrol1;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPartID;
        private System.Windows.Forms.TabPage tabPagePantident;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxKontrolkode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonTilbage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBoxPantnummer;
        private System.Windows.Forms.TextBox textBoxLaanenummer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRealkreditinstitut;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMiljoe;
        private System.ComponentModel.BackgroundWorker backgroundWorkerValidateParty;
        private System.ComponentModel.BackgroundWorker backgroundWorkerHentRestgaeld;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.LinkLabel linkLabelInput;
        private System.Windows.Forms.LinkLabel linkLabelOutput;
    }
}

