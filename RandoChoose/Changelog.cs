using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandoChoose
{
    public partial class Changelog : Form
    {
        public Changelog(string[][] d)
        {
            InitializeComponent();
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (string[] x in d)
            {
                builder.Append(x[0]);
                builder.AppendLine();
                builder.Append(x[1]);
                i++;
                if (i != d.Length)
                {
                    builder.AppendLine();
                    builder.AppendLine();
                }
            }
            textBox1.Text = builder.ToString();
        }
    }
}