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
    public partial class main_form : Form
    {
        
        static  SerialPort _serialPort = new SerialPort();
        ConnectManager cm;
        List<int> points_red = new List<int>(4096);
        List<int> points_blue = new List<int>(4096);
        List<int> points_green = new List<int>(4096);
        
        Logger LOG;
        private Form2 charfrm;
        private List<byte> buffer = new List<byte>(4096);
        public bool port_isopen;
        public GlobalData gdata;
        private byte[] ReceiveBytes = new byte[4096];
        private delegate void COMProcessor_Invoker(string text, int ii);
        int pb_pic_height;
        int pb_pic_width;
        private PointF[] pts;
        static int  firstflag=1;
        int PICstart = 0; 
        private void Angle_scope_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black,2);
            PictureBox pb = (PictureBox)sender;
            pts = new PointF[pb_pic_width];
            double multi=0;
            int step = 0;
            int max=0;
            if (points_red.Count > 1) 
            if (points_red.Max() > max) max = points_red.Max();
            if (points_green.Count > 1)
            if (points_green.Max() > max) max = points_green.Max();
            if (points_blue.Count > 1)
            if (points_blue.Max() > max) max = points_blue.Max();

            if(max!=0)
                multi = ((double)pb_pic_height / max);
            p.Width = 1;

            if (points_red.Count > 1)
            {


                for (int i = 0; i < points_red.Count; i++)
                {
                    pts[i].Y = (float)((points_red[i] * multi));
                    pts[i].X = i + (pb_pic_width - points_red.Count);
                }
                for (int i = points_red.Count; i < pb_pic_width; i++)
                {
                    pts[i].Y = pts[i - 1].Y;
                    pts[i].X = pts[i - 1].X;
                }
                p.Color = Color.Red;
               
                if(checkBox_Gyro.Checked)
                    g.DrawLines(p, pts);
            }
            if (multi != 0)
                step = (int)(40 * multi);
            else
                step = 5;

            //draw_background_lines(g, pb_pic_width, pb_pic_height,step,PICstart);

            if (points_green.Count > 1)
            {
                for (int i = 0; i < points_green.Count; i++)
                {
                    pts[i].Y = (float)((points_green[i] * multi));
                    pts[i].X = i + (pb_pic_width - points_green.Count);
                }
                for (int i = points_green.Count; i < pb_pic_width; i++)
                {
                    pts[i].Y = pts[i - 1].Y;
                    pts[i].X = pts[i - 1].X;
                }
                p.Color = Color.Green;
                if(checkBox_angle.Checked)
                    g.DrawLines(p, pts);

            }

            if (points_blue.Count > 1)
            {
                for (int i = 0; i < points_blue.Count; i++)
                {
                    pts[i].Y = (float)((points_blue[i] * multi));
                    pts[i].X = i + (pb_pic_width - points_blue.Count);
                }
                for (int i = points_blue.Count; i < pb_pic_width; i++)
                {
                    pts[i].Y = pts[i - 1].Y;
                    pts[i].X = pts[i - 1].X;
                }
                p.Color = Color.Blue;
                if (checkBox_Accer.Checked)
                    g.DrawLines(p, pts);

            }


        }
        public void Add_Points_Red(int pts)
        {
            this.points_red.Add(pts);
            if(points_red.Count>pb_pic_width) this.points_red.RemoveAt(0);

        }
        public void Add_Points_Blue(int pts)
        {
            this.points_blue.Add(pts);
            if (points_blue.Count > pb_pic_width) this.points_blue.RemoveAt(0);
        }
        public void Add_Points_Green(int pts)
        {
            this.points_green.Add(pts);
            if (points_green.Count > pb_pic_width) this.points_green.RemoveAt(0);
        }
        private void draw_background_lines(Graphics g,int pic_width, int pic_height, int step,int start)
        {
            Pen p = new Pen(Color.Gray, 1);
            
            for (int i = 0; i < pic_height; i += step)
            {
                g.DrawLine(p, 0, i, pic_width, i);
            }
            for (int i = start; i < pic_width; i += step)
            {
                g.DrawLine(p,i, 0, i, pic_height);
            }
            //p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            //g.DrawLine(p, 0, pic_height / 2, pic_width, pic_height / 2);
        }
        private void getComNum()
        {
            string[] portList = System.IO.Ports.SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            for (int i = 0; i < portList.Length; ++i)
            {
                string name = portList[i];
                comboBox1.Items.Add(name);
            }
        }
        public main_form()
        {
            InitializeComponent();
            getComNum();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pb_pic_width = Angel_Scope.Width;
            pb_pic_height = Angel_Scope.Height;

            //for (int i = 0; i < pb_pic_width; i++)
            //{
            //    points_red.Add((int)(pb_pic_height / 2 + (int)(pb_pic_height * 0.45 * Math.Sin(((double)i / 50)))));
            //}
            //register for hot key.
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 20);
            this.KeyDown += main_form_KeyDown;
            
            Angel_Scope.BackColor = Color.White;
            Angel_Scope.Paint += new PaintEventHandler(Angle_scope_paint);
            Form2 frm2 = new Form2(this);
            this.charfrm = frm2;
            frm2.Show();
            frm2.comport = _serialPort;
            LOG = new Logger(this);
            LOG.Show();
            this.gdata = new GlobalData(GlobalData.CarType.Camera);
            cm = new ConnectManager(this,_serialPort,frm2,LOG,gdata);
            System.Timers.Timer t = new System.Timers.Timer((double)1);
            t.AutoReset = true;
           // t.Elapsed += setGlobalData;
            t.Enabled = true;
        }
        private delegate void gbinvoker(string text);
        private delegate void objectinvoker(System.Windows.Forms.Label lb, string text);
        void setlabel(Label lb, string text)
        {
            objectinvoker d;
            if (this.InvokeRequired)
            {
                d = new objectinvoker(setlabel);
                try
                {
                    this.Invoke(d, new object[] { lb, text });
                }
                catch { ;}
            }
            else
            {
                lb.Text = text;
            }
        }
        private delegate void TextBoxinvoker(System.Windows.Forms.TextBox tb, string text);
        void settextbox(TextBox tb, string text)
        {
            TextBoxinvoker d;
            if (this.InvokeRequired)
            {
                d = new TextBoxinvoker(settextbox);
                try
                {
                    this.BeginInvoke(d, new object[] { tb, text });
                }
                catch { ;}
            }
            else
            {
                tb.Text = text;
            }
        }
        private int cnt = 0;
        private delegate void TextBoxColorSeter(System.Windows.Forms.TextBox tb, Color color);
        void settextbox_color(TextBox tb, Color color)
        {
            TextBoxColorSeter d;
            if (this.InvokeRequired)
            {
                d = new TextBoxColorSeter(settextbox_color);
                try
                {
                    this.BeginInvoke(d, new object[] { tb, color });
                }
                catch { ;}
            }
            else
            {
                tb.BackColor = color;
            }
        }
        public void setGlobalData(object sender, System.Timers.ElapsedEventArgs e)
        {

            if (gdata.PARAM_SET == true)
            {
                settextbox(textBox_SPEED_P, gdata.Speed_P.ToString("0.000")); settextbox_color(textBox_SPEED_P, Color.LimeGreen);
                settextbox(textBox_SPEED_I, gdata.Speed_I.ToString("0.000")); settextbox_color(textBox_SPEED_I, Color.LimeGreen);
                settextbox(textBox_SPEED_D, gdata.Speed_D.ToString("0.000")); settextbox_color(textBox_SPEED_D, Color.LimeGreen);
                settextbox(textBox_ANGLE_P, gdata.angle_P.ToString("0.000")); settextbox_color(textBox_ANGLE_P, Color.LimeGreen);
                settextbox(textBox_ANGLE_I, gdata.angle_I.ToString("0.000")); settextbox_color(textBox_ANGLE_I, Color.LimeGreen);
                settextbox(textBox_ANGLE_D, gdata.angle_D.ToString("0.000")); settextbox_color(textBox_ANGLE_D, Color.LimeGreen);
                settextbox(textBox_DIR_P, gdata.DIR_P.ToString("0.000")); settextbox_color(textBox_DIR_P, Color.LimeGreen);
                settextbox(textBox_DIR_I, gdata.DIR_I.ToString("0.000")); settextbox_color(textBox_DIR_I, Color.LimeGreen);
                settextbox(textBox_DIR_D, gdata.DIR_D.ToString("0.000")); settextbox_color(textBox_DIR_D, Color.LimeGreen);
                gdata.PARAM_SET = false;
            }

            setlabel(label_Gyro, (gdata.angle_Gyro).ToString("0.000"));
            setlabel(label_Accer, (gdata.angle_Accer ).ToString("0.000"));
            setlabel(label_Angle_Value, gdata.Car_Angle.ToString("0.000"));

            if (checkBox_Gyro.Checked)Add_Points_Red((int)gdata.angle_Gyro );
            if (checkBox_Accer.Checked) Add_Points_Blue((int)gdata.angle_Accer );
            if (checkBox_angle.Checked) Add_Points_Green((int)gdata.Car_Angle );
            if (checkBox_Gyro.Checked || checkBox_Accer.Checked || checkBox_angle.Checked)
            {
                this.Angel_Scope.Invalidate();
                this.PICstart--;
            }
        }
        public void setGlobalData()
        {
            if (gdata.PARAM_SET == true)
            {
                settextbox(textBox_SPEED_P, gdata.Speed_P.ToString("0.000")); settextbox_color(textBox_SPEED_P, Color.LimeGreen);
                settextbox(textBox_SPEED_I, gdata.Speed_I.ToString("0.000")); settextbox_color(textBox_SPEED_I, Color.LimeGreen);
                settextbox(textBox_SPEED_D, gdata.Speed_D.ToString("0.000")); settextbox_color(textBox_SPEED_D, Color.LimeGreen);
                settextbox(textBox_ANGLE_P, gdata.angle_P.ToString("0.000")); settextbox_color(textBox_ANGLE_P, Color.LimeGreen);
                settextbox(textBox_ANGLE_I, gdata.angle_I.ToString("0.000")); settextbox_color(textBox_ANGLE_I, Color.LimeGreen);
                settextbox(textBox_ANGLE_D, gdata.angle_D.ToString("0.000")); settextbox_color(textBox_ANGLE_D, Color.LimeGreen);
                settextbox(textBox_DIR_P, gdata.DIR_P.ToString("0.000")); settextbox_color(textBox_DIR_P, Color.LimeGreen);
                settextbox(textBox_DIR_I, gdata.DIR_I.ToString("0.000")); settextbox_color(textBox_DIR_I, Color.LimeGreen);
                settextbox(textBox_DIR_D, gdata.DIR_D.ToString("0.000")); settextbox_color(textBox_DIR_D, Color.LimeGreen);
                gdata.PARAM_SET = false;
            }

            setlabel(label_Gyro, (gdata.angle_Gyro).ToString("0.000"));
            setlabel(label_Accer, (gdata.angle_Accer).ToString("0.000"));
            setlabel(label_Angle_Value, gdata.Car_Angle.ToString("0.000"));

            if (checkBox_Gyro.Checked) Add_Points_Red((int)gdata.angle_Gyro);
            if (checkBox_Accer.Checked) Add_Points_Blue((int)gdata.angle_Accer);
            if (checkBox_angle.Checked) Add_Points_Green((int)gdata.Car_Angle);
            if (checkBox_Gyro.Checked || checkBox_Accer.Checked || checkBox_angle.Checked)
            {
                this.Angel_Scope.Invalidate();
                this.PICstart--;
            }
        }
        private void main_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Alt)
                Button_OpenCOM_Click(sender, null);
            e.Handled = true;
        }
        private void checkBox_DTR_CheckedChanged(object sender, EventArgs e)
        {
            _serialPort.DtrEnable = checkBox_DTR.Checked;
        }
        //Com Bytes defines:
        public void COMProcessor_Invoke(string text, int ii)
        {
            COMProcessor_Invoker d;
            if(port_isopen == true)
            if (this.InvokeRequired)
            {
                d = new COMProcessor_Invoker(COMProcessor_Invoke);
                this.Invoke(d, new object[] { text, ii });
            }
            else
            {
                if (text !="" )this.status.Text = text;
                this.status.Refresh();
                this.Cnt_ByteRecv.Text = (Convert.ToInt32(this.Cnt_ByteRecv.Text) + ii).ToString();
            }
            
        }
        private int listening = 0;
        private int closing = 0;
        private void COMDataHandler(object sender, EventArgs e)
        {
            if (port_isopen == false) return;
            try
            {
                listening = 1;
                SerialPort sp = (SerialPort)sender;
                int counter = 0;
                counter = sp.BytesToRead;
                byte[] buf = new byte[counter];
                sp.Read(buf, 0, counter);
                int err = 0;
                setlabel(this.status, "Communicationing");
                foreach (byte n in buf)
                {
                    buffer.Add(n);
                }
                //String strr = System.Text.Encoding.Default.GetString(buf);
                //charfrm.Set_RXBox_Text(strr);
                while (buffer.Count >= 4) 
                {
                    //2.1 Find Header
                    if (buffer[0] == 0x58 && buffer[1] == 0x5A) //传输数据有帧头，用于判断
                    {
                        int len = buffer[2];
                        if (buffer.Count < len) //数据区尚未接收完整
                        {
                            break;
                        }
                        else
                        {
                            //Got full data, Copy to ReceiveBytes to verify.
                            buffer.CopyTo(0, ReceiveBytes, 0, len);
                            buffer.RemoveRange(0, len);
                            //if(ReceiveBytes[len -3 ] == this.FCS(ReceiveBytes,len)) //Verify FCS Verify Confirmed.
                            {
                                cm.GetSerialData(ReceiveBytes);
        
                            }
                        }
                    }
                    else //帧头不正确时，记得清除
                    {
                        buffer.RemoveAt(0);
                        err = 1;
                        if (buffer[0] == 0x58) err = 0;
                        if (buf[0] == 'X') err = 0;
                    }
                }
                if (err == 1)
                {
                   String str = System.Text.Encoding.Default.GetString(buf);
                   charfrm.Set_RXBox_Text(str);
                    //charfrm.Set_RXBox_Text(buf, counter);
                }
            }
            finally 
            {
                listening = 0;
            }
        }
        private Byte FCS(Byte[] buffer,int lenth)
        {
            byte ret = 0;
            int cnt=0;
            while ((lenth--)!=0)
            {
                ret ^= buffer[cnt++];
            }
            return 0x00;

        }
        private void checkBox_angle_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            getComNum();
        }
        private void Button_OpenCOM_Click(object sender, EventArgs e)
        {
            if (Button_OpenCOM.Text == "开启(Alt-C)")
            {
                try
                {

                    _serialPort.PortName = comboBox1.Text;
                    _serialPort.BaudRate = int.Parse(comboBox_BaudRate.Text);
                    _serialPort.DataBits = 8;
                    _serialPort.StopBits = StopBits.One;
                    _serialPort.DtrEnable = checkBox_DTR.Checked;
                    _serialPort.Open();
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(COMDataHandler);
                    if (buffer.Count > 0) buffer.RemoveRange(0, buffer.Count - 1);
                }
                catch (Exception) { MessageBox.Show("COM Port Cannot open!"); }
                if (_serialPort.IsOpen)
                {
                    port_isopen = true;
                    status.Text = comboBox1.Text + " Opened Successful!";
                    Button_OpenCOM.Text = "关闭(Alt-C)";
                    charfrm.send_button.Enabled = true;
                    LOG.LoggerAppend(_serialPort.PortName + " Opened Successful!" + "@" + _serialPort.BaudRate.ToString() + "Bps");
                    cm.tryToConnect();
                }
            }
            else
            {
                port_isopen = false;
                while (listening == 1) Application.DoEvents();
                _serialPort.Close();
                if (!_serialPort.IsOpen)
                    Button_OpenCOM.Text = "开启(Alt-C)";
                status.Text = comboBox1.Text + " Port Closed!";
                charfrm.send_button.Enabled = false;
                LOG.LoggerAppend(_serialPort.PortName + " " + "Closed!");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (charfrm.Visible == true) 
                    charfrm.Hide();
                else
                    charfrm.Show();
            }
        }
        private void button_TrytoConnect_Click(object sender, EventArgs e)
        {
            cm.tryToConnect();
        }

        private void button_ParameterSet_Click(object sender, EventArgs e)
        {
            if (gdata.PARAM_CHANGED == true)
            
            {
                if (Convert.ToDouble(textBox_SPEED_P.Text) != gdata.Speed_P) 
                    cm.SetParam(cm.STAT_SPEED_P,Convert.ToDouble(textBox_SPEED_P.Text));
                if (Convert.ToDouble(textBox_SPEED_I.Text) != gdata.Speed_I)
                    cm.SetParam(cm.STAT_SPEED_I, Convert.ToDouble(textBox_SPEED_I.Text));
                if (Convert.ToDouble(textBox_SPEED_D.Text) != gdata.Speed_D)
                    cm.SetParam(cm.STAT_SPEED_D, Convert.ToDouble(textBox_SPEED_D.Text));
                
                if (Convert.ToDouble(textBox_DIR_P.Text) != gdata.DIR_P)
                    cm.SetParam(cm.STAT_DIR_P, Convert.ToDouble(textBox_DIR_P.Text));
                if (Convert.ToDouble(textBox_DIR_I.Text) != gdata.DIR_I)
                    cm.SetParam(cm.STAT_DIR_I, Convert.ToDouble(textBox_DIR_I.Text));
                if (Convert.ToDouble(textBox_DIR_D.Text) != gdata.DIR_D)
                    cm.SetParam(cm.STAT_DIR_D, Convert.ToDouble(textBox_DIR_D.Text));

                if (Convert.ToDouble(textBox_ANGLE_P.Text) != gdata.angle_P)
                    cm.SetParam(cm.STAT_ANGLE_P, Convert.ToDouble(textBox_ANGLE_P.Text));
                if (Convert.ToDouble(textBox_ANGLE_I.Text) != gdata.angle_I)
                    cm.SetParam(cm.STAT_ANGLE_I, Convert.ToDouble(textBox_ANGLE_I.Text));
                if (Convert.ToDouble(textBox_ANGLE_D.Text) != gdata.angle_D)
                    cm.SetParam(cm.STAT_ANGLE_D, Convert.ToDouble(textBox_ANGLE_D.Text));
                gdata.PARAM_CHANGED = false;
                cm.tryToConnect();
            }
        }

        private void textBox_SPEED_P_TextChanged(object sender, EventArgs e)
        {
            gdata.PARAM_CHANGED = true;
            ((TextBox)sender).BackColor = Color.MistyRose;
        }

        private void textBox_SPEED_I_TextChanged(object sender, EventArgs e)
        {
            gdata.PARAM_CHANGED = true;
            ((TextBox)sender).BackColor = Color.MistyRose;
        }

        private void textBox_SPEED_D_TextChanged(object sender, EventArgs e)
        {
            gdata.PARAM_CHANGED = true;
            ((TextBox)sender).BackColor = Color.MistyRose;
        }

        private void textBox_DIR_P_TextChanged(object sender, EventArgs e)
        {
            gdata.PARAM_CHANGED = true;
            ((TextBox)sender).BackColor = Color.MistyRose;
        }

        private void textBox_DIR_I_TextChanged(object sender, EventArgs e)
        {
            gdata.PARAM_CHANGED = true;
            ((TextBox)sender).BackColor = Color.MistyRose;
        }

        private void textBox_DIR_D_TextChanged(object sender, EventArgs e)
        {
            gdata.PARAM_CHANGED = true;
            ((TextBox)sender).BackColor = Color.MistyRose;
        }

        private void textBox_ANGLE_P_TextChanged(object sender, EventArgs e)
        {
            gdata.PARAM_CHANGED = true;
            ((TextBox)sender).BackColor = Color.MistyRose;
        }

        private void textBox_ANGLE_I_TextChanged(object sender, EventArgs e)
        {
            gdata.PARAM_CHANGED = true;
            ((TextBox)sender).BackColor = Color.MistyRose;
        }

        private void textBox_ANGLE_D_TextChanged(object sender, EventArgs e)
        {
            gdata.PARAM_CHANGED = true;
            ((TextBox)sender).BackColor = Color.MistyRose;
        }

        private void button_OpenImage_Click(object sender, EventArgs e)
        {
            cm.StartCam();
        }

        private void button_CloseImage_Click(object sender, EventArgs e)
        {
            cm.StopCam();
        }
    }
}
public class GlobalData
{
    public double Car_Speed=0;
    public double Car_Angle = 0;
    public double angle_P = 0;
    public double angle_I = 0;
    public double angle_D = 0;
    public double Speed_P = 0;
    public double Speed_I = 0;
    public double Speed_D = 0;
    public double DIR_P = 0;
    public double DIR_I = 0;
    public double DIR_D = 0;
    public double angle_Gyro = 0;
    public double angle_Accer = 0;
    public bool PARAM_SET = false;
    public bool PARAM_CHANGED = false;
    public byte[,] camera_image;
    public byte[] ccd_image;
    public enum CarType {PureData, Camera, CCD }
    public GlobalData(CarType type)
    {
        if (type == GlobalData.CarType.Camera)
        {
            camera_image = new byte[320,240];
            
        }
        else if (type == CarType.CCD)
        {
            ccd_image = new byte[128];
        }
        else if (type == CarType.PureData)
        {

        }
    }
}
public class ConnectManager
{
    public byte USART_SOF = 0x00;
    public byte USART_SOF2 = 0x01;
    public byte USART_LEN = 0x02;
    public byte USART_DAT = 0x03;
    public byte USART_OPT = 0x00;
    public byte CONN_REQ = 0x00;
    public byte TARGET_RESET_REQ = 0x01;
    public byte PARAMETERS_SET_REQ = 0x02;
    public byte REP_START_REQ = 0x03;
    public byte REP_STOP_REQ = 0x04;
    public byte REP_CAM_START = 0x05;
    public byte REP_CAM_STOP = 0x06;
    public byte STAT_REQ = 0x07;
    public byte ACK_CAM = 0x10;
    // Communication protocol :(Down->Up) DATA : USART_OPT;
    public byte ACK_CONN = 0x00;
    public byte ACK_TARGET_RESET = 0x01;
    public byte ACK_PARAMETERS_SET = 0x02;
    public byte ACK_REP_START = 0x03;
    public byte ACK_REP_STOP = 0x04;
    public byte ACK_REP_CAM_START = 0x05;
    public byte ACK_REP_CAM_STOP = 0x06;
    public byte TRANS_STAT = 0x07;
    public byte TRANS_CAM = 0x08;
    //Communication Protocol : (Down->Up) WHEN USART_OPT == TRANS_STAT
    public byte CAR_TYPE = 0x01;
    public byte STAT_SPEED_P = 0x02;
    public byte STAT_SPEED_I = 0x03;
    public byte STAT_SPEED_D = 0x04;
    public byte STAT_DIR_P = 0x05;
    public byte STAT_DIR_I = 0x06;
    public byte STAT_DIR_D = 0x07;
    public byte STAT_ANGLE_P = 0x08;
    public byte STAT_ANGLE_I = 0x09;
    public byte STAT_ANGLE_D = 0x0a;
    public byte STAT_VALUE_SPEED = 0x0b;
    public byte STAT_VALUE_ANGLE = 0x0c;
    public byte STAT_VALUE_DIREC = 0x0d;
    public byte STAT_LMOTOR_VALUE = 0x0e;
    public byte STAT_RMOTOR_VALUE = 0x0f;
    public byte STAT_VALUE_GYRO = 0x11;
    public byte STAT_VALUE_ACCER = 0x13;
    public Boolean isConnected = false;
    System.Timers.Timer ConnecterTimer;
    SerialPort sp;
    SmartCarCOMServer.Form2 Charfrm;
    SmartCarCOMServer.Logger LOG;
    SmartCarCOMServer.main_form frmm;
    GlobalData gd;
    public ConnectManager(SmartCarCOMServer.main_form ff,SerialPort sp, SmartCarCOMServer.Form2 frm2, SmartCarCOMServer.Logger LOG, GlobalData gd)
    {
        this.frmm = ff;
        this.sp = sp;
        this.Charfrm = frm2;
        this.LOG = LOG;
        this.gd = gd;
    }
    public void tryToConnect()
    {
        byte[] buf = new byte[128];
        buf[USART_SOF] = 0x58;
        buf[USART_SOF2] = 0x5A;
        buf[USART_DAT + USART_OPT] = CONN_REQ;
        int len = 4;
        buf[len++] = 0xFE;
        buf[len++] = 0x01;
        buf[USART_LEN] = (byte)(len++);
        sp.Write(buf, 0, len);
        LOG.LoggerAppend("Try to Connect...");
    }
    public void StartCam()
    {
        byte[] buf = new byte[128];
        buf[USART_SOF] = 0x58;
        buf[USART_SOF2] = 0x5A;
        buf[USART_DAT + USART_OPT] = REP_START_REQ;
        int len = 4;
        buf[len++] = 0xFE;
        buf[len++] = 0x01;
        buf[USART_LEN] = (byte)(len++);
        sp.Write(buf, 0, len);
        LOG.LoggerAppend("Starting Recing Camera");
    }
    public void StopCam()
    {
        byte[] buf = new byte[128];
        buf[USART_SOF] = 0x58;
        buf[USART_SOF2] = 0x5A;
        buf[USART_DAT + USART_OPT] = REP_STOP_REQ;
        int len = 4;
        buf[len++] = 0xFE;
        buf[len++] = 0x01;
        buf[USART_LEN] = (byte)(len++);
        sp.Write(buf, 0, len);
        LOG.LoggerAppend("Stoping Recing Camera");
    }
    public void SetParam(byte PARAM, double trans)
    {
        trans *= 1000;
        byte[] buf = new byte[128];

        buf[USART_SOF] = 0x58;
        buf[USART_SOF2] = 0x5A;
        buf[USART_DAT] = PARAMETERS_SET_REQ;
        int len = 5;
        buf[USART_DAT + 1] = PARAM;
        buf[len++] = (byte)'/';
        int k = (int)(trans);
        int bits = 0;
        while (k > 0)
        {
            k /= 10;
            bits++;
        }
        k = (int)trans;
        
        while (bits != 0)
        {
            buf[len++] = (byte)((k / (Math.Pow(10, (bits - 1)))) + 48);
            k = (int)(k % Math.Pow(10, (bits - 1)));
            bits--;
        }
        buf[len++] = (byte)'/';
        buf[len++] = 0xFE;
        buf[len++] = 0x01;
        buf[USART_LEN] = (byte)(len);
        sp.Write(buf, 0, len);
    }
    public void GetSerialData(byte[] dat)
    {//TODO
        if (dat[USART_DAT + USART_OPT] == ACK_CONN) LOG.LoggerAppend("ACK_CONN Message Got.");
        if (dat[USART_DAT + USART_OPT] == ACK_TARGET_RESET) LOG.LoggerAppend("ACK_TARGET_RESET Message Got.");
        if (dat[USART_DAT + USART_OPT] == ACK_PARAMETERS_SET) LOG.LoggerAppend("ACK_PARAMETERS_SET Message Got.");
        if (dat[USART_DAT + USART_OPT] == ACK_REP_START) LOG.LoggerAppend("ACK_REP_START Message Got.");
        if (dat[USART_DAT + USART_OPT] == ACK_REP_STOP) LOG.LoggerAppend("ACK_REP_STOP Message Got.");
        if (dat[USART_DAT + USART_OPT] == ACK_REP_CAM_START) LOG.LoggerAppend("ACK_REP_CAM_START Message Got.");
        if (dat[USART_DAT + USART_OPT] == ACK_REP_CAM_STOP) LOG.LoggerAppend("ACK_REP_CAM_STOP Message Got.");
        if (dat[USART_DAT + USART_OPT] == TRANS_STAT)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = USART_DAT + 2; i < dat.Length - 4; i++)
            {
                if (dat[i] == '/') continue;
                if (dat[i] >= '0' && dat[i] <= '9')
                    sb.Append((char)dat[i]);
                if (dat[i + 1] == '/') break;
            }
            double value = new double();
            try
            {
                value = (double)Convert.ToInt64(sb.ToString()) / 1000;
            }
            catch { LOG.LoggerAppend("String err!"); value = 0; }
            if (dat[USART_DAT + 1] == STAT_SPEED_P) gd.Speed_P = value;
            if (dat[USART_DAT + 1] == STAT_VALUE_GYRO) { gd.angle_Gyro = value; }
            if (dat[USART_DAT + 1] == STAT_VALUE_ACCER) gd.angle_Accer = value;
            if (dat[USART_DAT + 1] == STAT_VALUE_ANGLE) { gd.Car_Angle = value; }

