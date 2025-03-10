namespace SortVisualization
{
    public partial class Form1 : Form
    {
        private Panel[] panels = new Panel[50];
        private bool isSorted = false;

        public Form1()
        {
            InitializeComponent();
            Init();
            comboBox1.SelectedIndex = 0;
        }

        private void Init()
        {
            btnStart.Text = "Start";
            var random = new Random();
            for (int i = 0; i < panels.Length; i++)
            {
                panels[i] = new Panel()
                {
                    Width = 10,
                    Height = random.Next(30, 340),
                    Left = 30 + 18 * i,
                    BackColor = Color.Green
                };
                panels[i].Top = 500 - panels[i].Height;
            }

            Controls.AddRange(panels);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isSorted)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    for (int i = 0; i < panels.Length; i++)
                    {
                        for (int j = 0; j < panels.Length - 1 - i; j++)
                        {
                            if (panels[j].Height > panels[j + 1].Height)
                            {
                                var tmp = panels[j];
                                panels[j] = panels[j + 1];
                                panels[j + 1] = tmp;

                                int tmp1 = panels[j].Left;
                                panels[j].Left = panels[j + 1].Left;
                                panels[j + 1].Left = tmp1;
                                //MovePanels(panels[j], panels[j + 1]);
                                Thread.Sleep(10);
                                //var tmpLeft = panels[j].Left;
                                //panels[j].Left = panels[j + 1].Left;
                                //panels[j + 1].Left = tmpLeft;
                            }
                        }
                    }
                }
                else
                {
                    int min;

                    for (int i = 0; i < panels.Length - 1; i++)
                    {
                        min = i;

                        for (int j = i + 1; j < panels.Length; j++)
                        {
                            if (panels[min].Height > panels[j].Height)
                            {
                                min = j;
                            }
                        }

                        var tmp = panels[i];
                        panels[i] = panels[min];
                        panels[min] = tmp;

                        MovePanels(panels[i], panels[min]);
                        Thread.Sleep(50);
                    }
                }
            }
            else
            {
                Init();
            }

            isSorted = !isSorted;

            if (isSorted)
            {
                btnStart.Text = "Generate new";
            }
        }

        private void MovePanels(Panel panel1, Panel panel2)
        {
            for (int i = 0; i < panel1.Height; i++)
            {
                panel1.Top++;
                panel2.Top--;
                Thread.Sleep(1);
            }

            int tmpLeft = panel1.Left;

            for (int i = panel1.Left, j = panel2.Left; i >= panel2.Left || j <= tmpLeft; i--, j++)
            {
                panel1.Left = i;
                panel2.Left = j;

                //Thread.Sleep(1);
            }

            for (int i = 0; i < panel1.Height; i++)
            {
                panel1.Top--;
                panel2.Top++;
                Thread.Sleep(1);
            }
        }
    }
}
