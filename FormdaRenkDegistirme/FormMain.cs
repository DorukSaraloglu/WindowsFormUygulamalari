using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormdaRenkDegistirme
{
    public partial class FormMain : Form
    {
        FormColorChanging frm;
        public FormMain()
        {
            InitializeComponent();

            frm = new FormColorChanging(this);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            // Timer ile çalışacağımızda alt satır açılmalı.
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BackColor = frm.NewColor(BackColor);
        }

        private void btnBackcolorChange_Click(object sender, EventArgs e)
        {
            frm.Show();
            //RenkDeğiştirenForm frm = new RenkDeğiştirenForm();
            //frm.ShowDialog();
            //this.BackColor = frm.RenkDeğiştir(this.BackColor);
        }
    }
}
