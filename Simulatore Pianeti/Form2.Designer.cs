namespace Simulatore_Pianeti
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.lbl_fps = new System.Windows.Forms.Label();
            this.trackBar_speed = new System.Windows.Forms.TrackBar();
            this.btn_mostrascia = new System.Windows.Forms.Button();
            this.lbl_speed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 78);
            this.label.TabIndex = 0;
            this.label.Text = "Pianeta:\r\nMassa:\r\nPosizione:\r\nVelocità:\r\nRaggio:\r\n\r\n";
            // 
            // lbl_fps
            // 
            this.lbl_fps.AutoSize = true;
            this.lbl_fps.Location = new System.Drawing.Point(1027, 9);
            this.lbl_fps.Name = "lbl_fps";
            this.lbl_fps.Size = new System.Drawing.Size(84, 13);
            this.lbl_fps.TabIndex = 1;
            this.lbl_fps.Text = "000fps; 40tick/s";
            // 
            // trackBar_speed
            // 
            this.trackBar_speed.Enabled = false;
            this.trackBar_speed.Location = new System.Drawing.Point(896, 619);
            this.trackBar_speed.Maximum = 200;
            this.trackBar_speed.Minimum = -200;
            this.trackBar_speed.Name = "trackBar_speed";
            this.trackBar_speed.Size = new System.Drawing.Size(215, 45);
            this.trackBar_speed.TabIndex = 2;
            this.trackBar_speed.TickFrequency = 10;
            this.trackBar_speed.Value = 20;
            this.trackBar_speed.Scroll += new System.EventHandler(this.trackBar_speed_Scroll);
            // 
            // btn_mostrascia
            // 
            this.btn_mostrascia.ForeColor = System.Drawing.Color.Black;
            this.btn_mostrascia.Location = new System.Drawing.Point(12, 631);
            this.btn_mostrascia.Name = "btn_mostrascia";
            this.btn_mostrascia.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrascia.TabIndex = 3;
            this.btn_mostrascia.Text = "Mostra scia";
            this.btn_mostrascia.UseVisualStyleBackColor = true;
            this.btn_mostrascia.Click += new System.EventHandler(this.btn_mostrascia_Click);
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(984, 603);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(111, 13);
            this.lbl_speed.TabIndex = 4;
            this.lbl_speed.Text = "33.33g/s; 20.00h/tick";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1113, 666);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.btn_mostrascia);
            this.Controls.Add(this.trackBar_speed);
            this.Controls.Add(this.lbl_fps);
            this.Controls.Add(this.label);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form2";
            this.Text = "Simulatore_Pianeti finestra di simulazione";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbl_fps;
        private System.Windows.Forms.TrackBar trackBar_speed;
        private System.Windows.Forms.Button btn_mostrascia;
        private System.Windows.Forms.Label lbl_speed;
    }
}