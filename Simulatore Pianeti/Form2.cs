﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulatore_Pianeti
{
    public partial class Form2 : Form
    {
        public Planetario planetario = Form1.planetario;
        public Stopwatch cronometro_fps = new Stopwatch();
        public int velocita = 3600;

        public Form2()
        {
            InitializeComponent();
            planetario.DeltaT = 20d;
            cronometro_fps.Start();
        }

        public Pianeta pianeta;
        public bool mousePressed;
        public int mouseX, mouseY, mouseX2, mouseY2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x <= velocita; x++)
            {
                planetario.Move();
            }

            Invalidate();

            if (pianeta != null)
            {
                label.Text = InformazioniPianeta(pianeta);
            }

            lbl_fps.Text = (1000 / cronometro_fps.ElapsedMilliseconds).ToString();
            cronometro_fps.Restart();


            mouseX2 = MousePosition.X - mouseX;
            mouseY2 = mouseY - MousePosition.Y;
            if (mousePressed)
            {
                foreach(Pianeta p in planetario.Pianeti)
                {
                    p.Posizione.X += 4e8d * mouseX2;
                    p.Posizione.Y += 4e8d * mouseY2;
                }
                mouseX = MousePosition.X;
                mouseY = MousePosition.Y;
            }
        }

        public bool mostrascia = false;
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            trackBar_speed.Location = new Point(ClientSize.Width - trackBar_speed.Width, ClientSize.Height - trackBar_speed.Height);
            lbl_speed.Location = new Point(ClientSize.Width - lbl_speed.Width -20, trackBar_speed.Location.Y - lbl_speed.Height - 4);
            lbl_fps.Location = new Point(Width - lbl_fps.Width - 20, 10);

            Graphics g = CreateGraphics();
            foreach (Pianeta p in planetario.Pianeti)//disegna tutti i pianeti/stelle
            {
                if (p.Raggio > 8e7d)
                {
                    float x = (float)Math.Round(p.Posizione.X / 1e9d) - (float)(p.Raggio / 1e7d / 2);
                    float y = Height - (float)Math.Round(p.Posizione.Y / 1e9d) - (float)(p.Raggio / 1e7d / 2);
                    float r = (float)(p.Raggio / 1e7d);
                    g.FillEllipse(new SolidBrush(p.Colore), x, y, r, r);
                }
                else
                {
                    float x = (float)Math.Round(p.Posizione.X / 1e9d);
                    float y = Height - (float)Math.Round(p.Posizione.Y / 1e9d);
                    g.FillEllipse(new SolidBrush(p.Colore), x, y, 8, 8);
                }
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //esci dalla simulazione per tornare al form principale
            if(e.KeyCode == Keys.Escape)
            {
                Owner.Visible = true;
                Close();
            }
            //stop/start
            if (e.KeyCode == Keys.Space && timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else if (e.KeyCode == Keys.Space)
            {
                timer1.Enabled = true;
            }
            /*//regola la velocità
            if (e.KeyCode == Keys.OemMinus)//[-]
            {
                planetario.DeltaT--;
            }
            if (e.KeyCode == Keys.Oemplus)//[+]
            {
                planetario.DeltaT++;
            }*/
            //skip
            if (e.KeyCode == Keys.Right)//avanti 16 tick
            {
                planetario.DeltaT = 16 * planetario.DeltaT;
                timer1_Tick(sender, e);//richiama l'evento tick del timer
                planetario.DeltaT = planetario.DeltaT / 16;
            }
            if (e.KeyCode == Keys.Left)//indietro 16 tick
            {
                planetario.DeltaT = -16 * planetario.DeltaT;
                timer1_Tick(sender, e);
                planetario.DeltaT = -planetario.DeltaT / 16;
            }
            if (e.KeyCode == Keys.OemPeriod && timer1.Enabled == false)//avanti 1 tick [,]
            {
                timer1_Tick(sender, e);
            }
            if (e.KeyCode == Keys.Oemcomma && timer1.Enabled == false)//indietro 1 tick [.]
            {
                planetario.DeltaT = -planetario.DeltaT;
                timer1_Tick(sender, e);
                planetario.DeltaT = -planetario.DeltaT;
            }
        }

        #region Movimento nel form
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                Cursor = Cursors.NoMove2D;
                mouseX = MousePosition.X;
                mouseY = MousePosition.Y;
                mousePressed = true;
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                Cursor = Cursors.Default;
                mousePressed = false;
            }
        }
        #endregion

        private void trackBar_speed_Scroll(object sender, EventArgs e)//velocità della simulazione
        {
            planetario.DeltaT = trackBar_speed.Value;
            lbl_speed.Text = (planetario.DeltaT * 1.66666).ToString(".00") + "g/s; " + (planetario.DeltaT).ToString(".00") + "h/tick";
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.X > trackBar_speed.Location.X && e.Y > trackBar_speed.Location.Y) 
            { 
                trackBar_speed.Enabled = true;
            }
            else
            {
                trackBar_speed.Enabled = false;
            }

            foreach (Pianeta p in planetario.Pianeti)
            {
                int xc = (int)Math.Round(p.Posizione.X / 1e9d);//centro del cerchio/pianeta
                int yc = Height - (int)Math.Round(p.Posizione.Y / 1e9d);//centro del cerchio/pianeta
                int r = (int)(p.Raggio / 1e7d);//raggio del cerchio/pianeta
                if (p.Raggio > 8e7d && DentroCerchio(xc, yc, r, e.X, e.Y))
                {
                    pianeta = p;
                }
                else if (DentroCerchio(xc, yc, 8, e.X, e.Y))
                {
                    pianeta = p;
                }
            }

            if (pianeta != null)
            {
                label.Text = InformazioniPianeta(pianeta);
            }
        }

        public string InformazioniPianeta(Pianeta p)
        {//(per adam) guardare Iformattable
            return string.Format("Pianeta: {0}\nMassa: {1}\nPosizione: {2}\nVelocità: {3}\nRaggio: {4}",
                                 p.Colore, p.Massa, p.Posizione.ToString("0.0000E0"), p.Velocità.ToString("0.0000E0"), p.Raggio.ToString("0.0000E0"));
        }

        public static bool DentroCerchio(int xc, int yc, int r, int x, int y)//controlla se la posizione (x;y) è dentro il cerchio
        {
            int dx = xc - x;
            int dy = yc - y;
            return dx * dx + dy * dy <= r * r;
        }
    }
}
