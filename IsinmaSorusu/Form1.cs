namespace IsinmaSorusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Gorev1();
            Gorev2();
        }

        private void Gorev2()
        {
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Width = panel2.Width / 10;
                    btn.Height = panel2.Height / 10;
                    btn.Left = j * btn.Width;
                    btn.Top = i * btn.Height;
                    btn.MouseEnter += (s, e) => btn.BackColor = Color.Green;
                    panel2.Controls.Add(btn);
                }
            }
        }

        private void Gorev1()
        {
            Button btn = new Button();
            btn.Text = "Üzerime Gelme";
            btn.Width = 100;
            btn.Left = (panel1.Width - btn.Width) / 2;
            btn.Top = (panel1.Height - btn.Height) / 2;
            btn.BackColor = Color.White;
            //btn.MouseEnter += Btn_MouseEnter;
            btn.MouseEnter += (sender, e) => btn.Hide();
            panel1.Controls.Add(btn);
        }

        //private void Btn_MouseEnter(object? sender, EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    button.Hide();
        //}
    }
}