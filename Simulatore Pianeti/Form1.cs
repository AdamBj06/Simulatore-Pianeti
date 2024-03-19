﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Simulatore_Pianeti
{
    public partial class Form1 : Form
    {   //da fare: aggiungere altri esempi...
        public static Planetario planetario = new Planetario();//static per poterlo usare anche nel secondo form

        public Form1()
        {
            InitializeComponent();
            //riempe le combobox
            #region InitializeComboBoxes
            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))//Carolin (riempe la combobox dei colori con tutti i colori esistenti nel sistema)
            {
                Color color = Color.FromKnownColor(knownColor);
                if (!color.IsSystemColor)
                {
                    cmb_colore.Items.Add(color);
                }
            }

            Cmb_esempi.Items.Add("Sistema Sole e Terra");
            Cmb_esempi.Items.Add("Sistema Sole, Terra e Marte");
            //altri esempi
            #endregion
        }
        //obbligatrio
        #region impostazione
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_massa.Text == "" && txt_posizione.Text == "" && txt_velocità.Text == "")
            {
                MessageBox.Show("Un pianeta deve avere come minimo una massa, una posizione iniziale e una velocità iniziale", "Errore");
                return;
            }

            double raggio;
            if (txt_raggio.Text == "")
            {//se l'utente non ha scelto un raggio, raggio=0
                raggio = 0;
            }
            else if(double.TryParse(txt_raggio.Text, out raggio) == false)
            {
                MessageBox.Show("Raggio non valido", "Errore");
                return;
            }

            Color colore;
            if (cmb_colore.SelectedIndex != -1)
            {//se l'utente ha scelto un colore, metti quel colore
                colore = (Color)cmb_colore.SelectedItem;
            }
            else
            {//se no metti bianco
                colore = Color.White;
            }

            if (double.TryParse(txt_massa.Text, out double massa) == false)
            {
                MessageBox.Show("Massa non valida", "Errore");
                return;
            }
            if (Vettore.TryParse(txt_posizione.Text, out Vettore posizione) == false)
            {
                MessageBox.Show("Posizione non valida", "Errore");
                return;
            }
            if (Vettore.TryParse(txt_velocità.Text, out Vettore velocità) == false)
            {
                MessageBox.Show("Velocità non valida", "Errore");
                return;
            }

            Pianeta pianeta = new Pianeta(colore, raggio, massa, posizione, velocità);
            lst_Pianeti.Items.Add(pianeta);

            Clear();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            lst_Pianeti.Items.Remove(lst_Pianeti.SelectedItem);
            Clear();
        }

        private void Clear()
        {
            txt_raggio.Clear();
            txt_posizione.Clear();
            txt_velocità.Clear();
            txt_massa.Clear();
            cmb_colore.SelectedIndex = -1;
            cmb_pianetiSalvati.SelectedIndex = -1;
        }

        private void Btn_Play_Click(object sender, EventArgs e)//Inizia la simulazione
        {
            planetario.Pianeti.Clear();
            foreach (Pianeta p in lst_Pianeti.Items)
            {
                planetario.Pianeti.Add(p);
            }
            lst_Pianeti.Items.Clear();

            Form2 Form2 = new Form2();//crea un secondo form
            Form2.Owner = this;//serve per avere un riferimento al primo form nel secondo
            this.Visible = false;//rende invisibile il primo form
            Form2.Show();//fa vedere il secondo form
        }

        private void lst_Pianeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lst_Pianeti.SelectedIndex != -1)
            {
                Pianeta p = (Pianeta)lst_Pianeti.Items[lst_Pianeti.SelectedIndex];
                txt_raggio.Text = p.Raggio.ToString("0.0000E0");
                txt_posizione.Text = p.Posizione.ToString("0.0000E0");
                txt_velocità.Text = p.Velocità.ToString("0.0000E0");
                txt_massa.Text = p.Massa.ToString("0.0000E0");
                cmb_colore.SelectedIndex = cmb_colore.Items.IndexOf(p.Colore);
            }
            cmb_pianetiSalvati.SelectedIndex = -1;
        }

        private void btn_Salva_Click(object sender, EventArgs e)
        {
            cmb_pianetiSalvati.Items.Add(lst_Pianeti.SelectedItem);
        }

        private void cmb_pianetiSalvati_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_pianetiSalvati.SelectedIndex != -1)
            {
                Pianeta p = (Pianeta)cmb_pianetiSalvati.Items[cmb_pianetiSalvati.SelectedIndex];
                txt_raggio.Text = p.Raggio.ToString("0.0000E0");
                txt_posizione.Text = p.Posizione.ToString("0.0000E0");
                txt_velocità.Text = p.Velocità.ToString("0.0000E0");
                txt_massa.Text = p.Massa.ToString("0.0000E0");
                cmb_colore.SelectedIndex = cmb_colore.Items.IndexOf(p.Colore);
            }
            lst_Pianeti.SelectedIndex = -1;
        }
        #endregion

        #region Esempi preimpostati
        private void Cmb_esempi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_Pianeti.Items.Clear();
            double xs = 1e9d * 453.3d;//posizione del sole
            double ys = 1e9d * 382.5d;
            switch (Cmb_esempi.SelectedIndex)//sistemare valori
            {
                case 0://Sistema Sole e Terra
                    lst_Pianeti.Items.Add(new Pianeta(Color.Yellow, 7e8d, 2e30d, new Vettore(xs, ys), new Vettore(0d, 0d)));
                    lst_Pianeti.Items.Add(new Pianeta(Color.Cyan, 6.378e6d, 6e24d, new Vettore(xs + 1.52097701e11d, ys), new Vettore(0d, 2.876e4d)));
                    break;
                case 1://Sistema Sole, Terra e Marte
                    lst_Pianeti.Items.Add(new Pianeta(Color.Yellow, 7e8d, 2e30d, new Vettore(xs, ys), new Vettore(0d, 0d)));
                    lst_Pianeti.Items.Add(new Pianeta(Color.Cyan, 6.378e6d, 6e24d, new Vettore(xs + 1.52097701e11d, ys), new Vettore(0d, 2.876e4d)));
                    lst_Pianeti.Items.Add(new Pianeta(Color.Red, 3.3895e6d, 6.39e23d, new Vettore(xs + 2.49228730e11d, ys), new Vettore(0d, 2.413e4d)));
                    break;
                case 2://sistema solare
                    break;
                default:
                    break;
            }
        }
        #endregion
        //in più
        #region Tema
        bool TemaScuro = true;
        private void btn_tema_Click(object sender, EventArgs e)
        {
            if (TemaScuro)
            {
                btn_tema.Text = "Tema scuro";

                this.BackColor = SystemColors.Control;
                foreach (Control control in Controls)
                {
                    if(control != btn_add && control != btn_remove && control != btn_play && !(control is Label))
                    {
                        control.BackColor = SystemColors.Window;//il colore di default di windows
                        control.ForeColor = SystemColors.ControlText;
                    }
                    else if(control is Label)
                    {
                        control.BackColor = SystemColors.Control;
                        control.ForeColor = SystemColors.ControlText;
                    }
                }

                TemaScuro = false;
            }
            else
            {
                btn_tema.Text = "Tema chiaro";

                this.BackColor = Color.FromArgb(21, 32, 43);
                foreach (Control control in Controls)
                {
                    if (control != btn_add && control != btn_remove && control != btn_play && !(control is TextBox))
                    {
                        control.BackColor = Color.FromArgb(25, 39, 52);
                        control.ForeColor = Color.White;
                    }
                }

                TemaScuro = true;
            }
        }
        #endregion
        //in più
        #region "disegno" di vettori trascinando (velocità) o cliccando (posizione)
        int xi, yi;
        bool inPos = false, inVel = false;

        private void txt_posizione_Enter(object sender, EventArgs e)
        {
            inPos = true;
        }

        private void txt_posizione_Leave(object sender, EventArgs e)
        {
            inPos = false;
        }

        private void txt_velocità_Enter(object sender, EventArgs e)
        {
            inVel = true;
        }

        private void txt_velocità_Leave(object sender, EventArgs e)
        {
            inVel = false;
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen nero = new Pen(Color.Black, 4);
            g.Clear(BackColor);//ripulisce il form quando neccessario

            g.DrawLine(nero, 698, Height - 48, Width - 40, Height - 48);//asse x
            g.DrawLine(nero, 698, Height - 48, 698, 20);//asse y
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            Brush sfondo = new SolidBrush(BackColor);
            g.FillRectangle(sfondo, 700, 0, Width, Height - 50);//ripulisce l'area in cui si può disegnare

            xi = e.X; yi = e.Y;
            if (xi > 700 && yi < Height - 50)//se il click avviene nella parte del form permesssa
            {
                if (inPos)
                {
                    txt_posizione.Text = new Vettore((xi - 700) * 1e9, (Height - 48 - yi) * 1e9).ToString("0.0000E0");//pos finale - origine (pos iniziale)
                    g.FillEllipse(Brushes.Black, xi, yi, 8, 8);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen nero = new Pen(Color.Black, 3);

            int xf = e.X; int yf = e.Y;
            if (xi > 700 && yi < Height - 50 && xf > 700 && yf < Height - 50)//se il rilascio del click avviene nella parte del form permesssa
            {
                if(inVel)
                {
                    txt_velocità.Text = new Vettore((xf - xi) * 5e2, (yi - yf) * 5e2).ToString("0.0000E0");//pos finale - pos iniziale, in y invertito perchè siamo nel 4 quadrante
                    g.DrawLine(nero, xi, yi, xf, yf);
                }
            }
        }
        #endregion
    }
}
