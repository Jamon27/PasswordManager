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

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        private string configFile = @".\test.txt";
        public Form1()
        {
            InitializeComponent();
            
            if (!File.Exists(configFile))
            {
                File.Create(configFile);
                
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            

            if ((LogInTextBox.Text == "") || (PasswordTextBox.Text == "")) {
                MessageBox.Show("Логин или пароль не введены");
                return;
            }
            //regexp добавить



                File.WriteAllText(configFile, $"{LogInTextBox.Text} : {PasswordTextBox.Text}\n");

                

        }
    }
}
