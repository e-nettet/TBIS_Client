namespace HentRestgaeld
{
    partial class UserControlEjendomSummarisk
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCadastralDistrictIdentifier = new System.Windows.Forms.TextBox();
            this.textBoxMatrikelnummer = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCadastralDistrictIdentifier, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMatrikelnummer, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 93);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CadastralDistrictIdentifier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matrikelnummer";
            // 
            // textBoxCadastralDistrictIdentifier
            // 
            this.textBoxCadastralDistrictIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCadastralDistrictIdentifier.Location = new System.Drawing.Point(227, 2);
            this.textBoxCadastralDistrictIdentifier.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCadastralDistrictIdentifier.Name = "textBoxCadastralDistrictIdentifier";
            this.textBoxCadastralDistrictIdentifier.Size = new System.Drawing.Size(221, 20);
            this.textBoxCadastralDistrictIdentifier.TabIndex = 2;
            this.textBoxCadastralDistrictIdentifier.TextChanged += new System.EventHandler(this.textBoxCadastralDistrictIdentifier_TextChanged);
            // 
            // textBoxMatrikelnummer
            // 
            this.textBoxMatrikelnummer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMatrikelnummer.Location = new System.Drawing.Point(227, 27);
            this.textBoxMatrikelnummer.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMatrikelnummer.Name = "textBoxMatrikelnummer";
            this.textBoxMatrikelnummer.Size = new System.Drawing.Size(221, 20);
            this.textBoxMatrikelnummer.TabIndex = 3;
            this.textBoxMatrikelnummer.TextChanged += new System.EventHandler(this.textBoxMatrikelnummer_TextChanged);
            // 
            // UserControlEjendomSummarisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlEjendomSummarisk";
            this.Size = new System.Drawing.Size(455, 97);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCadastralDistrictIdentifier;
        private System.Windows.Forms.TextBox textBoxMatrikelnummer;
    }
}
