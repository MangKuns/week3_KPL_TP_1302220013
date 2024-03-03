namespace week3_KPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TombolInput_Click(object sender, EventArgs e)
        {
            string nama = inputNama.Text;
            string nim = InputNIM.Text;
            LabelOutput.Text = "Berhasil Input..." + "\n" +
                "Nama: " + nama + "\n" +
                "NIM: " + nim + "\n" + "\n" +
                "Halo " + nama;
        }
    }
}
