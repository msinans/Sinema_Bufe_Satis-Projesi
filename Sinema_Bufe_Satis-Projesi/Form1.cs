namespace Sinema_Bufe_Satis_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(txtMisir.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            su = Convert.ToInt16(txtSu.Text);
            cay = Convert.ToInt16(txtCay.Text);
            toplam = misir * 10 + bilet * 50 + su * 5 + cay * 10;
            lblToplam.Text = toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString() + "TL";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMisir.Text = "";
            txtBilet.Text = "";
            txtCay.Text = "";
            txtSu.Text = "";
            txtMisir.Focus();
        }
    }
}