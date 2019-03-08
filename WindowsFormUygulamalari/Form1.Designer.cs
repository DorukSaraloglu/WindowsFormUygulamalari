namespace WindowsFormUygulamalari
{
    partial class Form1
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
            this.Panel = new System.Windows.Forms.Panel();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCharacter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxToUpperCase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxToLowerCase = new System.Windows.Forms.TextBox();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel.Controls.Add(this.tbxNumber);
            this.Panel.Controls.Add(this.label4);
            this.Panel.Controls.Add(this.tbxCharacter);
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.tbxToUpperCase);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.tbxToLowerCase);
            this.Panel.Location = new System.Drawing.Point(12, 12);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(392, 182);
            this.Panel.TabIndex = 11;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(147, 48);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(166, 22);
            this.tbxNumber.TabIndex = 1;
            this.tbxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxNumber_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Karakter Küçültme :";
            // 
            // tbxCharacter
            // 
            this.tbxCharacter.Location = new System.Drawing.Point(147, 10);
            this.tbxCharacter.Name = "tbxCharacter";
            this.tbxCharacter.Size = new System.Drawing.Size(166, 22);
            this.tbxCharacter.TabIndex = 0;
            this.tbxCharacter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxCharacter_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Karakter Büyütme :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı Gir :";
            // 
            // tbxToUpperCase
            // 
            this.tbxToUpperCase.Location = new System.Drawing.Point(147, 86);
            this.tbxToUpperCase.Name = "tbxToUpperCase";
            this.tbxToUpperCase.Size = new System.Drawing.Size(166, 22);
            this.tbxToUpperCase.TabIndex = 6;
            this.tbxToUpperCase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxToUpperCase_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Karakter Gir :";
            // 
            // tbxToLowerCase
            // 
            this.tbxToLowerCase.Location = new System.Drawing.Point(147, 124);
            this.tbxToLowerCase.Name = "tbxToLowerCase";
            this.tbxToLowerCase.Size = new System.Drawing.Size(166, 22);
            this.tbxToLowerCase.TabIndex = 5;
            this.tbxToLowerCase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxToLowerCase_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 225);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCharacter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxToUpperCase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxToLowerCase;
    }
}

