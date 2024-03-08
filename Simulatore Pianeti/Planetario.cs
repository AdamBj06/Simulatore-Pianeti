using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulatore_Pianeti
{
    public class Planetario
    {
        public const double G = 6.673e-11d;
        public double DeltaT { get; set; }
        public List<Pianeta> Pianeti { get; set; }
        public void Move()
        {
            foreach (Pianeta p in Pianeti)
            {
                p.Forza = new Vettore(0, 0);

                foreach (Pianeta p2 in Pianeti)
                {
                    if (p != p2)
                    {
                        Vettore r = p2.Posizione - p.Posizione;
                        p.Forza += G * p.Massa * p2.Massa / (r.Modulo() * r.Modulo()) * r.Versore();//forza gravitazionale
                    }
                }

                p.Accelerazione = p.Forza / p.Massa;
                p.Posizione += p.Velocità * DeltaT + 0.5d * p.Accelerazione * (DeltaT * DeltaT);//legge oraria del moto uniformemente accelerato
                p.Velocità += p.Accelerazione * DeltaT;
            }
        }
    }
}
