

namespace Oef3
{
    public partial class Form1 : Form

    {


        private int x = 0;

        private int y = 28;

        private int breedte = 0;

        private int hoogte = 0;

        public static int teller;

        public static int RijenTeller;

        public static int ColTeller;

        public static List<int> LijstKleur_R = new List<int>();
        public static List<int> LijstKleur_G = new List<int>();
        public static List<int> LijstKleur_B = new List<int>();
        public static List<int> LijstKleur_A = new List<int>();

        public static List<TextBox> lijstTextBoxes = new List<TextBox>();
        public static TextBox CurrentTextBox = new TextBox();
        public static int CurrentBox;

        private ColorDialog colorDialog1;

        public Form1()
        {
            InitializeComponent();
        }

        public void Afmeten()
        {
            int berekendeTeller = 1;
            

            if(teller == 1)
            {
                berekendeTeller = 1;

            } else if (teller >= 2 )
            {
                berekendeTeller = (int)Math.Ceiling(Math.Sqrt(teller));
            } 

            breedte = (this.Size.Width - 19 ) / berekendeTeller;
            hoogte = (this.Size.Height - 76 ) / berekendeTeller;

            if(ColTeller < berekendeTeller)
            {
                x = (this.Size.Width - 19) * RijenTeller / berekendeTeller;
                y = (this.Size.Height - 76) * ColTeller /  berekendeTeller + 28; 
            }

                ColTeller++;

            if(ColTeller == berekendeTeller)
            {
                RijenTeller++;
                ColTeller = 0;
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
            ColTeller = 0;
            RijenTeller = 0;
            for (int i = 0; i < teller; i++)
            {
                LijstKleur_A.Add(255);
                LijstKleur_R.Add(164);
                LijstKleur_G.Add(245);
                LijstKleur_B.Add(66);

                
                Afmeten();
                TextBox Rechthoek = new TextBox();
                Rechthoek.Multiline = true;
                Rechthoek.Location = new Point(x, y);
                Rechthoek.Size = new Size(breedte, hoogte);
                Rechthoek.BackColor = Color.FromArgb(LijstKleur_A[i], LijstKleur_R[i], LijstKleur_G[i] , LijstKleur_B[i]);
                Rechthoek.MouseHover += new EventHandler(TextBox_MouseHover);
                this.Controls.Add(Rechthoek);
                lijstTextBoxes.Add(Rechthoek);
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

            ColTeller = 0;
            RijenTeller = 0;

            for (int i = 0; i < teller; i++)
            {
                Afmeten();
                TextBox Rechthoek = new TextBox();
                Rechthoek.Multiline = true;
                Rechthoek.Location = new Point(x, y);
                Rechthoek.Size = new Size(breedte, hoogte);
                Rechthoek.BackColor = Color.FromArgb(LijstKleur_A[i], LijstKleur_R[i], LijstKleur_G[i], LijstKleur_B[i]);
                Rechthoek.MouseHover += new EventHandler(TextBox_MouseHover);
                this.Controls.Add(Rechthoek);
                lijstTextBoxes.Add(Rechthoek);
            }

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int counted = teller;
            for (int i = 0; i < teller; i++)
            {
                this.Controls.RemoveAt(counted);
                counted--;
            }
            
            ColTeller = 0;
            RijenTeller = 0;
            for (int i = 0; i < teller; i++)
            {
                Afmeten();
                TextBox Rechthoek = new TextBox();
                Rechthoek.Multiline = true;
                Rechthoek.Location = new Point(x, y);
                Rechthoek.Size = new Size(breedte, hoogte);
                Rechthoek.BackColor = Color.FromArgb(LijstKleur_A[i], LijstKleur_R[i], LijstKleur_G[i], LijstKleur_B[i]);
                Rechthoek.MouseHover += new EventHandler(TextBox_MouseHover);
                this.Controls.Add(Rechthoek);
                lijstTextBoxes.Add(Rechthoek);
            }
        }

        public void TextBox_MouseHover(object sender , EventArgs e)
        {

            if(colorDialog1 != null)
            {
                colorDialog1.Visible = false;
            }

             CurrentTextBox = (TextBox)sender;
             ColorDialog colorDialog = new ColorDialog();
            colorDialog.Location = new Point(CurrentTextBox.Location.X + this.Location.X, CurrentTextBox.Location.Y + this.Location.Y); 
             colorDialog.Visible = true;
             colorDialog1 = colorDialog;
             CurrentBox = lijstTextBoxes.IndexOf(CurrentTextBox);

    }

        
    }
}