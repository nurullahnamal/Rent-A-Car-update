namespace Rent_A_Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmM��teriEkle ekle=new frmM��teriEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmM��teriListele listele = new frmM��teriListele();
        listele.ShowDialog();
        }
    }
}