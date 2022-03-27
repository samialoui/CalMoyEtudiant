using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalMoyEtudiant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double noteDs = double.Parse(textDS.Text);
            double noteTp = double.Parse(textTp.Text);
            double noteEx = double.Parse(textEx.Text);
            double Moyenne = CalculMoy(noteDs, noteTp, noteEx);
            textMoy.Text = Moyenne.ToString();
        }

        public double CalculMoy(double noteDs,double noteTP, double noteEx)
        {
            double Moyenne = 0;
            Moyenne = (noteDs * 0.3) + (noteTP * 0.2) + (noteEx * 0.5);
            return Moyenne;
        }

        private void textMoy_TextChanged(object sender, EventArgs e)
        {
            if (textMoy.Text != "") btnCalcul.Enabled = false;
            else btnCalcul.Enabled = true;
            btnAjouter.Enabled = true;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        { 
            string values = textNom.Text.Trim() + "                    " + textMoy.Text.Trim();
            listEtudiant.Items.Add(values);
            Vider();
            if(listEtudiant.Items.Count != 0)
            {
                btnCalcul.Enabled = false;
                btnAjouter.Enabled = false;
            }
        }

        private void listEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listEtudiant.SelectedIndex != -1)
            {
                btnSupprimer.Enabled = true;
            }
            else
            {
                btnSupprimer.Enabled = false;
            }
        }

        public void Vider()
        {
            textNom.Clear();
            textDS.Clear();
            textTp.Clear();
            textEx.Clear();
            textMoy.Clear();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            listEtudiant.Items.RemoveAt(listEtudiant.SelectedIndex);
            btnCalcul.Enabled = true;
        }
    }
}
