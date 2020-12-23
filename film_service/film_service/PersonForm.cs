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
    public partial class PersonForm : Form
    {
        private long id;
        public PersonForm(long id)
        {
            InitializeComponent();
            if (!DBContext.isFullAccess())
                block();
            else
                unblock();
            this.id = id;
            fillForm();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void fillForm()
        {
            person p = DBContext.context.person.Find(id);
            firstName.Text = p.first_name;
            lastName.Text = p.last_name;
            middleName.Text = p.middle_name;
            age.Value = p.age;
            foreach(gender g in DBContext.context.gender)
            {
                genderCB.Items.Add(g.name);
                if (g.id == p.gender_id)
                    genderCB.SelectedItem = g.name;
            }
            height.Value = (decimal)p.height;
        }
        private void block()
        {
            firstName.ReadOnly = lastName.ReadOnly = middleName.ReadOnly = true;
            age.Enabled = height.Enabled = genderCB.Enabled = changeButton.Visible = false;
        }
        private void unblock()
        {
            firstName.ReadOnly = lastName.ReadOnly = middleName.ReadOnly = false;
            age.Enabled = height.Enabled = genderCB.Enabled = changeButton.Visible = true;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DBContext.context.person.Find(id).Update(firstName.Text, middleName.Text, lastName.Text, (byte)age.Value, (from g in DBContext.context.gender
                                                                                                                     where g.name == genderCB.SelectedItem.ToString()
                                                                                                                     select g.id).FirstOrDefault(), (byte) height.Value);
                DBContext.context.SaveChanges();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message);
            }
        }
    }
}
