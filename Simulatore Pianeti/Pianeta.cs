using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulatore_Pianeti
{
    public class Pianeta : IFormattable
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

        //Il prof ha suggerito di usare Iformattable: https://learn.microsoft.com/en-us/dotnet/api/system.iformattable?view=net-8.0
        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(format)) format = "G";
            if (provider == null) provider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "G":
                case "BASIC":
                    return $"{Nome} ({Colore.Name}); Massa: {Massa:0.0000E0}; Posizione in.: {Posizione:E3}; Velocità in. {Velocità:E3}";
                case "FULL":
                    return $"Pianeta: {Nome} ({Colore.Name})\nMassa: {Massa}\nPosizione: {Posizione:E4}\nVelocità: {Velocità:E4}\nRaggio: {Raggio:0.0000E0}";
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));
            }
        }
    }
}
