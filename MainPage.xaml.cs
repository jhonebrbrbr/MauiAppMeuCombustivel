namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

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

                string msg = "";

                if (etanol <= gasolina * 0.7)
                {
                    msg = "o etanol está compensando";

                } else if (etanol == gasolina)
                {
                    msg = "TANTO FAZ É VOCÊ QUEM DETERMINA";
                }
                else
                {
                    msg = "o etanol não está compensando";
                }

                DisplayAlertAsync("calculado", msg, "ok");

            }
            catch (Exception ex)
            {
                DisplayAlertAsync("Ops", ex.Message, "Fechar");
            }
        }

        /*private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }*/
    }
}
