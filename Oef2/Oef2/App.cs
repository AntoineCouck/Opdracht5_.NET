using System;
using System.Windows.Forms;

namespace Oef2
{
    public partial class Gemiddelde : Form
    {



        public Gemiddelde()
        {
            InitializeComponent();
        }

        private void NieuwGetalButton_Click(object sender, EventArgs e)
        {

            UserDialog dialogWindow = new UserDialog();
            dialogWindow.ShowDialog();

            if (dialogWindow.DialogResult == DialogResult.OK)
            {
                AddNumber(dialogWindow.number);
                CalculateAVG();
                dialogWindow.Dispose();
            }
        }


        public void AddNumber(double number)
        {
            GetallenLijst.Items.Add(number);

        }


        public void CalculateAVG()
        {

            double total = 0;


            for (int i = 0; i < GetallenLijst.Items.Count; i++)
            {
                total = total + double.Parse(GetallenLijst.Items[i].ToString());
            }

            total = (total / GetallenLijst.Items.Count);


            gem.Text = total.ToString();

        }





    }
}
