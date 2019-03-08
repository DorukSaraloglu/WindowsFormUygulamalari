namespace FormdaRenkDegistirme
{
    partial class FormColorChanging
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
            this.btnColorChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEnterColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnColorChange
            // 
            this.btnColorChange.Location = new System.Drawing.Point(182, 142);
            this.btnColorChange.Name = "btnColorChange";
            this.btnColorChange.Size = new System.Drawing.Size(128, 36);
            this.btnColorChange.TabIndex = 0;
            this.btnColorChange.Text = "Renk değiştir";
            this.btnColorChange.UseVisualStyleBackColor = true;
            this.btnColorChange.Click += new System.EventHandler(this.BtnColorChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Renk girin:";
            // 
            // tbxEnterColor
            // 
            this.tbxEnterColor.Location = new System.Drawing.Point(182, 81);
            this.tbxEnterColor.Name = "tbxEnterColor";
            this.tbxEnterColor.Size = new System.Drawing.Size(128, 22);
            this.tbxEnterColor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "- Kırmızı, Mavi veya Yeşil renklerinden birini seçin.";
            // 
            // FormColorChanging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 257);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxEnterColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnColorChange);
            this.Name = "FormColorChanging";
            this.Text = "Renk Seçme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColorChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEnterColor;
        private System.Windows.Forms.Label label2;
    }
}