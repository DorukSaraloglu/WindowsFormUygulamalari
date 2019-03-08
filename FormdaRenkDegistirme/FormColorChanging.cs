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
    public partial class FormColorChanging : Form
    {
        public Form ConnectedMainForm;

        public FormColorChanging(Form p)
        {
            InitializeComponent();
            ConnectedMainForm = p;
        }

        Color ColorCode(string ColorText)
        {
            switch (ColorText.ToLower())
            {
                case "kırmızı":
                    return Color.Red;
                case "mavi":
                    return Color.Blue;
                case "yeşil":
                    return Color.Green;
                default:
                    throw new NotImplementedException();
            }
        }

        public Color NewColor(Color LastColor)
        {
            try
            {
                return ColorCode(tbxEnterColor.Text);
            }
            catch (Exception)
            {
                // MessageBox.Show("Girilen renk tanımlı değil. Önceki renk uygulandı.");
                return LastColor;
            }
        }

        private void BtnColorChange_Click(object sender, EventArgs e)
        {
            Hide();
            // Timer ile calistiracagimizda alttaki satirlar kapatilmali
            try
            {
                if (ConnectedMainForm != null)
                {
                    ConnectedMainForm.BackColor = ColorCode(tbxEnterColor.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Renk değeri tanımlı değil");
            }
        }
    }
}
