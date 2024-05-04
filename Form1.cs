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
            //Cria variável que guarda o número de animais 
            decimal QtdAnimais = NumAnimais.Value;

            //Cria variável que guarda a quantidade média de ração
            decimal QtdRacao = NumMedRacao.Value;

            //Cria variável que guarda o número de dias
            decimal Dias = NumDias.Value;

            //Cria variável que gauarda o resultado do cálculo da quantidade total de ração
            decimal racao = (QtdAnimais * QtdRacao) * Dias;

            //Mostra o resultado para o usuário
            Resultado.Text = racao.ToString("N2") + "Kg";

        }
    }
}