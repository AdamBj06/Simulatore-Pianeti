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
        public Planetario planetario = Form1.planetario;//ottiene la classe planetario dichiarata nel primo form
        public Stopwatch cronometro_fps = new Stopwatch();

        public Form2()
        {
            InitializeComponent();
            MouseWheel += new MouseEventHandler(Form2_MouseWheel);//aggiunge l'evento che riconosce quando si scrolla col mouse
            planetario.DeltaT = 36d;//ricorda: più è alto il deltaT meno è precisa la simulazione
            cronometro_fps.Start();
        }
        
        #region velocità di simulazione
        private void trackBar_speed_Scroll(object sender, EventArgs e)
        {
            planetario.DeltaT = trackBar_speed.Value;//i valori sono tra -220 e +220
            lbl_speed.Text = (planetario.DeltaT * 1.66666).ToString(".00") + "g/s; " + planetario.DeltaT.ToString(".00") + "h/tick";
        }
        #endregion
        
        #region Simulazione
        public Pianeta pianetaSelezionato;//pianeta di cui far vedere le info
        public bool mousePressed;//vero se il tasto centrale del mouse è cliccato
        public int mouseX, mouseY, deltaMouseX, deltaMouseY;//posizioni iniziali del mouse; distanza da pos in. e pos f.
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x <= 2000; x++)
            {//il move avvine 2000 volte per velocizzare la simulazione senza perdere precisione
                planetario.Move();
            }

            Refresh();//ripulisce il form è fa partire l'evento paint

            if (pianetaSelezionato != null)
            {
                label.Text = InformazioniPianeta(pianetaSelezionato);
            }

            //fps
            lbl_fps.Text = (1000 / cronometro_fps.ElapsedMilliseconds).ToString();
            cronometro_fps.Restart();
            //

            deltaMouseX = MousePosition.X - mouseX;//pos finale - pos iniziale
            deltaMouseY = mouseY - MousePosition.Y;//idem ma invertito perchè siamo nel 4 quadrante
            if (mousePressed)
            {
                foreach(Pianeta p in planetario.Pianeti)//trasla i pianeti
                {
                    p.Posizione.X += 4e8d * deltaMouseX;
                    p.Posizione.Y += 4e8d * deltaMouseY;
                }
                mouseX = MousePosition.X;//la pos. iniz. diventa la posizione attuale del mouse
                mouseY = MousePosition.Y;
            }
        }

        public float zoom = 1.0f;
        public float traslazioneX = 0, traslazioneY = 0;//traslazione in base allo zoom
        public Matrix transformMatrix;//per salva le trasformazioni in una matrice; https://stackoverflow.com/questions/20628979/actual-coordinate-after-scaletransfrom
        public PointF[] centri;//array di punti (in float)
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //mantiene la posizione dei controlli
            trackBar_speed.Location = new Point(ClientSize.Width - trackBar_speed.Width, ClientSize.Height - trackBar_speed.Height);
            lbl_speed.Location = new Point(ClientSize.Width - lbl_speed.Width -20, trackBar_speed.Location.Y - lbl_speed.Height - 4);
            lbl_fps.Location = new Point(ClientSize.Width - lbl_fps.Width - 20, 10);
            lbl_legenda.Location = new Point(8, ClientSize.Height - lbl_legenda.Height - 6);
            //

            Graphics g = CreateGraphics();
            g.ScaleTransform(zoom, zoom);//cambia lo zoom
            g.TranslateTransform(traslazioneX, traslazioneY);//trasla in base allo zoom
            transformMatrix = g.Transform;//salva le trasformazioni in una matrice

            centri = new PointF[planetario.Pianeti.Count];//crea l'array grande quanto il numero di pianeti presenti
            for (int i = 0; i < centri.Length; i++)//disegna tutti i pianeti/stelle
            {
                float xc = (float)Math.Round(planetario.Pianeti[i].Posizione.X / 2e8);//x del centro del pianeta
                float yc = Height - (float)Math.Round(planetario.Pianeti[i].Posizione.Y / 2e8);//y del centro del pianeta
                centri[i] = new PointF(xc, yc);//tutti i centri vengono salvati in un array che servirà dopo
                float r = (float)(planetario.Pianeti[i].Raggio / 5e6);//raggio
                if (r > 6)
                {
                    float x = xc - r / 2;
                    float y = yc - r / 2;
                    g.FillEllipse(new SolidBrush(planetario.Pianeti[i].Colore), x, y, r, r);
                }
                else
                {
                    float x = xc - 3;//r=6, r/2=3
                    float y = yc - 3;
                    g.FillEllipse(new SolidBrush(planetario.Pianeti[i].Colore), x, y, 6, 6);
                }
            }
        }
        #endregion
        
        #region InformazioniPianeta
        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            //se il click avviene dove si trova lo slider lo attiva, se no lo disattiva
            if (e.X > trackBar_speed.Location.X && e.Y > trackBar_speed.Location.Y)
            {
                trackBar_speed.Enabled = true;
            }
            else
            {
                trackBar_speed.Enabled = false;
            }

            if(centri.Length > 0)
            {
                //traasforma i punti (centri dei pianeti) con la stessa trasformazione avvenuta al form usando la matrice salvata prima
                transformMatrix.TransformPoints(centri);
            }
            for (int i = 0; i < centri.Length; i++)
            {
                int r = (int)(planetario.Pianeti[i].Raggio / 5e6 * zoom);//raggio
                if (r > 6 && DentroCerchio((int)centri[i].X, (int)centri[i].Y, r, e.X, e.Y))
                {//controlla se il click è avvenuto dentro un pianeta
                    pianetaSelezionato = planetario.Pianeti[i];
                }
                else if (DentroCerchio((int)centri[i].X, (int)centri[i].Y, 6, e.X, e.Y))//r=6
                {
                    pianetaSelezionato = planetario.Pianeti[i];
                }
            }

            if (pianetaSelezionato != null)
            {
                label.Text = InformazioniPianeta(pianetaSelezionato);//stampa le informazioni del pianeta nella label in alto a sinistra
            }
        }

        public static bool DentroCerchio(int xc, int yc, int r, int x, int y)//controlla se la posizione (x;y) è dentro il cerchio
        {
            return (xc - x) * (xc - x) + (yc - y) * (yc - y) <= r * r;
        }

        public string InformazioniPianeta(Pianeta p)//stampa le informazioni del pianeta
        {//(per adam) guardare Iformattable
            return p.ToString("FULL");
        }
        #endregion
        
        #region pulsanti (tastiera)
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            //esce dalla simulazione per tornare al form principale
            if(e.KeyCode == Keys.Escape)
            {
                Owner.Visible = true;//Owner è form1, lo rende visibile
                this.Close();//chiude questo form
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
            if (e.KeyCode == Keys.Right)//avanti 20 tick
            {
                planetario.DeltaT = 20 * planetario.DeltaT;
                timer1_Tick(sender, e);//richiama l'evento tick del timer
                planetario.DeltaT = planetario.DeltaT / 20;
            }
            if (e.KeyCode == Keys.Left)//indietro 20 tick
            {
                planetario.DeltaT = -20 * planetario.DeltaT;
                timer1_Tick(sender, e);
                planetario.DeltaT = -planetario.DeltaT / 20;
            }
            if (e.KeyCode == Keys.OemPeriod && timer1.Enabled == false)//avanti 1 tick [.]
            {
                timer1_Tick(sender, e);
            }
            if (e.KeyCode == Keys.Oemcomma && timer1.Enabled == false)//indietro 1 tick [,]
            {
                planetario.DeltaT = -planetario.DeltaT;//inverte deltaT
                timer1_Tick(sender, e);
                planetario.DeltaT = -planetario.DeltaT;//reinverte deltaT (torna normale)
            }
        }
        #endregion
        
        #region spostamento
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                Cursor = Cursors.NoMove2D;//cambia la forma del cursore
                mouseX = MousePosition.X;//posizione iniziale del mouse
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
        
        #region zoom
        //algoritmo di zoom: https://stackoverflow.com/questions/37262282/zooming-graphics-based-on-current-mouse-position
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
    }
}
//non importante:
//else if (planetario.Pianeti[i].Nome == "Luna")
//{
//    float x = xc - 1;
//    float y = yc - 1;
//    g.FillEllipse(new SolidBrush(planetario.Pianeti[i].Colore), x, y, 2, 2);
//}