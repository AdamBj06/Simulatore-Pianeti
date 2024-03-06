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

namespace Simulatore_Pianeti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Pianeti.Items.Add(new Pianeta(double.Parse(m.Text),Vettore.Parse(S.Text),Vettore.Parse(V.Text)));
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Pianeti.Items.Remove(Pianeti.SelectedItem);
        }

        private void S_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
