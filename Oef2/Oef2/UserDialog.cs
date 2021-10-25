using System;
using System.Windows.Forms;

namespace Oef2
{

    public partial class UserDialog : Form
    {
        Gemiddelde gemiddelde = new Gemiddelde();

        public double number { get; set; }

        public UserDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.number = double.Parse(textBox1.Text);


        }

    }
}
