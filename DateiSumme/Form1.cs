namespace DateiSumme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDatenAuswählen_Click(object sender, EventArgs e)
        {//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!TODO
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dlgResult = new DialogResult();
            dlgResult = ofd.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                //cboFileName.Text = ofd.FileName;
            }


        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBerechneSumme_Click(object sender, EventArgs e)

        { 
           Dateisumme dateisumme = new Dateisumme();
            
        }
    }

}
