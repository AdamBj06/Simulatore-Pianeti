namespace Simulatore_Pianeti
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pianeti = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.TextBox();
            this.V = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pianeti
            // 
            this.Pianeti.FormattingEnabled = true;
            this.Pianeti.ItemHeight = 16;
            this.Pianeti.Location = new System.Drawing.Point(12, 12);
            this.Pianeti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pianeti.Name = "Pianeti";
            this.Pianeti.Size = new System.Drawing.Size(120, 84);
            this.Pianeti.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(173, 102);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(173, 131);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(164, -3);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(100, 22);
            this.S.TabIndex = 4;
            this.S.Text = "S";
            this.S.TextChanged += new System.EventHandler(this.S_TextChanged);
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(173, 64);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(100, 22);
            this.m.TabIndex = 5;
            this.m.Text = "m";
            // 
            // V
            // 
            this.V.Location = new System.Drawing.Point(173, 25);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(100, 22);
            this.V.TabIndex = 6;
            this.V.Text = "V";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.V);
            this.Controls.Add(this.m);
            this.Controls.Add(this.S);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Pianeti);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox Pianeti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox S;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.TextBox V;
    }
}

