using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            this.MouseWheel += new MouseEventHandler(Form2_MouseWheel);
            planetario.DeltaT = 20d;
            cronometro_fps.Start();
        }

        public Pianeta pianetaSelezionato;
        public bool mousePressed;
        public int mouseX, mouseY, mouseX2, mouseY2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x <= velocita; x++)
            {
                planetario.Move();
            }

            Refresh();

            if (pianetaSelezionato != null)
            {
                label.Text = InformazioniPianeta(pianetaSelezionato);
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

        public float zoom = 1.0f;
        public float traslazioneX = 0, traslazioneY = 0;
        public Matrix transformMatrix;//https://stackoverflow.com/questions/20628979/actual-coordinate-after-scaletransfrom
        public PointF[] centri;
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            trackBar_speed.Location = new Point(ClientSize.Width - trackBar_speed.Width, ClientSize.Height - trackBar_speed.Height);
            lbl_speed.Location = new Point(ClientSize.Width - lbl_speed.Width -20, trackBar_speed.Location.Y - lbl_speed.Height - 4);
            lbl_fps.Location = new Point(ClientSize.Width - lbl_fps.Width - 20, 10);

            Graphics g = CreateGraphics();
            g.ScaleTransform(zoom, zoom);
            g.TranslateTransform(traslazioneX, traslazioneY);
            transformMatrix = g.Transform;

            centri = new PointF[planetario.Pianeti.Count];
            for (int i = 0; i < centri.Length; i++)//disegna tutti i pianeti/stelle
            {
                float xc = (float)Math.Round(planetario.Pianeti[i].Posizione.X / 1e9);
                float yc = Height - (float)Math.Round(planetario.Pianeti[i].Posizione.Y / 1e9);
                centri[i] = new PointF(xc, yc);
                float r = (float)(planetario.Pianeti[i].Raggio / 1e7);
                if (r > 8)
                {
                    float x = xc - r / 2;
                    float y = yc - r / 2;
                    g.FillEllipse(new SolidBrush(planetario.Pianeti[i].Colore), x, y, r, r);
                }
                else
                {
                    float x = xc - 4;
                    float y = yc - 4;
                    g.FillEllipse(new SolidBrush(planetario.Pianeti[i].Colore), x, y, 8, 8);
                }
            }
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X > trackBar_speed.Location.X && e.Y > trackBar_speed.Location.Y)
            {
                trackBar_speed.Enabled = true;
            }
            else
            {
                trackBar_speed.Enabled = false;
            }

            transformMatrix.TransformPoints(centri);
            for (int i = 0; i < centri.Length; i++)
            {
                int r = (int)(planetario.Pianeti[i].Raggio / 1e7 * zoom);
                if (r > 8 && DentroCerchio((int)centri[i].X, (int)centri[i].Y, r, e.X, e.Y))
                {
                    pianetaSelezionato = planetario.Pianeti[i];
                }
                else if (DentroCerchio((int)centri[i].X, (int)centri[i].Y, 8, e.X, e.Y))
                {
                    pianetaSelezionato = planetario.Pianeti[i];
                }
            }

            if (pianetaSelezionato != null)
            {
                label.Text = InformazioniPianeta(pianetaSelezionato);
            }
        }

        public static bool DentroCerchio(int xc, int yc, int r, int x, int y)//controlla se la posizione (x;y) è dentro il cerchio
        {
            return (xc - x) * (xc - x) + (yc - y) * (yc - y) <= r * r;
        }

        public string InformazioniPianeta(Pianeta p)
        {//(per adam) guardare Iformattable
            return string.Format("Pianeta: {0}\nMassa: {1}\nPosizione: {2}\nVelocità: {3}\nRaggio: {4}",
                                 p.Colore, p.Massa, p.Posizione.ToString("0.0000E0"), p.Velocità.ToString("0.0000E0"), p.Raggio.ToString("0.0000E0"));
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //esce dalla simulazione per tornare al form principale
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

        #region Regolazione del form
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

        //https://stackoverflow.com/questions/37262282/zooming-graphics-based-on-current-mouse-position
        private void Form2_MouseWheel(object sender, MouseEventArgs e)
        {
            float mx0, my0;
            scr2obj(out mx0, out my0, e.X, e.Y);
            if (e.Delta < 0)
            {
                zoom -= 0.05f;
                obj2scr(out mx0, out my0, mx0, my0);
                traslazioneX += (e.X - mx0) / zoom;
                traslazioneY += (e.Y - my0) / zoom;
            }
            else
            {
                zoom += 0.05f;
                obj2scr(out mx0, out my0, mx0, my0);
                traslazioneX += (e.X - mx0) / zoom;
                traslazioneY += (e.Y - my0) / zoom;
            }
            
        }
        void scr2obj(out float ox, out float oy, float sx, float sy)
        {
            ox = (sx / zoom) - traslazioneX;
            oy = (sy / zoom) - traslazioneY;
        }
        void obj2scr(out float sx, out float sy, float ox, float oy)
        {
            sx = (traslazioneX + ox) * zoom;
            sy = (traslazioneY + oy) * zoom;
        }
        #endregion
        private void trackBar_speed_Scroll(object sender, EventArgs e)//velocità della simulazione
        {
            planetario.DeltaT = trackBar_speed.Value;
            lbl_speed.Text = (planetario.DeltaT * 1.66666).ToString(".00") + "g/s; " + (planetario.DeltaT).ToString(".00") + "h/tick";
        }
    }
}
