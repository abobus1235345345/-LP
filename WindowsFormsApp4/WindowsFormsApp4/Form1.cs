using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = textBox4.Text;

            Dictionary<string, string[]> employeesData = new Dictionary<string, string[]>()
    {
        {"Илья", new string[] {"Qwerty", "Илья", "Developer"}},
        {"user2", new string[] { "user", "Jane Smith", "Manager"}}
                
    };


            if (employeesData.ContainsKey(login) && employeesData[login][0] == password)
            {
                string name = employeesData[login][1];
                string position = employeesData[login][2];

                MessageBox.Show($"Имя: {name}\nДолжность: {position}", "Информация о сотруднике");
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
            }
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
    

}

        
        