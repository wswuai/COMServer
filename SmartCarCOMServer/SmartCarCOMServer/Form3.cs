using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCarCOMServer
{
    public partial class Logger : Form
    {
        main_form parent;
        public Logger()
        {
            InitializeComponent();
        }
        public Logger(main_form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        private void Logger_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(parent.Location.X , parent.Location.Y + parent.Size.Height +2);
            this.Richbox_Loggor.AutoScrollOffset = new Point(0, 1000);

        }
        public RichTextBox getLogger()
        {
            return this.Richbox_Loggor;
        }
        private delegate void SetTextCallback(string text);
        public void LoggerAppend(String s)
        {
            if (this.InvokeRequired == true)
            {
                SetTextCallback d = new SetTextCallback(LoggerAppend);
                this.Invoke(d, new object[] { s });
            }
            else
            {/*
                this.Richbox_Loggor.Text += "[" +
                            DateTime.Now.Hour.ToString() + ":" +
                            DateTime.Now.Minute.ToString() + ":" +
                            DateTime.Now.Second.ToString() + "]" +
                            s + "\n";*/
                this.Richbox_Loggor.Text += "["+DateTime.Now.ToString("HH:mm:ss") + "]"+ s + "\n";
            }
        }

        private void Richbox_Loggor_TextChanged(object sender, EventArgs e)
        {
            this.Richbox_Loggor.SelectionStart = Richbox_Loggor.TextLength;
            //滚动到当前光标处 
            this.Richbox_Loggor.ScrollToCaret(); 

        }

    }
}
