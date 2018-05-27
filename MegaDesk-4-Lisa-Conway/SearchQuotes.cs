using MegaDesk_3_Lisa_Conway.Models;
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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            var surfaceList = SurfaceMaterialFactory.GetSurfaceMaterials();
            lblMaterial.DataSource = surfaceList;
            lblMaterial.DisplayMember = "Name";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
            Close();
        }

        //private void loadGrid(string searchTerm)
        //{
        //    dataGridView2.Rows.Clear();
        //    string[] deskQuotes = File.ReadAllLines(@"quotes.txt");
        //    foreach (string deskQuote in deskQuotes)
        //    {
        //        if (deskQuote.Contains(searchTerm))
        //        {
        //            string[] arrRow = deskQuote.Split(new char[] { ',' });
        //            dataGridView2.Rows.Add(arrRow);
        //        }
        //    }
        //}

        private void lblMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DeskQuote> myQuotes = new List<DeskQuote>();
        string readText = File.ReadAllText("C:\\Users\\lisac\\Documents\\quotes.txt");
            var lines = readText.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            SurfaceMaterial material = (SurfaceMaterial)lblMaterial.SelectedItem;
            foreach (var line in lines)
            {
                var quote = new DeskQuote(line);
               if (material.Name.CompareTo(quote.Desk.SurfaceMaterial.Name) == 0)
                {
                   myQuotes.Add(quote);

                }


               
                
            }
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = myQuotes;
        }
    }
}
