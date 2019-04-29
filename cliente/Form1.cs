using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cliente
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TriggerStatus(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (!new Status(b.Text).Post())
            {
                MetroFramework.MetroMessageBox.Show(this, message: "Posting", height: 120, title: "Error");
            }
        }
        private void Bt_comida_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.LightGray;
        }

        private void Bt_comida_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.MediumOrchid;
            btn.ForeColor = Color.Black;
        }

        private void Bt_comida_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.LightGray;
        }
    }
}
