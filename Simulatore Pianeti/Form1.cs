using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vettori;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Simulatore_Pianeti
{
    public partial class Form1 : Form
    {
        private List<Pianeta> listPianeti = new List<Pianeta>();
        public Form1()
        {
            InitializeComponent();
            InitializeColorsComboBox();
        }

        private void InitializeColorsComboBox()
        {
            Colori.Text = "Scegli un colore";

            foreach (KnownColor knownColor in Enum.GetValues(typeof(KnownColor)))
            {
                Color color = Color.FromKnownColor(knownColor);
                if (!color.IsSystemColor)
                {
                    Colori.Items.Add(color.Name);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            listPianeti.Add(new Pianeta((Color)Colori.SelectedItem, double.Parse(Raggio.Text), double.Parse(Massa.Text), Vettore.Parse(vPos.Text), Vettore.Parse(vVel.Text)));
            Pianeti.Items.Add(Nome.Text);

            Nome.Clear();
            Raggio.Clear();
            vPos.Clear();
            vVel.Clear();
            Massa.Clear();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Pianeti.Items.Remove(Pianeti.SelectedItem);

        }

        private void Play_Click(object sender, EventArgs e)
        {

        }
    }
}
