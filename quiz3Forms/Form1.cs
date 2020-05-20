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

namespace quiz3Forms
{
    public partial class Form1 : Form
    {
        //List <User> userList = new List<User>();
        string path = @"C:\csharp\registered_user.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFN.Clear();
            textBoxLN.Clear();
            textBoxPhone.Clear();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {   
            // check all textboxes are empty
            if(string.IsNullOrEmpty(textBoxFN.Text))
            { MessageBox.Show("Field First name is empty"); }

            else if (string.IsNullOrEmpty(textBoxLN.Text))
            { MessageBox.Show("Field Last name is empty"); }

            else if (string.IsNullOrEmpty(textBoxPhone.Text))
            { MessageBox.Show("Field Telephone number is empty"); }

            else
            {
                                
                //if there is no file, create a new file
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path));
                }

                // create a new user with textbox input
                User newUser = new User(textBoxFN.Text, textBoxLN.Text, textBoxPhone.Text);
                textBoxFN.Clear();
                textBoxLN.Clear();
                textBoxPhone.Clear();

                // convert user into text
                string newText = newUser.ToString() + Environment.NewLine;
                // add to the end of text file
                File.AppendAllText(path, newText);


            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            //count how many lines readed
            int count = lines.Length;
            MessageBox.Show($"There is/are {count} user(s) in the file");
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            File.Delete(path);
        }
    }
}
