using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Packer_editor;
using FormVars;
using System.IO;
namespace Packer_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("c:/Users/" + Environment.UserName + "\\AppData\\Roaming\\.minecraft\\resourcepacks\\" + textBox1.Text))
            {
                this.Hide();
                Form2 df = new Form2(textBox1.Text);
                df.Show();
            }
            else { Form3 df = new Form3(); df.Show();  }

            
            

        }
        private void close() { Application.Exit(); }
        public static void OpenForm()
        {


            while (true)
            {
               
            }

        }

        private void close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
