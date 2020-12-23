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
    public partial class FilmForm : Form
    {
        private long id;
        private long[] genreId;
        private long[] personId;
        private int[] postId;
        public FilmForm()
        {
            InitializeComponent();
            if (!DBContext.isFullAccess())
                block();
            else
                unblock();
            feedbackButton.Visible = false;
        }
        public FilmForm(long id)
        {
            InitializeComponent();
            if (!DBContext.isFullAccess())
                block();
            else
                unblock();
            this.id = id;
            feedbackButton.Visible = true;
            fillForm();
        }
        private void fillForm()
        {
            film f = DBContext.context.film.Find(id);
            filmName.Text = f.name;
            filmDescription.Text = f.description;
            filmDuration.Value = f.duration;
            filmTallage.Value = f.tallage;
            fillGenreDGV();
            fillPersonDGV();
            genreId = new long[DBContext.context.genre.Count()];
            int i = 0;
            foreach (genre g in DBContext.context.genre)
            {
                genreId[i] = g.id;
                genreCB.Items.Add(g.name);
                i++;
            }
            postId = new int[DBContext.context.post.Count()];
            i = 0;
            foreach (post p in DBContext.context.post)
            {
                postId[i] = p.id;
                postCB.Items.Add(p.name);
                i++;
            }
            personId = new long[DBContext.context.person.Count()];
            i = 0;
            foreach (person p in DBContext.context.person)
            {
                personId[i] = p.id;
                personCB.Items.Add(p.ToString());
                i++;
            }
        }
        private void fillGenreDGV()
        {
            film f = DBContext.context.film.Find(id);
            int i = 0;
            foreach (genre g in f.genre)
            {
                if (filmGenre.Rows.Count < f.genre.Count)
                    filmGenre.Rows.Add();
                else if (filmGenre.Rows.Count > f.genre.Count)
                    filmGenre.Rows.RemoveAt(filmGenre.Rows.Count - 1);
                filmGenre.Rows[i].Cells[0].Value = g.id;
                filmGenre.Rows[i].Cells[1].Value = g.name;
                i++;
            }
        }
        public void fillPersonDGV()
        {
            filmPerson.DataSource = (from pf in DBContext.context.person_film
                                     join per in DBContext.context.person on pf.person_id equals per.id
                                     join p in DBContext.context.post on pf.post_id equals p.id
                                     where pf.film_id == id
                                     select new { per.id, per.last_name, per.first_name, p.name }).ToList();
        }
        private void feedbackButton_Click(object sender, EventArgs e)
        {
            FeedbackForm form = new FeedbackForm(id);
            form.Show();
        }

        private void filmPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PersonForm form = new PersonForm(Convert.ToInt64(filmPerson.Rows[e.RowIndex].Cells[0].Value));
            form.Show();
        }
        private void block()
        {
            filmName.ReadOnly = filmDescription.ReadOnly = true;
            filmDuration.Enabled = filmTallage.Enabled = sveButton.Visible = false;
        }
        private void unblock()
        {
            filmName.ReadOnly = filmDescription.ReadOnly = false;
            filmDuration.Enabled = filmTallage.Enabled = true;
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            DBContext.context.film.Find(id).genre.Add(DBContext.context.genre.Find(genreId[genreCB.SelectedIndex]));
            DBContext.context.SaveChanges();
            fillGenreDGV();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            DBContext.context.person_film.Add(new person_film(id, personId[personCB.SelectedIndex], postId[postCB.SelectedIndex]));
            DBContext.context.SaveChanges();
            fillPersonDGV();
        }

        private void deleteGenreButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                for (int i = 0; i < filmGenre.SelectedRows.Count; i++)
                {
                    DBContext.context.film.Find(id).genre.Remove(DBContext.context.genre.Find(filmGenre.SelectedRows[i].Cells[0].Value));
                }
                DBContext.context.SaveChanges();
                fillGenreDGV();
            }
        }

        private void sveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    DBContext.context.film.Add(new film(filmName.Text, filmDescription.Text, (short)filmDuration.Value, (long)filmTallage.Value));
                }
                else
                {
                    DBContext.context.film.Find(id).Update(filmName.Text, filmDescription.Text, (short)filmDuration.Value, (long)filmTallage.Value);
                }
                DBContext.context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка добавления(изменения): " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                for (int i = 0; i < filmPerson.SelectedRows.Count; i++)
                {
                    long perId = (long)filmPerson.SelectedRows[i].Cells[0].Value;
                    string postName = filmPerson.SelectedRows[i].Cells[filmPerson.ColumnCount - 1].Value.ToString();
                    DBContext.context.person_film.Remove(DBContext.context.person_film.Find((from pf in DBContext.context.person_film
                                                                                             join p in DBContext.context.post on pf.post_id equals p.id
                                                                                             where pf.person_id == perId &&
                                                                                             pf.film_id == id && p.name == postName
                                                                                             select pf.id).FirstOrDefault()));
                }
                DBContext.context.SaveChanges();
                fillPersonDGV();
            }
        }
    }
}
