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
    public partial class OtherTablesForm : Form
    {
        public OtherTablesForm()
        {
            InitializeComponent();
            fillGenreDGV();
            fillPersonDGV();
            fillPostDGV();
        }
        private void fillGenreDGV()
        {          
            genreDGV.DataSource = DBContext.context.genre.ToList();
            genreDGV.Columns[0].Visible = genreDGV.Columns[genreDGV.ColumnCount - 1].Visible = false;
            genreDGV.Columns[1].HeaderText = "Название жанра";
        }
        private void fillPostDGV()
        {
            postDGV.DataSource = DBContext.context.post.ToList();
            postDGV.Columns[0].Visible = postDGV.Columns[postDGV.ColumnCount - 1].Visible = false;
            postDGV.Columns[1].HeaderText = "Название должности";
        }
        private void fillPersonDGV()
        {
            personDGV.DataSource = DBContext.context.person.ToList();
            personDGV.Columns[0].Visible = personDGV.Columns[personDGV.ColumnCount - 1].Visible = personDGV.Columns[personDGV.ColumnCount - 2].Visible = personDGV.Columns[personDGV.ColumnCount - 4].Visible = false;
            personDGV.Columns[1].HeaderText = "Имя";
            personDGV.Columns[2].HeaderText = "Отчество";
            personDGV.Columns[3].HeaderText = "Фамилия";
            personDGV.Columns[4].HeaderText = "Возраст";
            personDGV.Columns[6].HeaderText = "Рост";
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            genre g = new genre("Новый жанр");
            DBContext.context.genre.Add(g);
            DBContext.context.SaveChanges();
            fillGenreDGV();
        }

        private void deleteGenreButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                for (int i = 0; i < genreDGV.SelectedRows.Count; i++)
                {
                    DBContext.context.genre.Remove(DBContext.context.genre.Find(genreDGV.SelectedRows[i].Cells[0].Value));
                }
                DBContext.context.SaveChanges();
                fillGenreDGV();
            }
        }

        private void saveChangesGenreButton_Click(object sender, EventArgs e)
        {
            DBContext.context.SaveChanges();
        }

        private void addPostButton_Click(object sender, EventArgs e)
        {
            post p = new post("Новая должность");
            DBContext.context.post.Add(p);
            DBContext.context.SaveChanges();
            fillPostDGV();
        }

        private void saveChangesPostButton_Click(object sender, EventArgs e)
        {
            DBContext.context.SaveChanges();
        }

        private void deletePostButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                for (int i = 0; i < postDGV.SelectedRows.Count; i++)
                {
                    DBContext.context.post.Remove(DBContext.context.post.Find(postDGV.SelectedRows[i].Cells[0].Value));
                }
                DBContext.context.SaveChanges();
                fillPostDGV();
            }
        }

        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                for (int i = 0; i < personDGV.SelectedRows.Count; i++)
                {
                    DBContext.context.person.Remove(DBContext.context.person.Find(personDGV.SelectedRows[i].Cells[0].Value));
                }
                DBContext.context.SaveChanges();
                fillPersonDGV();
            }
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            person p = new person("Имя", "Отчество", "Фамилия", 0, 1, 0);
            DBContext.context.person.Add(p);
            DBContext.context.SaveChanges();
            fillPersonDGV();
        }

        private void saveChangesPersonButton_Click(object sender, EventArgs e)
        {
            changePerson(Convert.ToInt64(personDGV.SelectedRows[0].Cells[0].Value));
        }
        private void changePerson(long id)
        {
            PersonForm form = new PersonForm(id);
            form.Show();
        }

        private void personDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            changePerson(Convert.ToInt64(personDGV.SelectedRows[0].Cells[0].Value));
        }
    }
}
