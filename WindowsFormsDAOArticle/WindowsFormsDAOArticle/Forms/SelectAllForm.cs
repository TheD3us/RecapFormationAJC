using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDAOArticle.Model;
using WindowsFormsDAOArticle.DAO;

namespace WindowsFormsDAOArticle.Forms
{
    public partial class SelectAllForm : Form
    {
        public SelectAllForm()
        {
            InitializeComponent();
        }

        private void SelectAllForm_Load(object sender, EventArgs e)
        {
            List<Article> ListArticle = new DAO.DAOArticle().selectAll();
            
            foreach (Article a in ListArticle )
            {
                LBListeArticle.Items.Add(a.Id + " " + a.Marque + " " + a.Prix);
            }
        }
    }
}
