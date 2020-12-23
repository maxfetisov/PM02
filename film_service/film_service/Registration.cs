using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace film_service
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();          
        }

        private void register_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(login.Text) && !string.IsNullOrEmpty(password.Text) && !string.IsNullOrEmpty(nickname.Text))
                {
                    using (film_serviceEntities context = new film_serviceEntities())
                    {
                        user us = new user(login.Text, password.Text, nickname.Text, phone.Text, mail.Text);
                        context.user.Add(us);
                        context.SaveChanges();
                        Close();
                    }                      
                }
                else
                {
                    MessageBox.Show("Не заполнены обязательные поля");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка регистриции: " + ex.Message);
            }
        }
    }
}
