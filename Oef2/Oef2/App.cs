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
                VoegToeAanLijst(dialogWindow.number);
                berekenGemiddelde();
                dialogWindow.Dispose();
            }
        }


        public void VoegToeAanLijst(double number)
        {
            GetallenVerzameling.Items.Add(number);

        }


        public void berekenGemiddelde()
        {

            double total = 0;


            for (int i = 0; i < GetallenVerzameling.Items.Count; i++)
            {
                total = total + double.Parse(GetallenVerzameling.Items[i].ToString());
            }

            total = (total / GetallenVerzameling.Items.Count);


            gem.Text = total.ToString();

        }





    }
}
