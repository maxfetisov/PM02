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
    public partial class FeedbackForm : Form
    {
        private long filmId;
        public FeedbackForm(long id)
        {
            InitializeComponent();
            if (DBContext.isFullAccess())
                block();
            else
                unblock();
            filmId = id;
            fillFeedbackDGV();
            fillFeedbackTemplate();
        }
        private void fillFeedbackDGV()
        {
            using (film_serviceEntities context = new film_serviceEntities())
            {
                feedbackDGV.DataSource = (from f in context.feedback
                                          join u in context.user on f.user_login equals u.login
                                          where f.film_id == filmId
                                          select new { u.nickname, f.mark, f.text }).ToList();
            }
        }
        private void fillFeedbackTemplate()
        {
            using (film_serviceEntities context = new film_serviceEntities())
            {
                feedback fb = (from f in context.feedback
                               where f.user_login == DBContext.login && f.film_id == filmId
                               select f).FirstOrDefault();

                if (fb != null)
                {
                    mark.Value = fb.mark;
                    text.Text = fb.text;
                }
            }
        }
        private void addFeedbackButton_Click(object sender, EventArgs e)
        {
            addFeedback();
            fillFeedbackDGV();
        }
        private void addFeedback()
        {
            using (film_serviceEntities context = new film_serviceEntities())
            {
                feedback fb = new feedback(DBContext.login, filmId, mark.Value, text.Text);
                context.feedback.Add(fb);
                context.SaveChanges();
            }
        }
        private void deleteFeedbackButton_Click(object sender, EventArgs e)
        {
            if (DBContext.isFullAccess())
            {
                if (DialogResult.Yes == MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Предупреждение", MessageBoxButtons.YesNo))
                {
                    for (int i = 0; i < feedbackDGV.SelectedRows.Count; i++)
                    {
                        deleteFeedback(feedbackDGV.SelectedRows[i].Cells[0].Value.ToString());
                    }
                }
            }       
            else
                deleteFeedback(DBContext.login);
            fillFeedbackDGV();
        }
        private void deleteFeedback(string login) 
        {
            using (film_serviceEntities context = new film_serviceEntities())
            {
                context.feedback.Remove(context.feedback.Find(login, filmId));
                context.SaveChanges();
            }
        }
        private void block()
        {
            mark.Enabled = text.Enabled = addFeedbackButton.Enabled = false;
        }
        private void unblock()
        {
            mark.Enabled = text.Enabled = addFeedbackButton.Enabled = true;
        }
    }
}
