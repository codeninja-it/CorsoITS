namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            double valore = (double)(numPeso.Value / (numAltezza.Value * numAltezza.Value));

            string stato = "";
            if (valore < 16)
            {
                stato = "grave magrezza";
            } else if (valore < 18.5) {
                stato = "sottopeso";
            } else if (valore < 24.9)
            {
                stato = "normopeso";
            } else if (valore < 29.9)
            {
                stato = "sovrappeso";
            } else if (valore < 34.9)
            {
                stato = "obeso";
            } else
            {
                stato = "obeso grave";
            }

            lblRisultato.Text = $"il tuo BMI è pari a {valore:N2}, questo vuol dire che sei {stato}!";
        }
    }
}