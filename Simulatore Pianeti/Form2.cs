using System;
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
using Vettori;

namespace Simulatore_Pianeti
{
    public partial class Form2 : Form
    {
        private Planetario planetario = Form1.planetario;
        private Pianeta pianeta;
        private Stopwatch cronometro;
        private int velocita = 60 * 60;

        public Form2()
        {
            InitializeComponent();
            Inizializza();
        }

        private void Inizializza()
        {
            cronometro = new Stopwatch();
            planetario.DeltaT = 20;
            cronometro.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x <= velocita; x++)
            {
                planetario.Muovi();
            }
            Invalidate();

            if (pianeta != null)
            {
                label.Text = InformazioniPianeta(pianeta);
            }

            TassoAggiornamento();

            cronometro.Restart();
        }

        private void TassoAggiornamento()
        {
            lbl_fps.Text = (1000 / cronometro.ElapsedMilliseconds).ToString();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            foreach (Pianeta p in planetario.Pianeti)
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //stop/start
            if (e.KeyCode == Keys.Space && timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else if (e.KeyCode == Keys.Space)
            {
                timer1.Enabled = true;
            }
            //regola la velocità
            if (e.KeyCode == Keys.OemMinus)//[-]
            {
                planetario.DeltaT--;
            }
            if (e.KeyCode == Keys.Oemplus)//[+]
            {
                planetario.DeltaT++;
            }
            //skip
            if (e.KeyCode == Keys.Right)//avanti 16 tick
            {
                planetario.DeltaT = 16 * planetario.DeltaT;
                timer1_Tick(sender, e);
                planetario.DeltaT = planetario.DeltaT / 16;
            }
            if (e.KeyCode == Keys.Left)//indietro 16 tick
            {
                planetario.DeltaT = -16 * planetario.DeltaT;
                timer1_Tick(sender, e);
                planetario.DeltaT = -planetario.DeltaT / 16;
            }
            if (e.KeyCode == Keys.Oemcomma)//avanti 1 tick [,]
            {
                timer1_Tick(sender, e);
            }
            if (e.KeyCode == Keys.OemPeriod)//indietro 1 tick [.]
            {
                planetario.DeltaT = -planetario.DeltaT;
                timer1_Tick(sender, e);
                planetario.DeltaT = -planetario.DeltaT;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Pianeta p in planetario.Pianeti)
            {
                int xc = (int)Math.Round(p.Posizione.X / 1e9d);
                int yc = Height - (int)Math.Round(p.Posizione.Y / 1e9d);
                int r = (int)(p.Raggio / 1e7d);
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
        {
            return string.Format("Pianeta: {0}\nMassa: {1}\nPosizione: {2}\nVelocità: {3}\nRaggio: {4}",
                                 p.Colore, p.Massa, p.Posizione.ToString("0.0000E0"), p.Velocità.ToString("0.0000E0"), p.Raggio.ToString("0.0000E0"));
        }

        public static bool DentroCerchio(int xc, int yc, int r, int x, int y)
        {
            int dx = xc - x;
            int dy = yc - y;
            return dx * dx + dy * dy <= r * r;
        }
    }
}
