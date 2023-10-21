using System;
using System.Windows.Forms;

namespace Seminarska
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se dodeluvaat vrednostite vneseni za a,b i c vo promenlivi za polesno rabotenje
            string A = X2InputBox.Text;
            string B = XInputBox.Text;
            string C = NoXInputBox.Text;

            //Pomosni promenlivi za proverka dali vrednostite se broevi
            bool isNumbera = double.TryParse(A, out double a);
            bool isNumberb = double.TryParse(B, out double b);
            bool isNumberc = double.TryParse(C, out double c);

            //Se proveruva dali ima ostaveno prazno pole
            if (A == "" | B == "" | C == "")
            {
                MessageBox.Show("Вредностите за a, b и c се задолжителни");
                return;
            }

            //Se proveruva dali vnesenite vrednosti se broevi
            if (isNumbera == false || isNumberb == false || isNumberc == false)
            {
                MessageBox.Show("Вредностите треба да бидат броеви");
                return;
            }

            //Se proveruva dali vrednosta za a e razlicna od 0
            if (a == 0)
            {
                MessageBox.Show("Внесената вредност за а мора да е различна од 0");
            }

            //Proveruva dali vnesenite broevi se vo opsegot
            if (!(IsInRange(a, b, c)))
            {
                return;
            }


            if ((Math.Pow(b, 2) - (4 * a * c)) > 0)
            {
                //Se presmetuva vrednosta za resenijata koga D>0
                double v = ((double)(-b + Math.Sqrt(((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a));
                X1Answer.Text = v.ToString("#0.000"); //Resenieto se ogranicuva na 5 decimali
                double v1 = ((double)(-b - (Math.Sqrt(((Math.Pow(b, 2)) - (4 * a * c))))) / (2 * a));
                X2Answer.Text = v1.ToString("#0.000");

                //Se krie imaginarniot del bidejki vo ovoj slucaj ne postoi
                X1ImaginaryAnswer.Visible = false;
                X2ImaginaryAnswer.Visible = false;
                label5.Visible = false;
                label6.Visible = false;

            }
            else if ((Math.Pow(b, 2) - (4 * a * c)) < 0)
            {
                //Se presmetuva vrednosta za resenijata koga D<0
                double v = ((double)(-b / (2 * a)));
                X1Answer.Text = v.ToString("#0.000");
                X2Answer.Text = v.ToString("#0.000");
                double v1 = ((double)(Math.Sqrt(-((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a));
                X1ImaginaryAnswer.Text = v1.ToString("#0.000");
                double v2 = (double)(-((Math.Sqrt(-((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a)));
                X2ImaginaryAnswer.Text = v2.ToString("#0.000");
            }
            else
            {
                //Se presmetuva vrednosta za resenijata(resenieto) koga D=0
                double v = ((double)(-b / (2 * a)));
                X1Answer.Text = v.ToString("#0.000");
                X2Answer.Text = v.ToString("#0.000");

                //Se krie imaginarniot del bidejki vo ovoj slucaj ne postoi
                X1ImaginaryAnswer.Visible = false;
                X2ImaginaryAnswer.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //So pritiskanje na kopceto IZBRISI se brisat vrednostite koi se vneseni
            //i vrednostite koi se prikazani za resenija na ravenkata
            this.X2InputBox.Text = String.Empty;
            this.XInputBox.Text = String.Empty;
            this.NoXInputBox.Text = String.Empty;
            this.X1Answer.Text = String.Empty;
            this.X2Answer.Text = String.Empty;
            this.X1ImaginaryAnswer.Text = String.Empty;
            this.X2ImaginaryAnswer.Text = String.Empty;
            //Po brisenje na vrednostite, vidlivosta na imaginarniot del se vraka
            label5.Visible = true;
            label6.Visible = true;
            X1ImaginaryAnswer.Visible = true;
            X2ImaginaryAnswer.Visible = true;
        }

        private void X1ImaginaryAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Калкулатор_Load(object sender, EventArgs e)
        {

        }

        private void X2InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NoXInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void XInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Metod za proverka dali brojot e vo opsegot
        private bool IsInRange(double a, double b, double c)
        {
            if (a > 999 || b > 999 || c > 999 || a < -999 || b < -999 || c < -999)
            {
                MessageBox.Show("Вредностите мора да бидат во дадениот опсег");
                return false;
            }
            return true;
        }
    }
}
