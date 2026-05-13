namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);

            Modelo calculo = Processamento.Calcular(peso, altura);

            MessageBox.Show("Seu IMC: " + calculo.imc + "\n" + "Resultado: " + calculo.resultado);
        }
    }
}
