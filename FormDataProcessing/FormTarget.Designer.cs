namespace FormDataProcessing
{
    partial class FormTarget
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
            this.lblDescriptionShow = new System.Windows.Forms.Label();
            this.lblSurnameShow = new System.Windows.Forms.Label();
            this.lblNameShow = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescriptionShow
            // 
            this.lblDescriptionShow.AutoSize = true;
            this.lblDescriptionShow.Location = new System.Drawing.Point(196, 132);
            this.lblDescriptionShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescriptionShow.Name = "lblDescriptionShow";
            this.lblDescriptionShow.Size = new System.Drawing.Size(16, 17);
            this.lblDescriptionShow.TabIndex = 11;
            this.lblDescriptionShow.Text = "0";
            // 
            // lblSurnameShow
            // 
            this.lblSurnameShow.AutoSize = true;
            this.lblSurnameShow.Location = new System.Drawing.Point(196, 108);
            this.lblSurnameShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurnameShow.Name = "lblSurnameShow";
            this.lblSurnameShow.Size = new System.Drawing.Size(16, 17);
            this.lblSurnameShow.TabIndex = 10;
            this.lblSurnameShow.Text = "0";
            // 
            // lblNameShow
            // 
            this.lblNameShow.AutoSize = true;
            this.lblNameShow.Location = new System.Drawing.Point(196, 86);
            this.lblNameShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameShow.Name = "lblNameShow";
            this.lblNameShow.Size = new System.Drawing.Size(16, 17);
            this.lblNameShow.TabIndex = 9;
            this.lblNameShow.Text = "0";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(122, 132);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(68, 17);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Aciklama:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(122, 108);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(55, 17);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Soyadi:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(122, 86);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 17);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Adi:";
            // 
            // FormTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 265);
            this.Controls.Add(this.lblDescriptionShow);
            this.Controls.Add(this.lblSurnameShow);
            this.Controls.Add(this.lblNameShow);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "FormTarget";
            this.Text = "Hedef Form";
            this.Load += new System.EventHandler(this.FormTarget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDescriptionShow;
        public System.Windows.Forms.Label lblSurnameShow;
        public System.Windows.Forms.Label lblNameShow;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
    }
}