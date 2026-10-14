using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LAHLOUH_MohamedElGhali
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cacher le resaisissemnt initialement (va apparaite dans le cas echeant)
            groupBox3.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
             
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ValideButton_Click(object sender, EventArgs e)
        {
            



        }

        private void DureenumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void CreditBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ValideButton_Click_1(object sender, EventArgs e)
        {
            // A remplir tous les champs
            if (string.IsNullOrWhiteSpace(CreditBox.Text) || string.IsNullOrWhiteSpace(TauxBox.Text) || string.IsNullOrWhiteSpace(DureenumericUpDown.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gestion des exceptions
            try
            {
                double C = double.Parse(CreditBox.Text);
                double t = double.Parse(TauxBox.Text) / 100;
                int n = int.Parse(DureenumericUpDown.Text);
                double salaire = double.Parse(SalaireBox.Text);

                // Vérification de la durée (saisi en mois ou en annee ?
                if (enannee.Checked)
                    n *= 12; // Conversion en mois si on a saisi l'annee

                // Calcul de la mensualité
                double tauxMensuel = t / 12;
                double m = (C * tauxMensuel) / (1 - Math.Pow(1 + tauxMensuel, -n));


                // Vérification de l'éligibilité à traver d'un message affiché
                if (salaire / 4 >= m)
                {
                    MessageBox.Show("Vous êtes éligible au crédit", "Éligibilité", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox3.Visible = false;
                }
                else
                {
                    MessageBox.Show("Vous n'êtes pas éligible au crédit", "Éligibilité", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    groupBox3.Visible = true; // Apparition du groupeBox à remplir 
                }
            }

            // le cas où on a pas saisi correctement les champs voulus
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de saisie : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValideButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(creditBox2.Text) || string.IsNullOrWhiteSpace(ansnumericUpDown1.Text) || string.IsNullOrWhiteSpace(moisnumericUpDown1.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double C = double.Parse(creditBox2.Text);
                int year = int.Parse(ansnumericUpDown1.Text);
                int month = int.Parse(moisnumericUpDown1.Text);

                // Le salaire et le taux restent fixes
                double t = double.Parse(TauxBox.Text) / 100;
                double salaire = double.Parse(SalaireBox.Text);

                year *= 12;
                

                // Calcul de la mensualité
                double tauxMensuel = t / 12;
                double m = (C * tauxMensuel) / (1 - Math.Pow(1 + tauxMensuel, - (month +year)));


                // ReVérification de l'éligibilité
                if (salaire / 4 >= m)
                {
                    MessageBox.Show("Vous êtes éligible au crédit", "Éligibilité", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox3.Visible = false; // Ne pas afficher les détails
                }
                else
                {
                    MessageBox.Show("Vous n'êtes pas éligible au crédit", "Éligibilité", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    groupBox3.Visible = true; // Afficher plus d'infos si inéligible
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de saisie : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
