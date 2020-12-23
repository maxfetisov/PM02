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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.ShowDialog();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            string connectionString = $"metadata=res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl;provider=System.Data.SqlClient;provider connection string=\"data source=DESKTOP-PNOODSG\\SQLEXPRESS;initial catalog=film_service;integrated security=False;User ID={login.Text};Password={password.Text};MultipleActiveResultSets=True;App=EntityFramework\"";
            try
            {
                using (film_serviceEntities context = new film_serviceEntities(connectionString))
                {
                    context.Database.Connection.Open();
                    context.Database.Connection.Close();
                }
                DBContext.createContext(connectionString);
                DBContext.Login = login.Text;
                FilmListForm form = new FilmListForm();
                form.Show();
                Close();
        }
            catch
            {
                MessageBox.Show("Подключение не удалось");
            }
}
    }
}
