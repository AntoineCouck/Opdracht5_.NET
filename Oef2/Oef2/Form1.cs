using System;
using System.Windows.Forms;

namespace Oef2
{
    public partial class Container : Form
    {
        Gemiddelde app = new Gemiddelde();

        public Container()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.IsMdiContainer = true;
            app.MdiParent = this;
            app.Show();
        }
    }
}
