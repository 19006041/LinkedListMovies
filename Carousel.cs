using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedListMovies
{
    public partial class Carousel : Form
    {

        Movie current;
        public Carousel()
        {
            InitializeComponent();
        }

        private void Carousel_Load(object sender, EventArgs e)
        {
            current = ListUtil.movieList.getHead();
            txbMovie.Text = current.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            current = ListUtil.movieList.getNext();
            txbMovie.Text = current.ToString();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int index = r.Next(0, ListUtil.movieList.Size());
            MessageBox.Show("Index: " + index + " - Movie Data: " + ListUtil.movieList[index].ToString());

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            current = ListUtil.movieList.getPrevious();
            txbMovie.Text = current.ToString();
        }
    }
}
