namespace ConsumoRacaoApp
{
    public partial class frmCalculoRacao : Form
    {
        public frmCalculoRacao()
        {
            InitializeComponent();
        }

        private void BtnCalculo_Click(object sender, EventArgs e)
        {
            //Cria vari�vel que guarda o n�mero de animais 
            decimal QtdAnimais = NumAnimais.Value;

            //Cria vari�vel que guarda a quantidade m�dia de ra��o
            decimal QtdRacao = NumMedRacao.Value;

            //Cria vari�vel que guarda o n�mero de dias
            decimal Dias = NumDias.Value;

            //Cria vari�vel que gauarda o resultado do c�lculo da quantidade total de ra��o
            decimal racao = (QtdAnimais * QtdRacao) * Dias;

            //Mostra o resultado para o usu�rio
            Resultado.Text = racao.ToString("N2") + "Kg";

        }
    }
}