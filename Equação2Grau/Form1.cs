namespace Equação2Grau
{
    public partial class Form1 : Form
    {
        bool haveErrors = false;

        public Form1() => InitializeComponent();

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            haveErrors = false;
            ValidEmptyTextBoxes();

            double a = ValidComponent(TxtA.Text.Replace(".", ","));
            double b = ValidComponent(TxtB.Text.Replace(".", ","));
            double c = ValidComponent(TxtC.Text.Replace(".", ","));
            
            if (a == 0)
            {
                MessageBox.Show("O valor de A não pode ser 0!!!", "Atenção", MessageBoxButtons.OK);
                haveErrors = true;
            }

            if (haveErrors)
                return;

            double rootDelt = Math.Sqrt(CalculateDelt(a, b, c));

            if (haveErrors)
                return;

            double doubleA = a * 2;

            double xOne = CalculateX(b, rootDelt, doubleA, "positive");
            double xTwo = CalculateX(b, rootDelt, doubleA, "negative");

            MessageBox.Show("O valor de X¹ é: " + xOne + " e o valor de x² é: " + xTwo, "Resultado", MessageBoxButtons.OK);
        }

        private double CalculateDelt(double varA, double varB, double varC)
        {
            double squareB = varB * varB;

            double delt = squareB - 4 * varA * varC;

            if (delt < 0)
            {
                MessageBox.Show("Valor de delta não pode ser negativo!!!", "Atenção", MessageBoxButtons.OK);
                haveErrors = true;
            }

            return delt;
        }

        private static double CalculateX(double varB, double delt, double varA, string operation)
        {
            double up = 0;
            if (operation == "positive")
            {
                up = -varB + delt;
            }
            else if (operation == "negative")
            {
                up = -varB - delt;
            }
            return up / varA;
        }

        private double ValidComponent(string component)
        {
            bool isError = false;
            foreach (var item in component)
            {
                string charter = item.ToString();
                if (!charter.All(char.IsDigit))
                {
                    if (charter != "-" && charter != ",")
                        isError = true;
                }
            }

            if (isError)
            {
                MessageBox.Show("O valor: " + component + " é inválido!!!", "Atenção", MessageBoxButtons.OK);
                haveErrors = true;
                return 0;
            }

            return Convert.ToDouble(component);
        }

        private void ValidEmptyTextBoxes()
        {
            if (TxtA.Text == "")
                TxtA.Text = "0";

            if (TxtB.Text == "")
                TxtB.Text = "0";

            if (TxtC.Text == "")
                TxtC.Text = "0";
        }        
    }
}