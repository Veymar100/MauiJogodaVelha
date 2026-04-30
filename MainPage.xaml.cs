using System.Threading.Tasks;

namespace MauiJogodaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        public MainPage()
        {
            InitializeComponent();
            zerar();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "X" && btn.Text != "O")
            {
                if (vez == "X")
                {
                    btn.Text = "X";
                    vez = "O";
                    vencerX();
                }
                else
                {
                    btn.Text = "O";
                    vez = "X";
                    vencerO();
                }
                velha();
            }
        }
        void vencerX()
        {
            if (btn11.Text == "X" && btn12.Text == "X" && btn13.Text == "X")
            {
                btn11.BackgroundColor = Colors.Green;
                btn12.BackgroundColor = Colors.Green;
                btn13.BackgroundColor = Colors.Green;
                zerarX();
            }
            if (btn21.Text == "X" && btn22.Text == "X" && btn23.Text == "X")
            {
                btn21.BackgroundColor = Colors.Green;
                btn22.BackgroundColor = Colors.Green;
                btn23.BackgroundColor = Colors.Green;
                zerarX();
            }
            if (btn31.Text == "X" && btn32.Text == "X" && btn33.Text == "X")
            {
                btn31.BackgroundColor = Colors.Green;
                btn32.BackgroundColor = Colors.Green;
                btn33.BackgroundColor = Colors.Green;
                zerarX();
            }
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                btn11.BackgroundColor = Colors.Green;
                btn21.BackgroundColor = Colors.Green;
                btn31.BackgroundColor = Colors.Green;
                zerarX();
            }
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                btn12.BackgroundColor = Colors.Green;
                btn22.BackgroundColor = Colors.Green;
                btn32.BackgroundColor = Colors.Green;
                zerarX();
            }
            if (btn13.Text == "X" && btn23.Text == "X" && btn33.Text == "X")
            {
                btn13.BackgroundColor = Colors.Green;
                btn23.BackgroundColor = Colors.Green;
                btn33.BackgroundColor = Colors.Green;
                zerarX();
            }
            if (btn11.Text == "X" && btn22.Text == "X" && btn33.Text == "X")
            {
                btn11.BackgroundColor = Colors.Green;
                btn22.BackgroundColor = Colors.Green;
                btn33.BackgroundColor = Colors.Green;
                zerarX();
            }
            if (btn13.Text == "X" && btn22.Text == "X" && btn31.Text == "X")
            {
                btn13.BackgroundColor = Colors.Green;
                btn22.BackgroundColor = Colors.Green;
                btn31.BackgroundColor = Colors.Green;
                zerarX();
            }
        }
        void vencerO()
        {
            if (btn11.Text == "O" && btn12.Text == "O" && btn13.Text == "O")
            {
                btn11.BackgroundColor = Colors.Green;
                btn12.BackgroundColor = Colors.Green;
                btn13.BackgroundColor = Colors.Green;
                zerarO();
            }
            if (btn21.Text == "O" && btn22.Text == "O" && btn23.Text == "O")
            {
                btn21.BackgroundColor = Colors.Green;
                btn22.BackgroundColor = Colors.Green;
                btn23.BackgroundColor = Colors.Green;
                zerarO();
            }
            if (btn31.Text == "O" && btn32.Text == "O" && btn33.Text == "O")
            {
                btn31.BackgroundColor = Colors.Green;
                btn32.BackgroundColor = Colors.Green;
                btn33.BackgroundColor = Colors.Green;
                zerarO();
            }
            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                btn11.BackgroundColor = Colors.Green;
                btn21.BackgroundColor = Colors.Green;
                btn31.BackgroundColor = Colors.Green;
                zerarO();
            }
            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                btn12.BackgroundColor = Colors.Green;
                btn22.BackgroundColor = Colors.Green;
                btn32.BackgroundColor = Colors.Green;
                zerarO();
            }
            if (btn13.Text == "O" && btn23.Text == "O" && btn33.Text == "O")
            {
                btn13.BackgroundColor = Colors.Green;
                btn23.BackgroundColor = Colors.Green;
                btn33.BackgroundColor = Colors.Green;
                zerarO();
            }
            if (btn11.Text == "O" && btn22.Text == "O" && btn33.Text == "O")
            {
                btn11.BackgroundColor = Colors.Green;
                btn22.BackgroundColor = Colors.Green;
                btn33.BackgroundColor = Colors.Green;
                zerarO();
            }
            if (btn13.Text == "O" && btn22.Text == "O" && btn31.Text == "O")
            {
                btn13.BackgroundColor = Colors.Green;
                btn22.BackgroundColor = Colors.Green;
                btn31.BackgroundColor = Colors.Green;
                zerarO();
            }
        }

        void velhaColor()
        {
            btn11.BackgroundColor = Colors.Red;
            btn12.BackgroundColor = Colors.Red;
            btn13.BackgroundColor = Colors.Red;
            btn21.BackgroundColor = Colors.Red;
            btn22.BackgroundColor = Colors.Red;
            btn23.BackgroundColor = Colors.Red;
            btn31.BackgroundColor = Colors.Red;
            btn32.BackgroundColor = Colors.Red;
            btn33.BackgroundColor = Colors.Red;
        }

        async Task zerarX()
        {
            await alertVencedorX();
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";

            btn11.BackgroundColor = Colors.Transparent;
            btn12.BackgroundColor = Colors.Transparent;
            btn13.BackgroundColor = Colors.Transparent;
            btn21.BackgroundColor = Colors.Transparent;
            btn22.BackgroundColor = Colors.Transparent;
            btn23.BackgroundColor = Colors.Transparent;
            btn31.BackgroundColor = Colors.Transparent;
            btn32.BackgroundColor = Colors.Transparent;
            btn33.BackgroundColor = Colors.Transparent;
            vez = "X";
        }
        async Task zerarO()
        {
            await alertVencedorO();
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";

            btn11.BackgroundColor = Colors.Transparent;
            btn12.BackgroundColor = Colors.Transparent;
            btn13.BackgroundColor = Colors.Transparent;
            btn21.BackgroundColor = Colors.Transparent;
            btn22.BackgroundColor = Colors.Transparent;
            btn23.BackgroundColor = Colors.Transparent;
            btn31.BackgroundColor = Colors.Transparent;
            btn32.BackgroundColor = Colors.Transparent;
            btn33.BackgroundColor = Colors.Transparent;
            vez = "X";
        }
        void zerar()
        {
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";

            btn11.BackgroundColor = Colors.Transparent;
            btn12.BackgroundColor = Colors.Transparent;
            btn13.BackgroundColor = Colors.Transparent;
            btn21.BackgroundColor = Colors.Transparent;
            btn22.BackgroundColor = Colors.Transparent;
            btn23.BackgroundColor = Colors.Transparent;
            btn31.BackgroundColor = Colors.Transparent;
            btn32.BackgroundColor = Colors.Transparent;
            btn33.BackgroundColor = Colors.Transparent;
            vez = "X";
        }
        async Task velha()
        {
            if (btn11 != null)
            {
                if (btn11.Text != "" && btn12.Text != "" && btn13.Text != "" && btn21.Text != "" && btn22.Text != "" && btn23.Text != "" && btn31.Text != "" && btn32.Text != "" && btn33.Text != "")
                {
                    velhaColor();
                    await alertVelha();
                    zerar();
                }
            }
        }
        async Task alertVelha()
        {
            await Task.Delay(1500);

            await DisplayAlert("Eita", "Deu velha", "OK");
        }
        async Task alertVencedorO()
        {
            await Task.Delay(1500);

            await DisplayAlert("Parabens", "O 'O' ganhou", "OK");
        }
        async Task alertVencedorX()
        {
            await Task.Delay(1500);

            await DisplayAlert("Parabens", "O 'X' ganhou", "OK");
        }
    }
}