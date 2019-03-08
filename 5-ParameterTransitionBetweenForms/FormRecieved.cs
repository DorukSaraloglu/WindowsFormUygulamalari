using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_ParameterTransitionBetweenForms
{
    public partial class FormRecieved : Form
    {
        public FormRecieved()
        {
            InitializeComponent();
        }

        public FormRecieved(string text)
        {
            InitializeComponent();
            lblRecieved.Text = text;
        }


        private void FormRecieved_Load(object sender, EventArgs e)
        {

        }
    }
}
