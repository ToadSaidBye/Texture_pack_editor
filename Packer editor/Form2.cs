using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Packer_editor
{
    public partial class Form2 : Form
    {
        public Form2(string name)
        {
            InitializeComponent();
            textBox2.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = Environment.UserName;

            System.IO.Directory.CreateDirectory("c:/users/" + Environment.UserName + "/temp");
            openFileDialog2.InitialDirectory = "c:\\Users\\" + user + "\\AppData\\Roaming\\.minecraft\\resourcepacks\\" + textBox2.Text + "\\assets";

            openFileDialog2.FileName = "";
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName != "")
            {
                string myFilePath = openFileDialog2.FileName;
                string ext = Path.GetExtension(myFilePath);
                string name = Path.GetFileNameWithoutExtension(myFilePath);
                textBox1.Text = ext;
                textBox3.Text = name;
                button2.Visible = true;
                if (ext == ".png")
                {
                    string imgpath = "c:/users/" + user + "/temp/" + name + ".png";
                    File.Copy(openFileDialog2.FileName, imgpath);
                    Image newImage = Image.FromFile(imgpath);
                    
                    pictureBox1.Image = newImage;
                }

            }
        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

 

        private void openMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 df = new Form1();
            df.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.Delete("c:/users/" + Environment.UserName + "/temp", true);
            Application.Exit();
        }

        private void appquit()
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
 
        }

        private void chooseFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string user = Environment.UserName;

            System.IO.Directory.CreateDirectory("c:/users/" + Environment.UserName + "/temp");
            openFileDialog2.InitialDirectory = "c:\\Users\\" + user + "\\AppData\\Roaming\\.minecraft\\resourcepacks\\" + textBox2.Text + "\\assets";

            openFileDialog2.FileName = "";
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName != "")
            {
                string myFilePath = openFileDialog2.FileName;
                string ext = Path.GetExtension(myFilePath);
                string name = Path.GetFileNameWithoutExtension(myFilePath);
                textBox1.Text = ext;
                textBox3.Text = name;
                button2.Visible = true;
                textBox4.Text = "Please select next file";
                if (ext == ".png")
                {
                    string imgpath = "c:/users/" + user + "/temp/" + name + ".png";
                    File.Copy(openFileDialog2.FileName, imgpath);
                    Image newImage = Image.FromFile(imgpath);
                    pictureBox1.Image = newImage;
                    
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string myFilePath = openFileDialog2.FileName;
            string ext = Path.GetExtension(myFilePath);
            openFileDialog3.RestoreDirectory = true;
            openFileDialog3.Filter = "Same file as chosen(*.???)|*" + ext;
            openFileDialog3.FileName = "";
            openFileDialog3.ShowDialog();
            if (openFileDialog3.FileName != "")
            {
                File.Delete(openFileDialog2.FileName);
                File.Copy(openFileDialog3.FileName, openFileDialog2.FileName);
                textBox4.Text = "Complete!";
                if (ext == ".png")
                {
                    Image newImage = Image.FromFile(openFileDialog3.FileName);

                    pictureBox2.Image = newImage;

                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
