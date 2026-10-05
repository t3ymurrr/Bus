using System;
using System.Windows.Forms;

namespace Bus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHaradan.Items.AddRange(new string[] { "Bakı", "Gəncə", "Sumqayıt", "Şəki", "Lənkəran", "Quba" });
            cmbHaraya.Items.AddRange(new string[] { "Bakı", "Gəncə", "Sumqayıt", "Şəki", "Lənkəran", "Quba" });
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string temp = cmbHaradan.Text;
            cmbHaradan.Text = cmbHaraya.Text;
            cmbHaraya.Text = temp;
        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbHaradan.Text) || string.IsNullOrWhiteSpace(cmbHaraya.Text) || string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                MessageBox.Show("Məlumatları tam doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bilet = $"Ad Soyad: {txtAdSoyad.Text} | FIN: {txtFIN.Text} | Tel: {mtxtTelefon.Text} | Marşrut: {cmbHaradan.Text} - {cmbHaraya.Text} | Tarix: {mtxtTarix.Text} | Saat: {mtxtSaat.Text} | Yer: {txtYer.Text}";

            listBoxBiletler.Items.Add(bilet);
        }

        private void btnBiletiSil_Click(object sender, EventArgs e)
        {
            if (listBoxBiletler.SelectedIndex != -1)
            {
                listBoxBiletler.Items.RemoveAt(listBoxBiletler.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxış edilsinmi?", "Bildiriş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}