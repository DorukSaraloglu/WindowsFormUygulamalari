namespace _5_ParameterTransitionBetweenForms
{
    partial class FormRecieved
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
            this.lblRecieved = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecieved
            // 
            this.lblRecieved.AutoSize = true;
            this.lblRecieved.Location = new System.Drawing.Point(179, 76);
            this.lblRecieved.Name = "lblRecieved";
            this.lblRecieved.Size = new System.Drawing.Size(46, 17);
            this.lblRecieved.TabIndex = 0;
            this.lblRecieved.Text = "label1";
            // 
            // FormRecieved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 260);
            this.Controls.Add(this.lblRecieved);
            this.Name = "FormRecieved";
            this.Text = "FormRecieved";
            this.Load += new System.EventHandler(this.FormRecieved_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecieved;
    }
}