namespace SmartCarCOMServer
{
    partial class Logger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Richbox_Loggor = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Richbox_Loggor
            // 
            this.Richbox_Loggor.Location = new System.Drawing.Point(12, 12);
            this.Richbox_Loggor.Name = "Richbox_Loggor";
            this.Richbox_Loggor.Size = new System.Drawing.Size(854, 141);
            this.Richbox_Loggor.TabIndex = 0;
            this.Richbox_Loggor.Text = "";
            this.Richbox_Loggor.TextChanged += new System.EventHandler(this.Richbox_Loggor_TextChanged);
            // 
            // Logger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 165);
            this.Controls.Add(this.Richbox_Loggor);
            this.Name = "Logger";
            this.Text = "Command Log";
            this.Load += new System.EventHandler(this.Logger_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Richbox_Loggor;
    }
}