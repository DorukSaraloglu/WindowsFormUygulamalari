using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDataProcessing
{
    public partial class FormMain : Form
    {

        FormTarget frm = new FormTarget();//Ana formda girilen verileri hedef formda göstermek için Hedeffomu formu instance açtık.
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnChangeFont_Click(object sender, EventArgs e)
        {
            FontAl();//Fontları alma metotunu çağırdık.
        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            RenkAl();//renkleri alma metotunu çağırdık.
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();//Silme metotunu çağırdık.
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            GonderilecekVeriler();//Gönderilecek Verileri alma metotunu çağırdık.
        }

        public void RenkAl()//Renk fontu için metot oluşturduk.
        {
            ColorDialog color = new ColorDialog();//Color renk dialogunu çağırdık.
            color.ShowDialog();
            tbxName.ForeColor = color.Color;
            tbxSurname.ForeColor = color.Color;
            tbxDescription.ForeColor = color.Color;
        }
        public void FontAl()
        {
            FontDialog fontlar = new FontDialog();//Fon dialogunu çağırdık.
            fontlar.ShowDialog();
            tbxName.Font = fontlar.Font;
            tbxSurname.Font = fontlar.Font;
            tbxDescription.Font = fontlar.Font;
        }
        public void GonderilecekVeriler()//Gönderilecek veriler için bir metot oluşturduk
        {
            frm.lblNameShow.Text = tbxName.Text.Substring(0, 1).ToUpper() + tbxName.Text.Substring(1);//Girilen ismin ilk harfi küçük girilse bie  büyük harfe dönüştürdük.
            frm.lblNameShow.Font = tbxName.Font;
            frm.lblNameShow.ForeColor = tbxName.ForeColor;

            frm.lblSurnameShow.Text = tbxSurname.Text.ToUpper();//Girilen soyismi küçük harf girilse bile büyük harfe dönüştürdük.
            frm.lblSurnameShow.Font = tbxSurname.Font;
            frm.lblSurnameShow.ForeColor = tbxSurname.ForeColor;

            frm.lblDescriptionShow.Text = tbxDescription.Text;
            frm.lblDescriptionShow.Font = tbxDescription.Font;
            frm.lblDescriptionShow.ForeColor = tbxDescription.ForeColor;

            frm.Show();
        }
        public void Clear()//Clear metotunu oluşturduk.
        {
            tbxName.Clear();
            tbxDescription.Clear();
            tbxSurname.Clear();
            frm.Hide();
        }

    }
}
