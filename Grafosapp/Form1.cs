using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Grafosapp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> grafo = new Dictionary<string, List<string>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            string nodo = txtNodo.Text.Trim();
            if (!string.IsNullOrEmpty(nodo) && !grafo.ContainsKey(nodo))
            {
                grafo[nodo] = new List<string>();
                MessageBox.Show($"Nodo '{nodo}' agregado.");
                txtNodo.Clear();
            }
            else
            {
                MessageBox.Show("El nodo ya existe o está vacío.");
            }
        }

        private void btnAgregarArista_Click(object sender, EventArgs e)
        {
            string origen = txtOrigen.Text.Trim();
            string destino = txtDestino.Text.Trim();

            if (grafo.ContainsKey(origen) && grafo.ContainsKey(destino))
            {
                grafo[origen].Add(destino);
                MessageBox.Show($"Arista agregada: {origen} -> {destino}");
                txtOrigen.Clear();
                txtDestino.Clear();
            }
            else
            {
                MessageBox.Show("Uno o ambos nodos no existen.");
            }
        }

        private void btnMostrarGrafo_Click(object sender, EventArgs e)
        {
            lstAdyacencias.Items.Clear(); 
            foreach (var nodo in grafo)
            {
                string adyacencias = string.Join(", ", nodo.Value);
                lstAdyacencias.Items.Add($"{nodo.Key}: {adyacencias}"); 
            }
        }
    }
}
