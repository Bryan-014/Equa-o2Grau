namespace Equação2Grau
{
    public partial class Form1 : Form
    {
        bool errors = false;

        public Form1() => InitializeComponent();

        private void btCalcular_Click(object sender, EventArgs e)
        {
            errors = false;
            ValidEmptyTextBoxes();

            double a = ValidComponents(txtA.Text);
            double b = ValidComponents(txtB.Text);
            double c = ValidComponents(txtC.Text);
            
            if (a == 0)
            {
                MessageBox.Show("O valor de A não pode ser 0!!!", "Atenção", MessageBoxButtons.OK);
                errors = true;
            }

            if (errors)
                return;

            double rootDelt = Math.Sqrt(CalculateDelt(a, b, c));

            if (errors)
                return;

            double doubleA = a * 2;

            double xOne = CalculateXOne(b, rootDelt, doubleA);
            double xTwo = CalculateXTwo(b, rootDelt, doubleA);

            MessageBox.Show("O valor de X¹ é: " + xOne + " e o valor de x² é: " + xTwo, "Resultado", MessageBoxButtons.OK);
        }

        private double CalculateDelt(double varA, double varB, double varC)
        {
            double squareB = varB * varB;

            double x = squareB - 4 * varA * varC;

            if (x < 0)
            {
                MessageBox.Show("Valor de delta não pode ser negativo!!!", "Atenção", MessageBoxButtons.OK);
                errors = true;
            }

            return x;
        }

        private static double CalculateXOne(double varB, double delt, double varA)
        {
            double up = -varB + delt;

            return up / varA;
        }

        private static double CalculateXTwo(double varB, double delt, double varA)
        {
            double up = -varB - delt;

            return up / varA;
        }

        private double ValidComponents(string component)
        {
            bool isError = false;
            foreach (var item in component)
            {
                string charter = item.ToString();
                if (!charter.All(char.IsDigit))
                {
                    if (charter != "-" && charter != "," && charter != ".")
                        isError = true;
                }
            }

            if (isError)
            {
                MessageBox.Show(component + " é inválido!!!", "Atenção", MessageBoxButtons.OK);
                errors = true;
                return 0;
            }

            return Convert.ToDouble(component.Replace(".", ","));
        }

        private void ValidEmptyTextBoxes()
        {
            if (txtA.Text == "")
                txtA.Text = "0";

            if (txtB.Text == "")
                txtB.Text = "0";

            if (txtC.Text == "")
                txtC.Text = "0";
        }        
    }
}