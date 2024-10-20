namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        //Button[] botoes = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
        string turno = "p1";
        string player1 = "";
        string player2 = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LimparTabuleiro(false);
        }

        private void LimparTabuleiro(bool habilita)
        {
            btn1.Text = string.Empty;
            btn2.Text = string.Empty;
            btn3.Text = string.Empty;
            btn4.Text = string.Empty;
            btn5.Text = string.Empty;
            btn6.Text = string.Empty;
            btn7.Text = string.Empty;
            btn8.Text = string.Empty;
            btn9.Text = string.Empty;
            btn1.Enabled = habilita;
            btn2.Enabled = habilita;
            btn3.Enabled = habilita;
            btn4.Enabled = habilita;
            btn5.Enabled = habilita;
            btn6.Enabled = habilita;
            btn7.Enabled = habilita;
            btn8.Enabled = habilita;
            btn9.Enabled = habilita;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (player1 == "")
            {
                player1 = "X";
                player2 = "O";
                btnIniciar.Enabled = true;
                LblJogadorX.Text = "jogador 1";
                lblJogadorO.Text = "jogador 2";
            }

        }

        private void btnO_Click(object sender, EventArgs e)
        {
            if (player1 == "")
            {
                player1 = "O";
                player2 = "X";
                btnIniciar.Enabled = true;
                LblJogadorX.Text = "jogador 2";
                lblJogadorO.Text = "jogador 1";
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            turno = "p1";
            btnIniciar.Enabled = false;
            LimparTabuleiro(true);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (turno == "p1")
            {
                btn1.Text = player1;
                turno = "p2";
            }
            else
            {
                btn1.Text = player2;
                turno = "p1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (turno == "p1")
            {
                btn2.Text = player1;
                turno = "p2";
            }
            else
            {
                btn2.Text = player2;
                turno = "p1";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (turno == "p1")
            {
                btn3.Text = player1;
                turno = "p2";
            }
            else
            {
                btn3.Text = player2;
                turno = "p1";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (turno == "p1")
            {
                btn4.Text = player1;
                turno = "p2";
            }
            else
            {
                btn4.Text = player2;
                turno = "p1";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (turno == "p1")
            {
                btn5.Text = player1;
                turno = "p2";
            }
            else
            {
                btn5.Text = player2;
                turno = "p1";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (turno == "p1")
            {
                btn6.Text = player1;
                turno = "p2";
            }
            else
            {
                btn6.Text = player2;
                turno = "p1";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (turno == "p1")
            {
                btn7.Text = player1;
                turno = "p2";
            }
            else
            {
                btn7.Text = player2;
                turno = "p1";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (turno == "p1")
            {
                btn8.Text = player1;
                turno = "p2";
            }
            else
            {
                btn8.Text = player2;
                turno = "p1";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (turno == "p1")
            {
                btn9.Text = player1;
                turno = "p2";
            }
            else
            {
                btn9.Text = player2;
                turno = "p1";
            }
        }
    }
}