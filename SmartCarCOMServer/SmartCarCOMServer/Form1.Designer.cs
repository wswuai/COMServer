namespace SmartCarCOMServer
{
    partial class main_form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_OpenCOM = new System.Windows.Forms.Button();
            this.checkBox_DTR = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Angle_Value = new System.Windows.Forms.Label();
            this.checkBox_Accer = new System.Windows.Forms.CheckBox();
            this.checkBox_Gyro = new System.Windows.Forms.CheckBox();
            this.label_Accer = new System.Windows.Forms.Label();
            this.label_Gyro = new System.Windows.Forms.Label();
            this.label_Motor_Right = new System.Windows.Forms.Label();
            this.label_Motor_Left = new System.Windows.Forms.Label();
            this.label_Speed_Right = new System.Windows.Forms.Label();
            this.label_Speed_Left = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_motor = new System.Windows.Forms.CheckBox();
            this.checkBox_direction = new System.Windows.Forms.CheckBox();
            this.checkBox_angle = new System.Windows.Forms.CheckBox();
            this.checkBox_speed = new System.Windows.Forms.CheckBox();
            this.Frm_Angle = new System.Windows.Forms.GroupBox();
            this.Angel_Scope = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cnt_ByteRecv = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_CloseMotor = new System.Windows.Forms.Button();
            this.button_CloseImage = new System.Windows.Forms.Button();
            this.button_OpenImage = new System.Windows.Forms.Button();
            this.button_ParameterSet = new System.Windows.Forms.Button();
            this.button_TrytoConnect = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_ANGLE_D = new System.Windows.Forms.TextBox();
            this.textBox_ANGLE_I = new System.Windows.Forms.TextBox();
            this.textBox_ANGLE_P = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_DIR_D = new System.Windows.Forms.TextBox();
            this.textBox_DIR_I = new System.Windows.Forms.TextBox();
            this.textBox_DIR_P = new System.Windows.Forms.TextBox();
            this.textBox_SPEED_D = new System.Windows.Forms.TextBox();
            this.textBox_SPEED_I = new System.Windows.Forms.TextBox();
            this.textBox_SPEED_P = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Frm_Angle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Angel_Scope)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口号";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "COM3";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "刷新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Powered by XiaoGo , All Rights reserved by 202 studio.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Button_OpenCOM);
            this.groupBox1.Controls.Add(this.checkBox_DTR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_BaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "字符窗";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_OpenCOM
            // 
            this.Button_OpenCOM.Location = new System.Drawing.Point(119, 102);
            this.Button_OpenCOM.Name = "Button_OpenCOM";
            this.Button_OpenCOM.Size = new System.Drawing.Size(75, 42);
            this.Button_OpenCOM.TabIndex = 8;
            this.Button_OpenCOM.Text = "开启(Alt-C)";
            this.Button_OpenCOM.UseVisualStyleBackColor = true;
            this.Button_OpenCOM.Click += new System.EventHandler(this.Button_OpenCOM_Click);
            // 
            // checkBox_DTR
            // 
            this.checkBox_DTR.AutoSize = true;
            this.checkBox_DTR.Location = new System.Drawing.Point(8, 75);
            this.checkBox_DTR.Name = "checkBox_DTR";
            this.checkBox_DTR.Size = new System.Drawing.Size(42, 16);
            this.checkBox_DTR.TabIndex = 7;
            this.checkBox_DTR.Text = "DTR";
            this.checkBox_DTR.UseVisualStyleBackColor = true;
            this.checkBox_DTR.CheckedChanged += new System.EventHandler(this.checkBox_DTR_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "波特率";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(53, 45);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(65, 20);
            this.comboBox_BaudRate.TabIndex = 5;
            this.comboBox_BaudRate.Text = "115200";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "当前状态：";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(80, 531);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(53, 12);
            this.status.TabIndex = 8;
            this.status.Text = "串口关闭";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Angle_Value);
            this.groupBox2.Controls.Add(this.checkBox_Accer);
            this.groupBox2.Controls.Add(this.checkBox_Gyro);
            this.groupBox2.Controls.Add(this.label_Accer);
            this.groupBox2.Controls.Add(this.label_Gyro);
            this.groupBox2.Controls.Add(this.label_Motor_Right);
            this.groupBox2.Controls.Add(this.label_Motor_Left);
            this.groupBox2.Controls.Add(this.label_Speed_Right);
            this.groupBox2.Controls.Add(this.label_Speed_Left);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBox_motor);
            this.groupBox2.Controls.Add(this.checkBox_direction);
            this.groupBox2.Controls.Add(this.checkBox_angle);
            this.groupBox2.Controls.Add(this.checkBox_speed);
            this.groupBox2.Location = new System.Drawing.Point(221, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 150);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前状态";
            // 
            // label_Angle_Value
            // 
            this.label_Angle_Value.AutoSize = true;
            this.label_Angle_Value.Location = new System.Drawing.Point(311, 22);
            this.label_Angle_Value.Name = "label_Angle_Value";
            this.label_Angle_Value.Size = new System.Drawing.Size(35, 12);
            this.label_Angle_Value.TabIndex = 25;
            this.label_Angle_Value.Text = "0.000";
            // 
            // checkBox_Accer
            // 
            this.checkBox_Accer.AutoSize = true;
            this.checkBox_Accer.Location = new System.Drawing.Point(222, 63);
            this.checkBox_Accer.Name = "checkBox_Accer";
            this.checkBox_Accer.Size = new System.Drawing.Size(60, 16);
            this.checkBox_Accer.TabIndex = 24;
            this.checkBox_Accer.Text = "偏航：";
            this.checkBox_Accer.UseVisualStyleBackColor = true;
            // 
            // checkBox_Gyro
            // 
            this.checkBox_Gyro.AutoSize = true;
            this.checkBox_Gyro.Location = new System.Drawing.Point(222, 42);
            this.checkBox_Gyro.Name = "checkBox_Gyro";
            this.checkBox_Gyro.Size = new System.Drawing.Size(60, 16);
            this.checkBox_Gyro.TabIndex = 23;
            this.checkBox_Gyro.Text = "俯仰：";
            this.checkBox_Gyro.UseVisualStyleBackColor = true;
            // 
            // label_Accer
            // 
            this.label_Accer.AutoSize = true;
            this.label_Accer.Location = new System.Drawing.Point(311, 63);
            this.label_Accer.Name = "label_Accer";
            this.label_Accer.Size = new System.Drawing.Size(35, 12);
            this.label_Accer.TabIndex = 22;
            this.label_Accer.Text = "0.000";
            // 
            // label_Gyro
            // 
            this.label_Gyro.AutoSize = true;
            this.label_Gyro.Location = new System.Drawing.Point(311, 42);
            this.label_Gyro.Name = "label_Gyro";
            this.label_Gyro.Size = new System.Drawing.Size(35, 12);
            this.label_Gyro.TabIndex = 21;
            this.label_Gyro.Text = "0.000";
            // 
            // label_Motor_Right
            // 
            this.label_Motor_Right.AutoSize = true;
            this.label_Motor_Right.Location = new System.Drawing.Point(57, 120);
            this.label_Motor_Right.Name = "label_Motor_Right";
            this.label_Motor_Right.Size = new System.Drawing.Size(35, 12);
            this.label_Motor_Right.TabIndex = 18;
            this.label_Motor_Right.Text = "0.000";
            // 
            // label_Motor_Left
            // 
            this.label_Motor_Left.AutoSize = true;
            this.label_Motor_Left.Location = new System.Drawing.Point(57, 103);
            this.label_Motor_Left.Name = "label_Motor_Left";
            this.label_Motor_Left.Size = new System.Drawing.Size(35, 12);
            this.label_Motor_Left.TabIndex = 17;
            this.label_Motor_Left.Text = "0.000";
            // 
            // label_Speed_Right
            // 
            this.label_Speed_Right.AutoSize = true;
            this.label_Speed_Right.Location = new System.Drawing.Point(57, 60);
            this.label_Speed_Right.Name = "label_Speed_Right";
            this.label_Speed_Right.Size = new System.Drawing.Size(35, 12);
            this.label_Speed_Right.TabIndex = 16;
            this.label_Speed_Right.Text = "0.000";
            // 
            // label_Speed_Left
            // 
            this.label_Speed_Left.AutoSize = true;
            this.label_Speed_Left.Location = new System.Drawing.Point(57, 41);
            this.label_Speed_Left.Name = "label_Speed_Left";
            this.label_Speed_Left.Size = new System.Drawing.Size(35, 12);
            this.label_Speed_Left.TabIndex = 15;
            this.label_Speed_Left.Text = "0.000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "右：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "左：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "右：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "左：";
            // 
            // checkBox_motor
            // 
            this.checkBox_motor.AutoSize = true;
            this.checkBox_motor.Location = new System.Drawing.Point(7, 84);
            this.checkBox_motor.Name = "checkBox_motor";
            this.checkBox_motor.Size = new System.Drawing.Size(72, 16);
            this.checkBox_motor.TabIndex = 10;
            this.checkBox_motor.Text = "后电机：";
            this.checkBox_motor.UseVisualStyleBackColor = true;
            // 
            // checkBox_direction
            // 
            this.checkBox_direction.AutoSize = true;
            this.checkBox_direction.Location = new System.Drawing.Point(222, 84);
            this.checkBox_direction.Name = "checkBox_direction";
            this.checkBox_direction.Size = new System.Drawing.Size(60, 16);
            this.checkBox_direction.TabIndex = 2;
            this.checkBox_direction.Text = "转向：";
            this.checkBox_direction.UseVisualStyleBackColor = true;
            // 
            // checkBox_angle
            // 
            this.checkBox_angle.AutoSize = true;
            this.checkBox_angle.Location = new System.Drawing.Point(222, 21);
            this.checkBox_angle.Name = "checkBox_angle";
            this.checkBox_angle.Size = new System.Drawing.Size(60, 16);
            this.checkBox_angle.TabIndex = 1;
            this.checkBox_angle.Text = "翻滚：";
            this.checkBox_angle.UseVisualStyleBackColor = true;
            this.checkBox_angle.CheckedChanged += new System.EventHandler(this.checkBox_angle_CheckedChanged);
            // 
            // checkBox_speed
            // 
            this.checkBox_speed.AutoSize = true;
            this.checkBox_speed.Location = new System.Drawing.Point(7, 21);
            this.checkBox_speed.Name = "checkBox_speed";
            this.checkBox_speed.Size = new System.Drawing.Size(72, 16);
            this.checkBox_speed.TabIndex = 0;
            this.checkBox_speed.Text = "前电机：";
            this.checkBox_speed.UseVisualStyleBackColor = true;
            // 
            // Frm_Angle
            // 
            this.Frm_Angle.Controls.Add(this.Angel_Scope);
            this.Frm_Angle.Location = new System.Drawing.Point(13, 165);
            this.Frm_Angle.Name = "Frm_Angle";
            this.Frm_Angle.Size = new System.Drawing.Size(650, 361);
            this.Frm_Angle.TabIndex = 10;
            this.Frm_Angle.TabStop = false;
            this.Frm_Angle.Text = "图像显示";
            // 
            // Angel_Scope
            // 
            this.Angel_Scope.Location = new System.Drawing.Point(20, 21);
            this.Angel_Scope.Name = "Angel_Scope";
            this.Angel_Scope.Size = new System.Drawing.Size(611, 334);
            this.Angel_Scope.TabIndex = 0;
            this.Angel_Scope.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "接收字节：";
            // 
            // Cnt_ByteRecv
            // 
            this.Cnt_ByteRecv.AutoSize = true;
            this.Cnt_ByteRecv.Location = new System.Drawing.Point(313, 532);
            this.Cnt_ByteRecv.Name = "Cnt_ByteRecv";
            this.Cnt_ByteRecv.Size = new System.Drawing.Size(11, 12);
            this.Cnt_ByteRecv.TabIndex = 12;
            this.Cnt_ByteRecv.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Reset);
            this.groupBox3.Controls.Add(this.button_CloseMotor);
            this.groupBox3.Controls.Add(this.button_CloseImage);
            this.groupBox3.Controls.Add(this.button_OpenImage);
            this.groupBox3.Controls.Add(this.button_ParameterSet);
            this.groupBox3.Controls.Add(this.button_TrytoConnect);
            this.groupBox3.Location = new System.Drawing.Point(670, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 151);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "控制";
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(237, 86);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 39);
            this.button_Reset.TabIndex = 5;
            this.button_Reset.Text = "重新启动";
            this.button_Reset.UseVisualStyleBackColor = true;
            // 
            // button_CloseMotor
            // 
            this.button_CloseMotor.Location = new System.Drawing.Point(237, 21);
            this.button_CloseMotor.Name = "button_CloseMotor";
            this.button_CloseMotor.Size = new System.Drawing.Size(75, 39);
            this.button_CloseMotor.TabIndex = 4;
            this.button_CloseMotor.Text = "关闭电机";
            this.button_CloseMotor.UseVisualStyleBackColor = true;
            // 
            // button_CloseImage
            // 
            this.button_CloseImage.Location = new System.Drawing.Point(135, 86);
            this.button_CloseImage.Name = "button_CloseImage";
            this.button_CloseImage.Size = new System.Drawing.Size(83, 39);
            this.button_CloseImage.TabIndex = 3;
            this.button_CloseImage.Text = "关闭图像";
            this.button_CloseImage.UseVisualStyleBackColor = true;
            this.button_CloseImage.Click += new System.EventHandler(this.button_CloseImage_Click);
            // 
            // button_OpenImage
            // 
            this.button_OpenImage.Location = new System.Drawing.Point(135, 21);
            this.button_OpenImage.Name = "button_OpenImage";
            this.button_OpenImage.Size = new System.Drawing.Size(83, 39);
            this.button_OpenImage.TabIndex = 2;
            this.button_OpenImage.Text = "开启图像";
            this.button_OpenImage.UseVisualStyleBackColor = true;
            this.button_OpenImage.Click += new System.EventHandler(this.button_OpenImage_Click);
            // 
            // button_ParameterSet
            // 
            this.button_ParameterSet.Location = new System.Drawing.Point(21, 85);
            this.button_ParameterSet.Name = "button_ParameterSet";
            this.button_ParameterSet.Size = new System.Drawing.Size(82, 39);
            this.button_ParameterSet.TabIndex = 1;
            this.button_ParameterSet.Text = "参数设定";
            this.button_ParameterSet.UseVisualStyleBackColor = true;
            this.button_ParameterSet.Click += new System.EventHandler(this.button_ParameterSet_Click);
            // 
            // button_TrytoConnect
            // 
            this.button_TrytoConnect.Location = new System.Drawing.Point(21, 21);
            this.button_TrytoConnect.Name = "button_TrytoConnect";
            this.button_TrytoConnect.Size = new System.Drawing.Size(81, 39);
            this.button_TrytoConnect.TabIndex = 0;
            this.button_TrytoConnect.Text = "连接";
            this.button_TrytoConnect.UseVisualStyleBackColor = true;
            this.button_TrytoConnect.Click += new System.EventHandler(this.button_TrytoConnect_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.textBox_ANGLE_D);
            this.groupBox4.Controls.Add(this.textBox_ANGLE_I);
            this.groupBox4.Controls.Add(this.textBox_ANGLE_P);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBox_DIR_D);
            this.groupBox4.Controls.Add(this.textBox_DIR_I);
            this.groupBox4.Controls.Add(this.textBox_DIR_P);
            this.groupBox4.Controls.Add(this.textBox_SPEED_D);
            this.groupBox4.Controls.Add(this.textBox_SPEED_I);
            this.groupBox4.Controls.Add(this.textBox_SPEED_P);
            this.groupBox4.Location = new System.Drawing.Point(670, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 361);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "参数设定";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 268);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 34;
            this.label18.Text = "ANGLE_D：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(40, 242);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 33;
            this.label19.Text = "ANGLE_I：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 214);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 32;
            this.label20.Text = "ANGLE_P：";
            // 
            // textBox_ANGLE_D
            // 
            this.textBox_ANGLE_D.Location = new System.Drawing.Point(101, 264);
            this.textBox_ANGLE_D.Name = "textBox_ANGLE_D";
            this.textBox_ANGLE_D.Size = new System.Drawing.Size(56, 21);
            this.textBox_ANGLE_D.TabIndex = 31;
            this.textBox_ANGLE_D.Text = "0.00";
            this.textBox_ANGLE_D.TextChanged += new System.EventHandler(this.textBox_ANGLE_D_TextChanged);
            // 
            // textBox_ANGLE_I
            // 
            this.textBox_ANGLE_I.Location = new System.Drawing.Point(101, 237);
            this.textBox_ANGLE_I.Name = "textBox_ANGLE_I";
            this.textBox_ANGLE_I.Size = new System.Drawing.Size(56, 21);
            this.textBox_ANGLE_I.TabIndex = 30;
            this.textBox_ANGLE_I.Text = "0.00";
            this.textBox_ANGLE_I.TextChanged += new System.EventHandler(this.textBox_ANGLE_I_TextChanged);
            // 
            // textBox_ANGLE_P
            // 
            this.textBox_ANGLE_P.Location = new System.Drawing.Point(101, 210);
            this.textBox_ANGLE_P.Name = "textBox_ANGLE_P";
            this.textBox_ANGLE_P.Size = new System.Drawing.Size(56, 21);
            this.textBox_ANGLE_P.TabIndex = 29;
            this.textBox_ANGLE_P.Text = "0.00";
            this.textBox_ANGLE_P.TextChanged += new System.EventHandler(this.textBox_ANGLE_P_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 28;
            this.label16.Text = "DIR_D：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 27;
            this.label17.Text = "DIR_I：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "DIR_P：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 25;
            this.label15.Text = "SPEED_D：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "SPEED_I：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "SPEED_P：";
            // 
            // textBox_DIR_D
            // 
            this.textBox_DIR_D.Location = new System.Drawing.Point(101, 181);
            this.textBox_DIR_D.Name = "textBox_DIR_D";
            this.textBox_DIR_D.Size = new System.Drawing.Size(56, 21);
            this.textBox_DIR_D.TabIndex = 6;
            this.textBox_DIR_D.Text = "0.00";
            this.textBox_DIR_D.TextChanged += new System.EventHandler(this.textBox_DIR_D_TextChanged);
            // 
            // textBox_DIR_I
            // 
            this.textBox_DIR_I.Location = new System.Drawing.Point(101, 154);
            this.textBox_DIR_I.Name = "textBox_DIR_I";
            this.textBox_DIR_I.Size = new System.Drawing.Size(56, 21);
            this.textBox_DIR_I.TabIndex = 5;
            this.textBox_DIR_I.Text = "0.00";
            this.textBox_DIR_I.TextChanged += new System.EventHandler(this.textBox_DIR_I_TextChanged);
            // 
            // textBox_DIR_P
            // 
            this.textBox_DIR_P.Location = new System.Drawing.Point(101, 127);
            this.textBox_DIR_P.Name = "textBox_DIR_P";
            this.textBox_DIR_P.Size = new System.Drawing.Size(56, 21);
            this.textBox_DIR_P.TabIndex = 4;
            this.textBox_DIR_P.Text = "0.00";
            this.textBox_DIR_P.TextChanged += new System.EventHandler(this.textBox_DIR_P_TextChanged);
            // 
            // textBox_SPEED_D
            // 
            this.textBox_SPEED_D.Location = new System.Drawing.Point(101, 96);
            this.textBox_SPEED_D.Name = "textBox_SPEED_D";
            this.textBox_SPEED_D.Size = new System.Drawing.Size(56, 21);
            this.textBox_SPEED_D.TabIndex = 3;
            this.textBox_SPEED_D.Text = "0.00";
            this.textBox_SPEED_D.TextChanged += new System.EventHandler(this.textBox_SPEED_D_TextChanged);
            // 
            // textBox_SPEED_I
            // 
            this.textBox_SPEED_I.Location = new System.Drawing.Point(101, 69);
            this.textBox_SPEED_I.Name = "textBox_SPEED_I";
            this.textBox_SPEED_I.Size = new System.Drawing.Size(56, 21);
            this.textBox_SPEED_I.TabIndex = 2;
            this.textBox_SPEED_I.Text = "0.00";
            this.textBox_SPEED_I.TextChanged += new System.EventHandler(this.textBox_SPEED_I_TextChanged);
            // 
            // textBox_SPEED_P
            // 
            this.textBox_SPEED_P.Location = new System.Drawing.Point(101, 42);
            this.textBox_SPEED_P.Name = "textBox_SPEED_P";
            this.textBox_SPEED_P.Size = new System.Drawing.Size(56, 21);
            this.textBox_SPEED_P.TabIndex = 1;
            this.textBox_SPEED_P.Text = "0.00";
            this.textBox_SPEED_P.TextChanged += new System.EventHandler(this.textBox_SPEED_P_TextChanged);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Cnt_ByteRecv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Frm_Angle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "main_form";
            this.Text = "202工作室上位机";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Frm_Angle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Angel_Scope)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_OpenCOM;
        private System.Windows.Forms.CheckBox checkBox_DTR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_motor;
        private System.Windows.Forms.CheckBox checkBox_direction;
        private System.Windows.Forms.CheckBox checkBox_angle;
        private System.Windows.Forms.CheckBox checkBox_speed;
        private System.Windows.Forms.GroupBox Frm_Angle;
        private System.Windows.Forms.PictureBox Angel_Scope;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Cnt_ByteRecv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_CloseMotor;
        private System.Windows.Forms.Button button_CloseImage;
        private System.Windows.Forms.Button button_OpenImage;
        private System.Windows.Forms.Button button_ParameterSet;
        private System.Windows.Forms.Button button_TrytoConnect;
        private System.Windows.Forms.Label label_Motor_Right;
        private System.Windows.Forms.Label label_Motor_Left;
        private System.Windows.Forms.Label label_Speed_Right;
        private System.Windows.Forms.Label label_Speed_Left;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Accer;
        private System.Windows.Forms.Label label_Gyro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_ANGLE_D;
        private System.Windows.Forms.TextBox textBox_ANGLE_I;
        private System.Windows.Forms.TextBox textBox_ANGLE_P;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_DIR_D;
        private System.Windows.Forms.TextBox textBox_DIR_I;
        private System.Windows.Forms.TextBox textBox_DIR_P;
        private System.Windows.Forms.TextBox textBox_SPEED_D;
        private System.Windows.Forms.TextBox textBox_SPEED_I;
        private System.Windows.Forms.TextBox textBox_SPEED_P;
        private System.Windows.Forms.CheckBox checkBox_Accer;
        private System.Windows.Forms.CheckBox checkBox_Gyro;
        private System.Windows.Forms.Label label_Angle_Value;

    }
}

