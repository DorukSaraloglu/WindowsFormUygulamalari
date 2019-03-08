using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormUygulamalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //e.Handled=false yani basılan tuşu kabul et diyoruz.
        private void TbxCharacter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void TbxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TbxToUpperCase_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbxToUpperCase.CharacterCasing = CharacterCasing.Upper;
        }

        private void TbxToLowerCase_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbxToLowerCase.CharacterCasing = CharacterCasing.Lower;
        }
    }
}
