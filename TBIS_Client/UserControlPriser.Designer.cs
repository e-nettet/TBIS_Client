namespace HentRestgaeld
{
    partial class UserControlPriser
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
            this.comboBoxInstitut = new System.Windows.Forms.ComboBox();
            this.comboBoxForretningsområde = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxInstitut, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxForretningsområde, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 328);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxInstitut
            // 
            this.comboBoxInstitut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxInstitut.FormattingEnabled = true;
            this.comboBoxInstitut.Location = new System.Drawing.Point(434, 5);
            this.comboBoxInstitut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxInstitut.Name = "comboBoxInstitut";
            this.comboBoxInstitut.Size = new System.Drawing.Size(422, 28);
            this.comboBoxInstitut.TabIndex = 0;
            this.comboBoxInstitut.Text = "<Vælg institut>";
            this.comboBoxInstitut.SelectedIndexChanged += new System.EventHandler(this.comboBoxInstitut_SelectedIndexChanged);
            // 
            // comboBoxForretningsområde
            // 
            this.comboBoxForretningsområde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxForretningsområde.FormattingEnabled = true;
            this.comboBoxForretningsområde.Location = new System.Drawing.Point(434, 40);
            this.comboBoxForretningsområde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxForretningsområde.Name = "comboBoxForretningsområde";
            this.comboBoxForretningsområde.Size = new System.Drawing.Size(422, 28);
            this.comboBoxForretningsområde.TabIndex = 1;
            this.comboBoxForretningsområde.Text = "<Vælg forretningsområde>";
            this.comboBoxForretningsområde.SelectedIndexChanged += new System.EventHandler(this.comboBoxForretningsområde_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Institut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Forretningsområde (30=helårsbolig)";
            // 
            // UserControlPriser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlPriser";
            this.Size = new System.Drawing.Size(870, 338);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxInstitut;
        private System.Windows.Forms.ComboBox comboBoxForretningsområde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
