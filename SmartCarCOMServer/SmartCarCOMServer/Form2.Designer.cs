namespace SmartCarCOMServer
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components ;//= null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            this.Hide();
           // if (disposing && (components != null))
           // {
           //     components.Dispose();
           // }
           // base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RX_Box = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RX_HEX = new System.Windows.Forms.CheckBox();
            this.CheckBox_autodelete = new System.Windows.Forms.CheckBox();
            this.TX_Box = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TX_HEX = new System.Windows.Forms.CheckBox();
            this.send_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RX_Box
            // 
            this.RX_Box.Location = new System.Drawing.Point(12, 27);
            this.RX_Box.Name = "RX_Box";
            this.RX_Box.ReadOnly = true;
            this.RX_Box.Size = new System.Drawing.Size(356, 309);
            this.RX_Box.TabIndex = 0;
            this.RX_Box.Text = "";
            this.RX_Box.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "接收区：";
            // 
            // RX_HEX
            // 
            this.RX_HEX.AutoSize = true;
            this.RX_HEX.Location = new System.Drawing.Point(75, 8);
            this.RX_HEX.Name = "RX_HEX";
            this.RX_HEX.Size = new System.Drawing.Size(42, 16);
            this.RX_HEX.TabIndex = 2;
            this.RX_HEX.Text = "HEX";
            this.RX_HEX.UseVisualStyleBackColor = true;
            this.RX_HEX.CheckedChanged += new System.EventHandler(this.RX_HEX_CheckedChanged);
            // 
            // CheckBox_autodelete
            // 
            this.CheckBox_autodelete.AutoSize = true;
            this.CheckBox_autodelete.Location = new System.Drawing.Point(123, 8);
            this.CheckBox_autodelete.Name = "CheckBox_autodelete";
            this.CheckBox_autodelete.Size = new System.Drawing.Size(72, 16);
            this.CheckBox_autodelete.TabIndex = 3;
            this.CheckBox_autodelete.Text = "自动清除";
            this.CheckBox_autodelete.UseVisualStyleBackColor = true;
            // 
            // TX_Box
            // 
            this.TX_Box.Location = new System.Drawing.Point(12, 369);
            this.TX_Box.Name = "TX_Box";
            this.TX_Box.Size = new System.Drawing.Size(356, 96);
            this.TX_Box.TabIndex = 4;
            this.TX_Box.Text = "";
            this.TX_Box.TextChanged += new System.EventHandler(this.TX_Box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "发送区：";
            // 
            // TX_HEX
            // 
            this.TX_HEX.AutoSize = true;
            this.TX_HEX.Location = new System.Drawing.Point(86, 345);
            this.TX_HEX.Name = "TX_HEX";
            this.TX_HEX.Size = new System.Drawing.Size(42, 16);
            this.TX_HEX.TabIndex = 6;
            this.TX_HEX.Text = "HEX";
            this.TX_HEX.UseVisualStyleBackColor = true;
            this.TX_HEX.CheckedChanged += new System.EventHandler(this.TX_HEX_CheckedChanged);
            // 
            // send_button
            // 
            this.send_button.Enabled = false;
            this.send_button.Location = new System.Drawing.Point(247, 494);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(75, 23);
            this.send_button.TabIndex = 7;
            this.send_button.Text = "发送";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.TX_HEX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TX_Box);
            this.Controls.Add(this.CheckBox_autodelete);
            this.Controls.Add(this.RX_HEX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RX_Box);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "字符流显示";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RX_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RX_HEX;
        private System.Windows.Forms.CheckBox CheckBox_autodelete;
        private System.Windows.Forms.RichTextBox TX_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox TX_HEX;
        public System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button button1;

    }
}