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
            this.lst_Pianeti = new System.Windows.Forms.ListBox();
            this.Play = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.vPos = new System.Windows.Forms.TextBox();
            this.Massa = new System.Windows.Forms.TextBox();
            this.vVel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Raggio = new System.Windows.Forms.TextBox();
            this.Colori = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lst_Pianeti
            // 
            this.lst_Pianeti.FormattingEnabled = true;
            this.lst_Pianeti.Location = new System.Drawing.Point(9, 11);
            this.lst_Pianeti.Margin = new System.Windows.Forms.Padding(2);
            this.lst_Pianeti.Name = "lst_Pianeti";
            this.lst_Pianeti.Size = new System.Drawing.Size(255, 381);
            this.lst_Pianeti.TabIndex = 1;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(615, 135);
            this.Play.Margin = new System.Windows.Forms.Padding(2);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(68, 68);
            this.Play.TabIndex = 0;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(459, 135);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(68, 68);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.Location = new System.Drawing.Point(531, 135);
            this.Remove.Margin = new System.Windows.Forms.Padding(2);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(80, 68);
            this.Remove.TabIndex = 3;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // vPos
            // 
            this.vPos.Location = new System.Drawing.Point(552, 41);
            this.vPos.Margin = new System.Windows.Forms.Padding(2);
            this.vPos.Name = "vPos";
            this.vPos.Size = new System.Drawing.Size(131, 20);
            this.vPos.TabIndex = 4;
            // 
            // Massa
            // 
            this.Massa.Location = new System.Drawing.Point(552, 89);
            this.Massa.Margin = new System.Windows.Forms.Padding(2);
            this.Massa.Name = "Massa";
            this.Massa.Size = new System.Drawing.Size(131, 20);
            this.Massa.TabIndex = 5;
            // 
            // vVel
            // 
            this.vVel.Location = new System.Drawing.Point(552, 65);
            this.vVel.Margin = new System.Windows.Forms.Padding(2);
            this.vVel.Name = "vVel";
            this.vVel.Size = new System.Drawing.Size(131, 20);
            this.vVel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Posizione (x,y)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Velocità (x,y)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Massa (kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Raggio";
            // 
            // Raggio
            // 
            this.Raggio.Location = new System.Drawing.Point(552, 17);
            this.Raggio.Margin = new System.Windows.Forms.Padding(2);
            this.Raggio.Name = "Raggio";
            this.Raggio.Size = new System.Drawing.Size(131, 20);
            this.Raggio.TabIndex = 12;
            // 
            // Colori
            // 
            this.Colori.AllowDrop = true;
            this.Colori.FormattingEnabled = true;
            this.Colori.Location = new System.Drawing.Point(296, 18);
            this.Colori.Name = "Colori";
            this.Colori.Size = new System.Drawing.Size(121, 21);
            this.Colori.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 407);
            this.Controls.Add(this.Colori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Raggio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vVel);
            this.Controls.Add(this.Massa);
            this.Controls.Add(this.vPos);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.lst_Pianeti);
            this.Controls.Add(this.Play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lst_Pianeti;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox vPos;
        private System.Windows.Forms.TextBox Massa;
        private System.Windows.Forms.TextBox vVel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Raggio;
        private System.Windows.Forms.ComboBox Colori;
    }
}

