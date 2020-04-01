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
    public partial class Form1 : Form
    {
        string path = @"C:\build_output\log.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Одне з полів не може бути пустим!", "Помилка");
            }
            else
            {
               String userData = "Email: " + txtEmail.Text + " "
        + "Name: " + txtName.Text
        + System.Environment.NewLine;

                File.AppendAllText(path, userData, Encoding.UTF8);

                MessageBox.Show("Ваші дані успішно внесено", "Успіх");

                txtEmail.Text = "";
                txtName.Text = "";
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            string fileText = File.ReadAllText(path);
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
