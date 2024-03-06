using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vettori;

namespace Simulatore_Pianeti
{
    internal class Pianeta
    {
        public Color Colore { get; set; }
        public double Massa { get; set; }
        public double Raggio { get; set; }
        public Vettore Posizione { get; set; }
        public Vettore Velocità { get; set; }
        public Vettore Forza { get; set; }//che agisce sul corpo
        public Vettore Accelerazione { get; set; }
        public Pianeta(Color c, double r, double m, Vettore pos, Vettore v)
        {
            Colore = c;
            Raggio = r;
            Massa = m;
            Posizione = pos;
            Velocità = v;
        }
        public Pianeta(Color c, double m, Vettore pos, Vettore v)
        {
            Colore = c;
            Raggio = 0;
            Massa = m;
            Posizione = pos;
            Velocità = v;
        }
        public Pianeta(double r, double m, Vettore pos, Vettore v)
        {
            Colore = Color.White;
            Raggio = r;
            Massa = m;
            Posizione = pos;
            Velocità = v;
        }
        public Pianeta(double m, Vettore pos, Vettore v)
        {
            Colore = Color.White;
            Raggio = 0;
            Massa = m;
            Posizione = pos;
            Velocità = v;
        }
    }
}
