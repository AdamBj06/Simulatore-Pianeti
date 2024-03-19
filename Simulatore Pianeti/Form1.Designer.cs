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
            this.Cmb_esempi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_tema = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Salva = new System.Windows.Forms.Button();
            this.cmb_pianetiSalvati = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lst_Pianeti
            // 
            this.lst_Pianeti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.lst_Pianeti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_Pianeti.ForeColor = System.Drawing.Color.White;
            this.lst_Pianeti.FormattingEnabled = true;
            this.lst_Pianeti.ItemHeight = 16;
            this.lst_Pianeti.Location = new System.Drawing.Point(15, 14);
            this.lst_Pianeti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lst_Pianeti.Name = "lst_Pianeti";
            this.lst_Pianeti.Size = new System.Drawing.Size(555, 1120);
            this.lst_Pianeti.TabIndex = 1;
            this.lst_Pianeti.SelectedIndexChanged += new System.EventHandler(this.lst_Pianeti_SelectedIndexChanged);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Location = new System.Drawing.Point(785, 175);
            this.btn_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(111, 84);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.Btn_Play_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(577, 175);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(91, 84);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(673, 175);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(107, 84);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // txt_posizione
            // 
            this.txt_posizione.BackColor = System.Drawing.Color.White;
            this.txt_posizione.ForeColor = System.Drawing.Color.Black;
            this.txt_posizione.Location = new System.Drawing.Point(701, 73);
            this.txt_posizione.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_posizione.Name = "txt_posizione";
            this.txt_posizione.Size = new System.Drawing.Size(193, 22);
            this.txt_posizione.TabIndex = 4;
            this.txt_posizione.Enter += new System.EventHandler(this.txt_posizione_Enter);
            this.txt_posizione.Leave += new System.EventHandler(this.txt_posizione_Leave);
            // 
            // txt_massa
            // 
            this.txt_massa.BackColor = System.Drawing.Color.White;
            this.txt_massa.ForeColor = System.Drawing.Color.Black;
            this.txt_massa.Location = new System.Drawing.Point(701, 43);
            this.txt_massa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_massa.Name = "txt_massa";
            this.txt_massa.Size = new System.Drawing.Size(193, 22);
            this.txt_massa.TabIndex = 5;
            // 
            // txt_velocità
            // 
            this.txt_velocità.BackColor = System.Drawing.Color.White;
            this.txt_velocità.ForeColor = System.Drawing.Color.Black;
            this.txt_velocità.Location = new System.Drawing.Point(701, 102);
            this.txt_velocità.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_velocità.Name = "txt_velocità";
            this.txt_velocità.Size = new System.Drawing.Size(193, 22);
            this.txt_velocità.TabIndex = 6;
            this.txt_velocità.Enter += new System.EventHandler(this.txt_velocità_Enter);
            this.txt_velocità.Leave += new System.EventHandler(this.txt_velocità_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Posizione x;y [m]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Velocità x;y [m/s]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Massa [kg]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Raggio [m]";
            // 
            // txt_raggio
            // 
            this.txt_raggio.BackColor = System.Drawing.Color.White;
            this.txt_raggio.ForeColor = System.Drawing.Color.Black;
            this.txt_raggio.Location = new System.Drawing.Point(701, 14);
            this.txt_raggio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_raggio.Name = "txt_raggio";
            this.txt_raggio.Size = new System.Drawing.Size(193, 22);
            this.txt_raggio.TabIndex = 12;
            // 
            // cmb_colore
            // 
            this.cmb_colore.AllowDrop = true;
            this.cmb_colore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.cmb_colore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_colore.ForeColor = System.Drawing.Color.White;
            this.cmb_colore.FormattingEnabled = true;
            this.cmb_colore.Location = new System.Drawing.Point(701, 133);
            this.cmb_colore.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_colore.Name = "cmb_colore";
            this.cmb_colore.Size = new System.Drawing.Size(193, 24);
            this.cmb_colore.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Colore";
            // 
            // Cmb_esempi
            // 
            this.Cmb_esempi.AllowDrop = true;
            this.Cmb_esempi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.Cmb_esempi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_esempi.ForeColor = System.Drawing.Color.White;
            this.Cmb_esempi.FormattingEnabled = true;
            this.Cmb_esempi.Location = new System.Drawing.Point(583, 290);
            this.Cmb_esempi.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_esempi.Name = "Cmb_esempi";
            this.Cmb_esempi.Size = new System.Drawing.Size(312, 24);
            this.Cmb_esempi.TabIndex = 16;
            this.Cmb_esempi.SelectedIndexChanged += new System.EventHandler(this.Cmb_esempi_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Esempi preimpostati:";
            // 
            // btn_tema
            // 
            this.btn_tema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btn_tema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tema.Location = new System.Drawing.Point(583, 385);
            this.btn_tema.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tema.Name = "btn_tema";
            this.btn_tema.Size = new System.Drawing.Size(111, 28);
            this.btn_tema.TabIndex = 18;
            this.btn_tema.Text = "Tema chiaro";
            this.btn_tema.UseVisualStyleBackColor = false;
            this.btn_tema.Click += new System.EventHandler(this.btn_tema_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(580, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Pianeti salvati:";
            // 
            // btn_Salva
            // 
            this.btn_Salva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btn_Salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salva.Location = new System.Drawing.Point(814, 340);
            this.btn_Salva.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salva.Name = "btn_Salva";
            this.btn_Salva.Size = new System.Drawing.Size(82, 28);
            this.btn_Salva.TabIndex = 21;
            this.btn_Salva.Text = "Salva";
            this.btn_Salva.UseVisualStyleBackColor = false;
            this.btn_Salva.Click += new System.EventHandler(this.btn_Salva_Click);
            // 
            // cmb_pianetiSalvati
            // 
            this.cmb_pianetiSalvati.AllowDrop = true;
            this.cmb_pianetiSalvati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.cmb_pianetiSalvati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_pianetiSalvati.ForeColor = System.Drawing.Color.White;
            this.cmb_pianetiSalvati.FormattingEnabled = true;
            this.cmb_pianetiSalvati.Location = new System.Drawing.Point(583, 341);
            this.cmb_pianetiSalvati.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_pianetiSalvati.Name = "cmb_pianetiSalvati";
            this.cmb_pianetiSalvati.Size = new System.Drawing.Size(222, 24);
            this.cmb_pianetiSalvati.TabIndex = 22;
            this.cmb_pianetiSalvati.SelectedIndexChanged += new System.EventHandler(this.cmb_pianetiSalvati_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1564, 559);
            this.Controls.Add(this.cmb_pianetiSalvati);
            this.Controls.Add(this.btn_Salva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_tema);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cmb_esempi);
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
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Simulatore_Pianeti finestra di impostazione";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
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
        private System.Windows.Forms.ComboBox Cmb_esempi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_tema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Salva;
        private System.Windows.Forms.ComboBox cmb_pianetiSalvati;
    }
}