            if (dat[USART_DAT + 1] == STAT_SPEED_P)
            {
                gd.Speed_P = value; gd.PARAM_SET = true; LOG.LoggerAppend("Got Param STAT_SPEED_P" + value.ToString());
            }
                if (dat[USART_DAT + 1] == STAT_SPEED_I) { gd.Speed_I = value; gd.PARAM_SET = true; LOG.LoggerAppend("Got Param STAT_SPEED_I : " + value.ToString("0.000"));}
                if (dat[USART_DAT + 1] == STAT_SPEED_D) { gd.Speed_D = value; gd.PARAM_SET = true; LOG.LoggerAppend("Got Param STAT_SPEED_D : " + value.ToString("0.000")); }
                if (dat[USART_DAT + 1] == STAT_DIR_P) { gd.DIR_P = value; gd.PARAM_SET = true; LOG.LoggerAppend("Got Param STAT_DIR_P : " + value.ToString("0.000")); }
                if (dat[USART_DAT + 1] == STAT_DIR_I) { gd.DIR_I = value; gd.PARAM_SET = true; LOG.LoggerAppend("Got Param STAT_DIR_I : " + value.ToString("0.000")); }
                if (dat[USART_DAT + 1] == STAT_DIR_D) { gd.DIR_D = value; gd.PARAM_SET = true; LOG.LoggerAppend("Got Param STAT_DIR_D : " + value.ToString("0.000")); }
                if (dat[USART_DAT + 1] == STAT_ANGLE_P) { gd.angle_P = value; gd.PARAM_SET = true; LOG.LoggerAppend("Got Param STAT_ANGLE_P : " + value.ToString("0.000")); }
                if (dat[USART_DAT + 1] == STAT_ANGLE_I) { gd.angle_I = value; gd.PARAM_SET = true; LOG.LoggerAppend("Got Param STAT_ANGLE_I : " + value.ToString("0.000")); }
                if (dat[USART_DAT + 1] == STAT_ANGLE_D) { gd.angle_D = value; gd.PARAM_SET = true; LOG.LoggerAppend("Got Param STAT_ANGLE_D : " + value.ToString("0.000")); }

            }
            if (dat[USART_DAT + USART_OPT] == TRANS_CAM) LOG.LoggerAppend("TRANS_CAM Message Got.");
            if (dat[USART_DAT + USART_OPT] == ACK_REP_CAM_START) LOG.LoggerAppend("ACK_REP_CAM_START Message Got.");
            this.frmm.setGlobalData();
    }
        

    }
