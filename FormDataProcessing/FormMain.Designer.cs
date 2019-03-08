namespace FormDataProcessing
{
    partial class FormMain
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(65, 23);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(271, 86);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Önemli Not!!\r\nForm üzerindeki bütün kontollerdeki modifier özelliğini\r\npublic yap" +
    "tık.";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(68, 313);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 27);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(204, 313);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 27);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Gonder";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Aciklama:";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(141, 198);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(163, 48);
            this.tbxDescription.TabIndex = 17;
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(204, 260);
            this.btnChangeColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(100, 26);
            this.btnChangeColor.TabIndex = 16;
            this.btnChangeColor.Text = "Renk Ayarla";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.BtnChangeColor_Click);
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(68, 261);
            this.btnChangeFont.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(107, 25);
            this.btnChangeFont.TabIndex = 15;
            this.btnChangeFont.Text = "Font Ayarla";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.BtnChangeFont_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyadi:";
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(141, 165);
            this.tbxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSurname.Multiline = true;
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(163, 29);
            this.tbxSurname.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(1111300, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adi  :";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(141, 131);
            this.tbxName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(163, 32);
            this.tbxName.TabIndex = 11;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 362);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.Name = "FormMain";
            this.Text = "Ana Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbxName;
    }
}

