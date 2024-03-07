using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulatore_Pianeti
{
    public partial class Form1 : Form
    {
        public static Planetario planetario;
        public Form1()
        {
            InitializeComponent();
            InitializeColorsComboBox();
            planetario = new Planetario();
            planetario.Pianeti = new List<Pianeta>();
        }

        private void InitializeColorsComboBox()//Carolin
        {
            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                Color color = Color.FromKnownColor(knownColor);
                if (!color.IsSystemColor)
                {
                    cmb_colore.Items.Add(color.Name);
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            double massa;
            Vettore posizione;
            Vettore velocità;
            double raggio;
            Color colore;

            if (txt_massa.Text != "" && txt_posizione.Text != "" && txt_velocità.Text != "")
            {
                massa = double.Parse(txt_massa.Text);
                posizione = Vettore.Parse(txt_posizione.Text);
                velocità = Vettore.Parse(txt_velocità.Text);
            }
            else
            {
                MessageBox.Show("Un pianeta deve avere come minimo una massa, una posizione iniziale e una velocità iniziale");
                return;
            }

            if(txt_raggio.Text != "")
            {
                raggio = double.Parse(txt_raggio.Text);
            }
            else
            {
                raggio = 0;
            }

            if(cmb_colore.Text != "")
            {
                colore = Color.FromName(cmb_colore.SelectedItem.ToString());
            }
            else
            {
                colore = Color.White;
            }

            Pianeta pianeta = new Pianeta(colore, raggio, massa, posizione, velocità);
            lst_Pianeti.Items.Add(pianeta);

            txt_raggio.Clear();
            txt_posizione.Clear();
            txt_velocità.Clear();
            txt_massa.Clear();
            cmb_colore.Text = "";
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            lst_Pianeti.Items.Remove(lst_Pianeti.SelectedItem);
        }

        private void Play_Click(object sender, EventArgs e)
        {
            foreach (Pianeta p in lst_Pianeti.Items)
            {
                planetario.Pianeti.Add(p);
            }

            Form2 Form2 = new Form2();
            this.Visible = false;
            Form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmb_esempi.SelectedIndex)
            {
                case 0:
                    lst_Pianeti.Items.Add(new Pianeta(Color.Yellow, 7e8, 2e30, new Vettore(1e9 * (Width / 3), 1e9d * (Height / 2)), new Vettore(0, 0)));
                    lst_Pianeti.Items.Add(new Pianeta(Color.Cyan, 6.378e6, 6e24, new Vettore(1e9 * (Width / 3) + 1.49597870e11d, 1e9d * (Height / 2)), new Vettore(0, 2.972222e4d)));
                    lst_Pianeti.Items.Add(new Pianeta(Color.Red, 3.3895e6, 6.39e23, new Vettore(1e9 * (Width / 3) + 2.28e11d, 1e9d * (Height / 2)), new Vettore(0, 2.413e4d)));
                    break;
                default:
                    break;
            }
        }
    }
}
