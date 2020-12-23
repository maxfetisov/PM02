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
    public partial class FilmListForm : Form
    {
        public FilmListForm()
        {
            InitializeComponent();
            fillFilmListDGV();
            if (!DBContext.isFullAccess())
                block();
            else
                unblock();
        }

        private void block()
        {
            addButton.Visible = deleteButton.Visible = otherTables.Visible = false;
            changeButton.Text = "Просмотреть";
        }
        private void unblock()
        {
            addButton.Visible = deleteButton.Visible = otherTables.Visible = true;
            changeButton.Text = "Изменить";
        }
        private void fillFilmListDGV()
        {
            filmListDGV.DataSource = (from f in DBContext.context.film
                                      select new { f.id, f.name, f.description, f.duration, f.tallage }).ToList();
            filmListDGV.Columns[0].Visible = false;
            filmListDGV.Columns[1].HeaderText = "Название";
            filmListDGV.Columns[2].HeaderText = "Описание";
            filmListDGV.Columns[3].HeaderText = "Длительность";
            filmListDGV.Columns[4].HeaderText = "Сборы";
        }

        private void filmListDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FilmForm f = new FilmForm(Convert.ToInt64(filmListDGV.Rows[e.RowIndex].Cells[0].Value));
            f.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                for (int i = 0; i < filmListDGV.SelectedRows.Count; i++)
                {
                    DBContext.context.film.Remove(DBContext.context.film.Find(filmListDGV.SelectedRows[i].Cells[0].Value));
                }
                DBContext.context.SaveChanges();
            }
            fillFilmListDGV();
        }

        private void otherTables_Click(object sender, EventArgs e)
        {
            OtherTablesForm form = new OtherTablesForm();
            form.Show();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            FilmForm f = new FilmForm(Convert.ToInt64(filmListDGV.SelectedRows[0].Cells[0].Value));
            f.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FilmForm f = new FilmForm();
            f.Show();
        }
    }
}

