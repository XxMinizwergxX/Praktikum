using System.Windows.Forms.VisualStyles;

namespace Taschenrechner
{
    public partial class Taschenrechner : Form
    {
        double speicher = 0;
        string rechenoperator = "";

        public void test()
        {
            string text = textBox1.Text;
            if (text == "")
            {
                MessageBox.Show("Leeres Feld");
            }
            else
            {
                speicher = double.Parse(textBox1.Text);
                //Wert wegspeichern
            }
        }

        public Taschenrechner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void buttonAddieren_Click(object sender, EventArgs e)
        {
            //if speicher == ''; dann Nachricht leeres Feld ansonsten führe den Code unten aus
            string text = textBox1.Text;
            if (text == "")
            {
                MessageBox.Show("Leeres Feld");
            }
            else
            {
                speicher = double.Parse(textBox1.Text);
                //Wert wegspeichern
                speicher = double.Parse(textBox1.Text);
                // + als rechenoperator
                rechenoperator = "+";
                //Eingabe leeren
                textBox1.Text = "";
            }
        }

        private void buttonSubtrahieren_Click(object sender, EventArgs e)
        {
            test();
            //Wert wegspeichern
            //speicher = double.Parse(textBox1.Text);
            // + als rechenoperator
            rechenoperator = "-";
            //Eingabe leeren
            textBox1.Text = "";
        }

        private void buttonGleich_Click(object sender, EventArgs e)
        {
            double aktueller_wert = double.Parse(textBox1.Text);
            if (rechenoperator == "+")
            {
                double ergebnis = aktueller_wert + speicher;
                textBox1.Text = ergebnis.ToString();
            }
            {

                if (rechenoperator == "-")
                {
                    double ergebnis = speicher - aktueller_wert;
                    textBox1.Text = ergebnis.ToString();
                }
                {
                    if (rechenoperator == "*")
                    {
                        double ergebnis = speicher * aktueller_wert;
                        textBox1.Text = ergebnis.ToString();
                    }
                    {
                        if (rechenoperator == "/")
                        {
                            double ergebnis = speicher / aktueller_wert;
                            textBox1.Text = ergebnis.ToString();
                        }
                    }
                }
            }
        }

        private void buttonKomma_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            speicher = 0;
            rechenoperator = "";
        }

        private void buttonMultiplizieren_Click(object sender, EventArgs e)
        {
            test();
            //Wert wegspeichern
            //speicher = double.Parse(textBox1.Text);
            // + als rechenoperator
            rechenoperator = "*";
            //Eingabe leeren
            textBox1.Text = "";
        }

        private void buttonDividieren_Click(object sender, EventArgs e)
        {
            test();
            //Wert wegspeichern
            //speicher = double.Parse(textBox1.Text);
            // + als rechenoperator
            rechenoperator = "/";
            //Eingabe leeren
            textBox1.Text = "";
        }

        private void buttonProzent_Click(object sender, EventArgs e)
        {
            test();
            //speicher = double.Parse(textBox1.Text);
            speicher = speicher / 100;
            textBox1.Text = speicher.ToString();
        }

        private void buttonVorzeichen_Click(object sender, EventArgs e)
        {
            test();
            //speicher = double.Parse(textBox1.Text);
            speicher = -speicher;
            textBox1.Text = speicher.ToString();
        }

        private void Taschenrechner_Load(object sender, EventArgs e)
        {

        }
    }
}
