namespace EventOrder
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
            this.btnClear = new System.Windows.Forms.Button();
            this.lbxEvent = new System.Windows.Forms.ListBox();
            this.tbxEvent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(154, 395);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lbxEvent
            // 
            this.lbxEvent.FormattingEnabled = true;
            this.lbxEvent.ItemHeight = 16;
            this.lbxEvent.Location = new System.Drawing.Point(12, 201);
            this.lbxEvent.Name = "lbxEvent";
            this.lbxEvent.Size = new System.Drawing.Size(375, 164);
            this.lbxEvent.TabIndex = 4;
            // 
            // tbxEvent
            // 
            this.tbxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxEvent.Location = new System.Drawing.Point(12, 12);
            this.tbxEvent.Multiline = true;
            this.tbxEvent.Name = "tbxEvent";
            this.tbxEvent.Size = new System.Drawing.Size(375, 162);
            this.tbxEvent.TabIndex = 3;
            this.tbxEvent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxEvent_KeyDown);
            this.tbxEvent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxEvent_KeyPress);
            this.tbxEvent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbxEvent_KeyUp);
            this.tbxEvent.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TbxEvent_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 430);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbxEvent);
            this.Controls.Add(this.tbxEvent);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbxEvent;
        private System.Windows.Forms.TextBox tbxEvent;
    }
}

