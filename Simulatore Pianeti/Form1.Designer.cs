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
            this.lst_Pianeti = new System.Windows.Forms.ListBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.txt_posizione = new System.Windows.Forms.TextBox();
            this.txt_massa = new System.Windows.Forms.TextBox();
            this.txt_velocità = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_raggio = new System.Windows.Forms.TextBox();
            this.cmb_colore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_esempi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Location = new System.Drawing.Point(428, 142);
            this.btn_play.Margin = new System.Windows.Forms.Padding(2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(68, 68);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.Play_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(272, 142);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(68, 68);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(344, 142);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(80, 68);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // txt_posizione
            // 
            this.txt_posizione.Location = new System.Drawing.Point(365, 59);
            this.txt_posizione.Margin = new System.Windows.Forms.Padding(2);
            this.txt_posizione.Name = "txt_posizione";
            this.txt_posizione.Size = new System.Drawing.Size(131, 20);
            this.txt_posizione.TabIndex = 4;
            // 
            // txt_massa
            // 
            this.txt_massa.Location = new System.Drawing.Point(365, 35);
            this.txt_massa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_massa.Name = "txt_massa";
            this.txt_massa.Size = new System.Drawing.Size(131, 20);
            this.txt_massa.TabIndex = 5;
            // 
            // txt_velocità
            // 
            this.txt_velocità.Location = new System.Drawing.Point(365, 83);
            this.txt_velocità.Margin = new System.Windows.Forms.Padding(2);
            this.txt_velocità.Name = "txt_velocità";
            this.txt_velocità.Size = new System.Drawing.Size(131, 20);
            this.txt_velocità.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Posizione x;y [m]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Velocità x;y [m/s]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Massa [kg]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Raggio [m]";
            // 
            // txt_raggio
            // 
            this.txt_raggio.Location = new System.Drawing.Point(365, 11);
            this.txt_raggio.Margin = new System.Windows.Forms.Padding(2);
            this.txt_raggio.Name = "txt_raggio";
            this.txt_raggio.Size = new System.Drawing.Size(131, 20);
            this.txt_raggio.TabIndex = 12;
            // 
            // cmb_colore
            // 
            this.cmb_colore.AllowDrop = true;
            this.cmb_colore.FormattingEnabled = true;
            this.cmb_colore.Location = new System.Drawing.Point(365, 108);
            this.cmb_colore.Name = "cmb_colore";
            this.cmb_colore.Size = new System.Drawing.Size(131, 21);
            this.cmb_colore.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Colore";
            // 
            // cmb_esempi
            // 
            this.cmb_esempi.AllowDrop = true;
            this.cmb_esempi.FormattingEnabled = true;
            this.cmb_esempi.Items.AddRange(new object[] {
            "Sistema Sole, Terra e Marte"});
            this.cmb_esempi.Location = new System.Drawing.Point(276, 236);
            this.cmb_esempi.Name = "cmb_esempi";
            this.cmb_esempi.Size = new System.Drawing.Size(220, 21);
            this.cmb_esempi.TabIndex = 16;
            this.cmb_esempi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Esempi preimpostati:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 407);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_esempi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_colore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_raggio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_velocità);
            this.Controls.Add(this.txt_massa);
            this.Controls.Add(this.txt_posizione);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lst_Pianeti);
            this.Controls.Add(this.btn_play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lst_Pianeti;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox txt_posizione;
        private System.Windows.Forms.TextBox txt_massa;
        private System.Windows.Forms.TextBox txt_velocità;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_raggio;
        private System.Windows.Forms.ComboBox cmb_colore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_esempi;
        private System.Windows.Forms.Label label6;
    }
}

