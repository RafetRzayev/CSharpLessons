using System.Diagnostics;
using System.Xml.XPath;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isStart = true;
        private int ySpeed = 2;
        private int xSpeed = 4;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnBall.Top += ySpeed;
            btnBall.Left += xSpeed;

            if (btnBall.Bottom >= this.ClientSize.Height)
            {
                button2_Click(null, null);
            }

            if (btnBall.Top <= 0)
            {
                ySpeed = -ySpeed;
            }

            if (btnBall.Left <= 0 || btnBall.Right >= this.ClientSize.Width)
            {
                xSpeed = -xSpeed;
            }

            if (pnlStick.Top - btnBall.Bottom < ySpeed && btnBall.Right >=pnlStick.Left && btnBall.Left <= pnlStick.Right)
            {
                xSpeed = -xSpeed;
                ySpeed = -ySpeed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isStart)
            {
                button2.Text = "Stop";
                timer1.Start();
            }
            else
            {
                button2.Text = "Start";
                timer1.Stop();
                btnBall.Top = 20;
                btnBall.Left = 200;
            }

            isStart = !isStart;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                if (pnlStick.Left > 0)
                    pnlStick.Left -= 20;
            }
            else if (keyData == Keys.Right)
            {
                if (pnlStick.Right < this.ClientSize.Width)
                    pnlStick.Left += 20;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
