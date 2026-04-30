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
                zerarX();
            }
            if (btn21.Text == "X" && btn22.Text == "X" && btn23.Text == "X")
            {
                zerarX();
            }
            if (btn31.Text == "X" && btn32.Text == "X" && btn33.Text == "X")
            {
                zerarX();
            }
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                zerarX();
            }
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                zerarX();
            }
            if (btn13.Text == "X" && btn23.Text == "X" && btn33.Text == "X")
            {
                zerarX();
            }
            if (btn11.Text == "X" && btn22.Text == "X" && btn33.Text == "X")
            {
                zerarX();
            }
            if (btn13.Text == "X" && btn22.Text == "X" && btn31.Text == "X")
            {
                zerarX();
            }
        }
        void vencerO()
        {
            if (btn11.Text == "O" && btn12.Text == "O" && btn13.Text == "O")
            {
                zerarO();
            }
            if (btn21.Text == "O" && btn22.Text == "O" && btn23.Text == "O")
            {
                zerarO();
            }
            if (btn31.Text == "O" && btn32.Text == "O" && btn33.Text == "O")
            {
                zerarO();
            }
            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                zerarO();
            }
            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                zerarO();
            }
            if (btn13.Text == "O" && btn23.Text == "O" && btn33.Text == "O")
            {
                zerarO();
            }
            if (btn11.Text == "O" && btn22.Text == "O" && btn33.Text == "O")
            {
                zerarO();
            }
            if (btn13.Text == "O" && btn22.Text == "O" && btn31.Text == "O")
            {
                zerarO();
            }
        }
        void zerarX()
        {
            DisplayAlert("Parabens", "O 'X' ganhou", "OK");
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";
            vez = "X";
        }
        void zerarO()
        {
            DisplayAlert("Parabens", "O 'O' ganhou", "OK");
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";
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
            vez = "X";
        }
        void velha()
        {
            if(btn11 != null)
            {
                if (btn11.Text != "" && btn12.Text != "" && btn13.Text != "" && btn21.Text != "" && btn22.Text != "" && btn23.Text != "" && btn31.Text != "" && btn32.Text != "" && btn33.Text != "")
                {
                    DisplayAlert("Eita", "Deu velha", "OK");
                    zerar();
                }
            }
        }
    }
}