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
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Movie m = new Movie(Convert.ToInt32(txtId.Text), txtName.Text, Convert.ToInt32(txtYear.Text), Convert.ToDouble(txtRating.Text));
            
            txtId.Clear();
            txtName.Clear();
            txtRating.Clear();
            txtYear.Clear();

           
            ListUtil.movieList.Append(m);
           
        
            UpdateOutput();
        }

        private void btnCarousel_Click(object sender, EventArgs e)
        {
            if (ListUtil.movieList.IsEmpty())
            {
                MessageBox.Show("Error - Please add a movie First");
            }
            else
            {
                Carousel carousel = new Carousel();
                //this.Hide();
                carousel.ShowDialog();
                this.Show();
            }
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            Movie m = new Movie(1, "Shrek", 2001, 5);
            ListUtil.movieList.Append(m);         
            ListUtil.movieList.Append(new Movie(2, "Batman Dark Knight", 2008, 5));
            UpdateOutput();
        }

        public void UpdateOutput()
        {
            txbOutput.Clear();
            txbOutput.Text += "Size: " + ListUtil.movieList.Size() + Environment.NewLine;


            Movie n = ListUtil.movieList.getHead();
            int size = ListUtil.movieList.Size();

            for (int i = 0; i< size; i++)
            {
               
                txbOutput.Text += n.ToString() + Environment.NewLine;
                n = ListUtil.movieList.getNext();
               
            }
            



        }
    }
}
