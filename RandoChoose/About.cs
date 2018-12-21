using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMGLibrary;

namespace RandoChoose
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void showChangelog(object sender, EventArgs e)
        {
            if (Internet.isConnected() == false)
            {
                MessageBox.Show("Not connected to the internet.", "Not Connected", MessageBoxButtons.OK);
                return;
            }
            Console.WriteLine("fetching");
            string[][] data = RMGLibrary.Changelog.getData("RandoChoose", 0);
            Console.WriteLine("fetched");
            new Changelog(data).ShowDialog();
        }
    }
}