

namespace Oef3
{
    public partial class ColorDialog : Form
    {

        ///*    private int */
        //CurrentBox = Form1.lijstTextBoxes.IndexOf(Form1.CurrentTextBox);


        public ColorDialog()
        {
            InitializeComponent();
        }

        public void ColorDialog_Load(object sender , EventArgs e )
        {
            numericUpDown1.Value = Form1.LijstKleur_R[Form1.CurrentBox];
            numericUpDown2.Value = Form1.LijstKleur_G[Form1.CurrentBox];
            numericUpDown3.Value = Form1.LijstKleur_B[Form1.CurrentBox];
            numericUpDown4.Value = Form1.LijstKleur_A[Form1.CurrentBox];
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //// R
            Form1.LijstKleur_R[Form1.CurrentBox] = (int)numericUpDown1.Value;
            Form1.CurrentTextBox.BackColor = Color.FromArgb(Form1.LijstKleur_A[Form1.CurrentBox], Form1.LijstKleur_R[Form1.CurrentBox], Form1.LijstKleur_G[Form1.CurrentBox], Form1.LijstKleur_B[Form1.CurrentBox]);

           

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Form1.LijstKleur_G[Form1.CurrentBox] = (int)numericUpDown2.Value;
            Form1.CurrentTextBox.BackColor = Color.FromArgb(Form1.LijstKleur_A[Form1.CurrentBox], Form1.LijstKleur_R[Form1.CurrentBox], Form1.LijstKleur_G[Form1.CurrentBox], Form1.LijstKleur_B[Form1.CurrentBox]);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Form1.LijstKleur_B[Form1.CurrentBox] = (int)numericUpDown3.Value;
            Form1.CurrentTextBox.BackColor = Color.FromArgb(Form1.LijstKleur_A[Form1.CurrentBox], Form1.LijstKleur_R[Form1.CurrentBox], Form1.LijstKleur_G[Form1.CurrentBox], Form1.LijstKleur_B[Form1.CurrentBox]);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Form1.LijstKleur_A[Form1.CurrentBox] = (int)numericUpDown4.Value;
            Form1.CurrentTextBox.BackColor = Color.FromArgb(Form1.LijstKleur_A[Form1.CurrentBox], Form1.LijstKleur_R[Form1.CurrentBox], Form1.LijstKleur_G[Form1.CurrentBox], Form1.LijstKleur_B[Form1.CurrentBox]);
        }
    }
}
