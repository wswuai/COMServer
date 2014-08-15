using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SmartCarCOMServer
{
    public partial class Form2 : Form
    {
        
        public main_form parent;
        public SerialPort comport;
        public Form2(main_form f)
        {
            InitializeComponent();
            this.parent = f;
            
        }
        public Form2()
        {
            InitializeComponent();
        }

        private delegate void SetTextCallback(string text);
        private delegate void SetTextCallBack2(byte[] bytes, int cnt);
        public void Set_RXBox_Text(string text)
        {
                if (this.RX_Box.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(Set_RXBox_Text);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    if (this.RX_HEX.Checked == true)
                    {
                        StringBuilder tmp = new StringBuilder();

                            foreach (Char chr in text)
                            {
                                if (chr < 16)
                                    tmp.Append("0");
                                tmp.Append(Convert.ToString(chr, 16).ToUpper() + " ");
                            }
                            this.RX_Box.Text += tmp.ToString();
                    }
                    else
                    {
                        this.RX_Box.Text += text;
                    }
                    this.RX_Box.Refresh();
                }
        }
        public void Set_RXBox_Text(byte[] bytes, int cnt)
        {
            if (this.RX_Box.InvokeRequired)
            {
                SetTextCallBack2 d = new SetTextCallBack2(Set_RXBox_Text);
                this.Invoke(d, new object[] { bytes , cnt});
            }
            else
            {
                if (this.RX_HEX.Checked == true)
                {
                    StringBuilder tmp = new StringBuilder();

                    for (int i = 0; i < cnt;i++ )
                    {
                        if (bytes[i] <= 15)
                            tmp.Append("0");
                        tmp.Append(Convert.ToString(bytes[i], 16).ToUpper() + " ");
                    }
                    this.RX_Box.Text += tmp.ToString();
                }
                else
                {
                    for(int i=0;i<cnt;i++)
                    {

                        this.RX_Box.Text += (char)bytes[i];
                    }
                }
                this.RX_Box.Refresh();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(parent.Location.X + parent.Size.Width +5,parent.Location.Y);
            this.RX_Box.AutoScrollOffset = new Point(0, 2000);
            this.TX_Box.AutoScrollOffset = new Point(0, 2000);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(this.CheckBox_autodelete.Checked == true)
            if (RX_Box.Lines.Length > 10) RX_Box.Text = "";
            this.RX_Box.SelectionStart = RX_Box.TextLength;
            //滚动到当前光标处 
            this.RX_Box.ScrollToCaret(); 

            
        }

        private void TX_HEX_CheckedChanged(object sender, EventArgs e)
        {
            if (TX_HEX.Checked)
            {
                StringBuilder tmp = new StringBuilder();
                foreach (String s in TX_Box.Lines)
                {
                    Char[] ints = s.ToCharArray();
                    foreach (Char chr in ints)
                    {

                        tmp.Append(Convert.ToString(chr,16).ToUpper()+ " ");
                    }
                }
                TX_Box.Text = tmp.ToString();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (String s in TX_Box.Lines)
                {
                    String[] splited = s.Split(' ');
                    foreach (String word in splited)
                    {
                        if(word != "")sb.Append((char)Convert.ToByte(word,16));
                    }
                }
                TX_Box.Text = sb.ToString();
            }
        }
        
        private void TX_Box_TextChanged(object sender, EventArgs e)
        {
            if (TX_HEX.Checked == true)
            {
                int ok = 0;
                for (int i = 0; i < TX_Box.Lines.Length; i++)
                {
                    String tmp = TX_Box.Lines[i].ToUpper();
                    tmp.CopyTo(0, TX_Box.Lines[i].ToCharArray(), 0, tmp.Length);
                       
                }
                foreach (String s in TX_Box.Lines)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (!((Convert.ToInt16(s[i]) >= 'A' && Convert.ToInt16(s[i]) <= 'F') || (Convert.ToInt16(s[i]) >= '0' && Convert.ToInt16(s[i]) <= '9') || (Convert.ToInt16(s[i]) == ' ')))
                        {
                            TX_HEX.Enabled = false;
                            send_button.Enabled = false;
                            ok = 1;
                        }
                    }
                }

                foreach (String s in TX_Box.Lines)
                {
                    String[] splited = s.Split(' ');
                    foreach (String word in splited)
                    {
                        if (word != "" && ok == 0)
                            if (Convert.ToInt32(word,16) > 256)
                            {
                                TX_HEX.Enabled = false;
                                send_button.Enabled = false;
                                ok = 1;
                            }
                    }
                }
                if (ok == 0) send_button.Enabled = TX_HEX.Enabled = true;
            }
        }

        private void RX_HEX_CheckedChanged(object sender, EventArgs e)
        {
            if (RX_HEX.Checked)
            {
                StringBuilder tmp = new StringBuilder();
                foreach (String s in RX_Box.Lines)
                {
                    Char[] ints = s.ToCharArray();
                    foreach (Char chr in ints)
                    {

                        tmp.Append(Convert.ToString(chr, 16).ToUpper() + " ");
                    }
                }
                RX_Box.Text = tmp.ToString();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (String s in RX_Box.Lines)
                {
                    String[] splited = s.Split(' ');
                    foreach (String word in splited)
                    {
                        if (word != "") sb.Append((char)Convert.ToByte(word, 16));
                    }
                }
                RX_Box.Text = sb.ToString();
            }
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            byte[] cchar = new byte[1];
            if (parent.port_isopen == true) 

            foreach (string str in TX_Box.Lines)
            {
                if (TX_HEX.Checked == true)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (String s in TX_Box.Lines)
                    {
                        String[] splited = s.Split(' ');

                        foreach (String word in splited)
                        {

                            if (word != "")
                            {
                                cchar[0] = Convert.ToByte(word, 16);
                                comport.Write(cchar, 0, 1);
                            }
                        }

                    }
                }
                else
                {
                    foreach (String s in TX_Box.Lines)
                    {
                        byte[] bytes = Encoding.Default.GetBytes(s);
                        comport.Write(bytes,0,bytes.Length);
                        
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RX_Box.Text = "";
        }
    }
}
