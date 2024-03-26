using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulatore_Pianeti
{
    public class Vettore : IFormattable
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vettore() { }
        public Vettore(double x, double y)
        {
            X = x; Y = y;
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
            if (string.IsNullOrEmpty(format)) format = "G";
            if (provider == null) provider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "G":
                case "E3":
                    return $"{X:0.000E0};{Y:0.000E0}";
                case "E4":
                    return $"{X:0.0000E0};{Y:0.0000E0}";
                default:
                    throw new FormatException(string.Format("The {0} format string is not supported.", format));
            }
        }

        public static Vettore Parse(string str)
        {
            string[] substr = str.Split(';');
            return new Vettore(double.Parse(substr[0]), double.Parse(substr[1]));
        }

        public static bool TryParse(string str, out Vettore v)
        {
            string[] substr = str.Split(';');
            if (substr.Length > 1 && double.TryParse(substr[0], out double x) && double.TryParse(substr[1], out double y))
            {
                v = new Vettore(x, y);
                return true;
            }
            else
            {
                v = null;
                return false;
            }
        }

        public double Modulo()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public static Vettore operator +(Vettore v)
        {
            return v;
        }

        public static Vettore operator -(Vettore v)
        {
            return new Vettore(-v.X, -v.Y);
        }

        public static Vettore operator +(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vettore operator -(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vettore operator *(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X * v2.X, v1.Y * v2.Y);
        }
        public static Vettore operator *(Vettore v1, double s)
        {
            return new Vettore(v1.X * s, v1.Y * s);
        }
        public static Vettore operator *(double s, Vettore v2)
        {
            return new Vettore(s * v2.X, s * v2.Y);
        }

        public static Vettore operator /(Vettore v1, double s)
        {
            return new Vettore(v1.X / s, v1.Y / s);
        }

        public Vettore Versore()
        {
            return this / Modulo();
        }

        public static bool operator ==(Vettore v1, Vettore v2)
        {
            if (ReferenceEquals(v1, null))
            {
                return ReferenceEquals(v2, null);
            }
            else if (ReferenceEquals(v2, null))
            {
                return false;
            }
            else
            {
                return v1.X == v2.X && v1.Y == v2.Y;
            }
        }

        public static bool operator !=(Vettore v1, Vettore v2)
        {
            return !(v1 == v2);
        }
    }
}
