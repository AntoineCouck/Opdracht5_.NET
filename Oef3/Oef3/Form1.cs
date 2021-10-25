namespace Oef3
{
    public partial class Form1 : Form
    {
        static int teller;

        private int breedte = 0;
        private int hoogte = 0;

        private int x = 0;
        private int y = 28;

        public Form1()
        {
            InitializeComponent();
        }

        public void Afmeten(int i)
        {
            if (teller == 1)
            {
                breedte = this.Size.Width - 19;
                hoogte = this.Size.Height - 76;
                x = 0;
                y = 28;
            }
            else if (teller == 2)
            {
                breedte = (this.Size.Width - 19) / 2;
                hoogte = this.Size.Height - 76;
                if (i == 0)
                {
                    x = 0;
                    y = 28;
                }
                else if (i == 1)
                {
                    x = breedte;
                    y = 28;
                }

            }
        }

        public void deleting(int i)
        {
            if (teller == 1)
            {
                breedte = this.Size.Width - 19;
                hoogte = this.Size.Height - 76;
                x = 0;
                y = 28;
            }
        }

        public void toevoegenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int counted = teller;
            for (int i = 0; i < teller; i++)
            {
                this.Controls.RemoveAt(counted);
                counted--;
            }
            teller++;
            for (int i = 0; i < teller; i++)
            {
                Afmeten(i);
                Button MyButton = new Button();
                MyButton.Location = new Point(x, y);
                MyButton.Size = new Size(breedte, hoogte);
                MyButton.BackColor = Color.Red;
                this.Controls.Add(MyButton);
            }



        }

        public void verwijderenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int afteller = teller;
            for (int i = 0; i < teller; i++)
            {
                this.Controls.RemoveAt(afteller);
                afteller--;
            }
            teller--;

            for (int i = 0; i < teller; i++)
            {
                Afmeten(i);
                Button MyButton = new Button();
                MyButton.Location = new Point(x, y);
                MyButton.Size = new Size(breedte, hoogte);
                MyButton.BackColor = Color.Red;
                this.Controls.Add(MyButton);
            }
        }

     
    }
}