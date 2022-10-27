namespace DogRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox_flag.BringToFront();
            pictureBox_flag.Parent = pictureBox1;
        }

        private void checkBox_dog1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dog1.Checked == true)
            {
                checkBox_dog2.Checked = false;
                checkBox_dog3.Checked = false;

                button_start.Enabled = true;

            }

            else if ((checkBox_dog2.Checked == false ) & (checkBox_dog3.Checked == false))
            {
                button_start.Enabled = false;
            }
        }

        private void checkBox_dog2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dog2.Checked == true)
            {
                checkBox_dog1.Checked = false;
                checkBox_dog3.Checked = false;

                button_start.Enabled = true;

            }

            else if ((checkBox_dog1.Checked == false) & (checkBox_dog3.Checked == false))
            {
                button_start.Enabled = false;
            }
        }

        private void checkBox_dog3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dog3.Checked == true)
            {
                checkBox_dog2.Checked = false;
                checkBox_dog1.Checked = false;

                button_start.Enabled = true;

            }

            else if ((checkBox_dog2.Checked == false) & (checkBox_dog1.Checked == false))
            {
                button_start.Enabled = false;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (string.Compare(button_start.Text, "START") == 0)
            {
                button_start.Text = "STOP";
                textBox_wl.Text = "COMEÇOU!!";
                timer_run.Enabled = true;
                checkBox_dog1.Enabled = false;
                checkBox_dog2.Enabled = false;
                checkBox_dog3.Enabled = false;

            }            
            else if (string.Compare(button_start.Text, "STOP") == 0)
            {
                button_start.Text = "RESET";
                textBox_wl.Text = "APOSTE!!";
                timer_run.Enabled = false;

            }
            else if (string.Compare(button_start.Text, "RESET") == 0)
            {
                pictureBox_dog1.Location = new Point(219, pictureBox_dog1.Location.Y);
                pictureBox_dog2.Location = new Point(219, pictureBox_dog2.Location.Y);
                pictureBox_dog3.Location = new Point(219, pictureBox_dog3.Location.Y);
                button_start.Text = "START";

                checkBox_dog1.Enabled = true;
                checkBox_dog2.Enabled = true;
                checkBox_dog3.Enabled = true;
            }
        }

        private void timer_run_Tick(object sender, EventArgs e)
        {
            // 1160
            Random rnd = new Random();

            pictureBox_dog1.Location = new Point(pictureBox_dog1.Location.X + rnd.Next(10), pictureBox_dog1.Location.Y);
            pictureBox_dog2.Location = new Point(pictureBox_dog2.Location.X + rnd.Next(10), pictureBox_dog2.Location.Y);
            pictureBox_dog3.Location = new Point(pictureBox_dog3.Location.X + rnd.Next(10), pictureBox_dog3.Location.Y);

            if (pictureBox_dog1.Location.X > 1160)
            {
                timer_run.Enabled = false;
                button_start.Text = "RESET";

                if (checkBox_dog1.Checked == true)
                {
                    textBox_wl.Text = "VOCÊ GANHOU!!";
                }
                else
                {
                    textBox_wl.Text = "LOSERR";
                }
            }
            if (pictureBox_dog2.Location.X > 1160)
            {
                timer_run.Enabled = false;
                button_start.Text = "RESET";

                if (checkBox_dog2.Checked == true)
                {
                    textBox_wl.Text = "VOCÊ GANHOU!!";
                }
                else
                {
                    textBox_wl.Text = "LOSERR";
                }
            }
            if (pictureBox_dog3.Location.X > 1160)
            {
                timer_run.Enabled = false;
                button_start.Text = "RESET";

                if (checkBox_dog3.Checked == true)
                {
                    textBox_wl.Text = "VOCÊ GANHOU!!";
                }
                else
                {
                    textBox_wl.Text = "LOSERR";
                }
            }
        }
    }
}