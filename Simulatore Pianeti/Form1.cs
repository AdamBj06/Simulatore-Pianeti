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
        public Planetario planetario = new Planetario();
        public Form1()
        {
            InitializeComponent();
            InitializeColorsComboBox();
            planetario.Pianeti = new List<Pianeta>();
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
            Pianeta pianeta = new Pianeta(Color.FromName(Colori.SelectedItem.ToString()), double.Parse(Raggio.Text), double.Parse(Massa.Text), Vettore.Parse(vPos.Text), Vettore.Parse(vVel.Text));
            planetario.Pianeti.Add(pianeta);
            lst_Pianeti.Items.Add(pianeta);

            Raggio.Clear();
            vPos.Clear();
            vVel.Clear();
            Massa.Clear();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            lst_Pianeti.Items.Remove(lst_Pianeti.SelectedItem);

        }

        private void Play_Click(object sender, EventArgs e)
        {

        }
    }
}
