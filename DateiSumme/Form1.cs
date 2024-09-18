using System.IO;
using System.Windows.Forms;

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
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    filePath = openFileDialog.FileName;

                    // Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        Dateisumme dateisumme = new Dateisumme();
                        dateisumme.index = 0;
                        double gesamtSumme = 0.00; 

                        // Clear the ListBox before adding new content
                        listBox1.Items.Clear();

                        // Read each line and add it to the ListBox
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            dateisumme.index++;
                            dateisumme.zahl1 = Convert.ToDouble(line);

                            
                            gesamtSumme += dateisumme.zahl1;

                            
                            listBox1.Items.Add($"{dateisumme.index}  Umsatz: {dateisumme.zahl1}  Gesamtsumme: {gesamtSumme.ToString("F2")}");

                           
                        }
                        double g1= gesamtSumme * 0.07;
                        double g2 = gesamtSumme * 0.19;
                        listBox1.Items.Add(gesamtSumme.ToString("F2")+" * 7% = "+g1.ToString("F2")+" "+ gesamtSumme.ToString("F2") + " * 19% = " + g2.ToString("F2"));
                        txtSumme.Text = gesamtSumme.ToString("F2");
                    }
                }
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
