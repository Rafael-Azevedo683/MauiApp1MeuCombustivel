
namespace MauiApp1MeuCombustivel
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string marcaVeiculo = txt_marcaVeiculo.Text;
                string modeloVeiculo = txt_modeloVeiculo.Text;

                // Verificação simples: Se o preço do etanol for até 70% do valor da gasolina, compensa etanol
                double relacao = etanol / gasolina;

                string msg = "";
                

                if (etanol <= (gasolina * 0.7) )
                        {
                            msg = $"O etanol está compensando para o seu {marcaVeiculo} {modeloVeiculo}.";
                        } else
                        {
                         msg = $"A gasolina está compensando mais para o seu {marcaVeiculo} {modeloVeiculo}.";
                        }
                // Exibindo a mensagem de resultado
                DisplayAlert("Calculado", msg, "OK");

            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }

        } // Fecha Método
    } // Fecha Class

} // Fecha namespace
