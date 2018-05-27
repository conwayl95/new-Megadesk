using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_Lisa_Conway
{
    public partial class ViewAllQuotes : Form
    {

        public List<DeskQuote> myQuotes = new List<DeskQuote>();

        public ViewAllQuotes()
        {
            InitializeComponent();

         

            string readText = File.ReadAllText("C:\\Users\\lisac\\Documents\\quotes.txt");
            var lines = readText.Split("\r\n".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var quote = new DeskQuote(line);
                myQuotes.Add(quote);

            //dataGridView1.AutoGenerateColumns = true;
                Console.WriteLine(line);
            }

            dataGridView1.DataSource = myQuotes;

          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string readText = File.ReadAllText("C:\\Users\\lisac\\Documents\\quotes.txt");
            //Console.WriteLine(readText);

        }
    }
}
