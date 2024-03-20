using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulatore_Pianeti
{
    public class Pianeta
    {
        public String Nome { get; set; }
        public Color Colore { get; set; }
        public double Massa { get; set; }//in kilogrammi
        public double Raggio { get; set; }//in metri
        public Vettore Posizione { get; set; }//in metri
        public Vettore Velocità { get; set; }//in metri al secondo
        public Vettore Forza { get; set; }//che agisce sul corpo
        public Vettore Accelerazione { get; set; }

        public Pianeta(string n, Color c, double r, double m, Vettore pos, Vettore v)
        {
            Nome = n;
            Colore = c;
            Raggio = r;
            Massa = m;
            Posizione = pos;
            Velocità = v;
        }

        public override string ToString()//(per adam) guardare Iformattable
        {
            return string.Format("{0} ({1}): m: {2}kg; pos.in.: {3}; vel.in.: {4}",
                                 Nome, Colore.Name, Massa.ToString("0.0000E0"), Posizione.ToString("0.0000E0"), Velocità .ToString("0.0000E0"));
        }//$"Massa: {Massa:0.0000E0}; Posizione in.: {Posizione:0.0000E0}; Velocità in. {Velocità:0.0000E0}"
    }
}
