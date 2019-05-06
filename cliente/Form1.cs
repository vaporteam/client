using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
            Button Btn = (Button)sender;
            string Status = Btn.Text;
            string Description = TextBox_Razon.Text;

            DialogResult PopUpAnsewer;
            switch (Status)
            {
                case "Off":
                    string Title = "Apagar";
                    string Message = "Estas Seguro?";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    int Height = 120;
                    PopUpAnsewer = MetroFramework.MetroMessageBox.Show(this, message: Message, height: Height, title: Title, buttons: buttons);
                    break;
                default:
                    PopUpAnsewer = DialogResult.None;
                    break;
            }

            Exception exc;
            if ((exc = new Status(Status, Description).Post()) != null)
            {
                MetroFramework.MetroMessageBox.Show(this, message: exc.Message, height: 120, title: "Error");
            }

            if ((DialogResult.Yes == PopUpAnsewer) && (Status == "Off"))
            {
                if (!WTSDisconnectSession(WTS_CURRENT_SERVER_HANDLE, WTS_CURRENT_SESSION, false))
                    throw new Win32Exception();
            }
            else if (Btn.Text == "Comida")
            {

                int count = 60;
                ThreadPool.QueueUserWorkItem((s) =>
                {
                    
                    while (count >= 0)
                    {
                        Console.WriteLine("{0} minutos", count);
                        Thread.Sleep(1000);
                        count--;
                    }
                });
                MetroFramework.MetroMessageBox.Show(this, message: (count + " minutos"), height: 120, title: "Comida");
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, message: "Enviado", height: 120, title: "Post");
            }
            TextBox_Razon.Text = "";
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
         
        [DllImport("wtsapi32.dll", SetLastError = true)]
        static extern bool WTSDisconnectSession(IntPtr hServer, int sessionId, bool bWait);
        const int WTS_CURRENT_SESSION = -1;
        static readonly IntPtr WTS_CURRENT_SERVER_HANDLE = IntPtr.Zero;
    }
}
