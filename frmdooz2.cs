namespace dooz
{
    public partial class frmdooz2 : Form
    {
        int turn;
        // turn(0) = X    turn(1) = O

        string[] text = new string[9];
        int i = 0;
        public frmdooz2()
        {
            InitializeComponent();
        }

        private void frmdooz2_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            turn = rnd.Next(0, 2);
            if (turn == 0)
            {
                btnX.BackColor = Color.BlueViolet;
                btnO.BackColor = SystemColors.Control;
            }
            else
            {
                btnO.BackColor = Color.BlueViolet;
                btnX.BackColor = SystemColors.Control;
            }
        }

        private void XO()
        {
            if (turn == 0)
            {
                text[i] = "X";
                turn = 1;
                btnO.BackColor = Color.BlueViolet;
                btnX.BackColor = SystemColors.Control;
            }
            else
            {
                text[i] = "O";
                turn = 0;
                btnO.BackColor = SystemColors.Control;
                btnX.BackColor = Color.BlueViolet;
            }
        }

        private void win()
        {
            if (text[0] == text[1] && text[1] == text[2] && text[0] != null)
            {
                MessageBox.Show(text[0] + " is win ");
                finish();
            }
            else if (text[0] == text[3] && text[3] == text[6] && text[0] != null)
            {
                MessageBox.Show(text[0] + " is win ");
                finish();
            }
            else if (text[0] == text[4] && text[4] == text[8] && text[0] != null)
            {
                MessageBox.Show(text[0] + " is win ");
                finish();
            }
            else if (text[3] == text[4] && text[4] == text[5] && text[3] != null)
            {
                MessageBox.Show(text[3] + " is win ");
                finish();
            }
            else if (text[1] == text[4] && text[4] == text[7] && text[1] != null)
            {
                MessageBox.Show(text[4] + " is win ");
                finish();
            }
            else if (text[2] == text[4] && text[4] == text[6] && text[2] != null)
            {
                MessageBox.Show(text[2] + " is win ");
                finish();
            }
            else if (text[6] == text[7] && text[7] == text[8] && text[6] != null)
            {
                MessageBox.Show(text[6] + " is win ");
                finish();
            }
            else if (text[2] == text[5] && text[5] == text[8] && text[2] != null)
            {
                MessageBox.Show(text[2] + " is win ");
                finish();
            }
            else if (text.Contains(null) == false)
            {
                MessageBox.Show("no winner");
                btnReset_Click(null, null);
            }
        }

        private void finish()
        {
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
        }


        private void btn0_Click(object sender, EventArgs e)
        {
            i = 0;
            if (text[i] == null)
            {
                XO();
                btn0.Text = text[i];
                win();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            i = 1;
            if (text[i] == null)
            {
                XO();
                btn1.Text = text[i];
                win();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            i = 2;
            if (text[i] == null)
            {
                XO();
                btn2.Text = text[i];
                win();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            i = 3;
            if (text[i] == null)
            {
                XO();
                btn3.Text = text[i];
                win();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            i = 4;
            if (text[i] == null)
            {
                XO();
                btn4.Text = text[i];
                win();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            i = 5;
            if (text[i] == null)
            {
                XO();
                btn5.Text = text[i];
                win();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            i = 6;
            if (text[i] == null)
            {
                XO();
                btn6.Text = text[i];
                win();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            i = 7;
            if (text[i] == null)
            {
                XO();
                btn7.Text = text[i];
                win();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            i = 8;
            if (text[i] == null)
            {
                XO();
                btn8.Text = text[i];
                win();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btn0.ResetText();
            btn0.Enabled = true;
            btn1.ResetText();
            btn1.Enabled = true;
            btn2.ResetText();
            btn2.Enabled = true;
            btn3.ResetText();
            btn3.Enabled = true;
            btn4.ResetText();
            btn4.Enabled = true;
            btn5.ResetText();
            btn5.Enabled = true;
            btn6.ResetText();
            btn6.Enabled = true;
            btn7.ResetText();
            btn7.Enabled = true;
            btn8.ResetText();
            btn8.Enabled = true;
            i = 0;
            text = new string[9];
            frmdooz2_Load(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
