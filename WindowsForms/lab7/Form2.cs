using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string fileText = File.ReadAllText(path);
            showTxtFile.Text = fileText;
        }
        string path = @"C:\build_output\log.txt";
      

        

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
