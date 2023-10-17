namespace Online6SuDeposu
{
    public partial class Form1 : Form
    {
        SuDeposu depo = new SuDeposu(100, 1);

        public Form1()
        {
            InitializeComponent();
            pnlSu.Height = 0;
            depo.SuMiktariDegisti += Depo_SuMiktariDegisti;
            depo.DepoDoldu += Depo_DepoDoldu;
        }

        private void Depo_DepoDoldu(int tasan)
        {
            if (tasan <= 0)
            {
                MessageBox.Show("Depo doldu.");
            }
            else
            {
                MessageBox.Show($"Depo dolu ve {tasan} litre su taþtý.");
            }
        }

        private void Depo_SuMiktariDegisti()
        {
            pnlSu.Height = (int)Math.Round(depo.DolulukOrani * pnlDepo.Height);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            depo.SuEkle((int)nudMiktar.Value);
        }
    }
}