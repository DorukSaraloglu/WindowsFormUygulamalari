using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Bir tuşa bir kez basıldığında sırasıyla PreviewKeyUp, KeyDown, KeyPress, KeyUp olaylarını yapar. Eğer bir tuşa uzun süre basılırsa PreviewKeyUp, KeyDown, KeyPress olaylarını sırasıyla tekrar eder, en son KeyUp olayını gerçekleştirir.

        private void Write(string EventName)
        {
            lbxEvent.Items.Add(string.Format("{1} {0}", EventName, DateTime.Now));
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lbxEvent.Items.Clear();
        }

        private void TbxEvent_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Write("PreviewKeyDown");
        }

        private void TbxEvent_KeyDown(object sender, KeyEventArgs e)
        {
            Write("KeyDown");
        }

        private void TbxEvent_KeyPress(object sender, KeyPressEventArgs e)
        {
            Write("KeyPress");
        }

        private void TbxEvent_KeyUp(object sender, KeyEventArgs e)
        {
            Write("KeyUp");
        }
    }
}
