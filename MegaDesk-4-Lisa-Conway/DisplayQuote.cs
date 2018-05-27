using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_Lisa_Conway
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string textToWrite)
        {
            InitializeComponent();
            //customerName.Text = DeskQuote.customerName;

            label1.Text = textToWrite;
        }
    }
}
