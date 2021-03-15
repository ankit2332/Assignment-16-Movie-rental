using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_16_Movie_rental
{
    public partial class Form1 : Form
    {
        Movie[] movies;
        public Form1()
        {
            InitializeComponent();
            movies = new Movie[]
            {
                new Movie("Men in Black", 120),
                new Movie("Avatar", 110),
                new Movie("Forrest Gump", 100),
                new Movie("Sexy Beast", 130)
            };
            addmovie();

        }
        public void addmovie()
        {
            for (int i = 0; i < movies.Length; i++)
            {
                string name = movies[i].getname();
                moviepicker.Items.Add(name);
            }
        }

        private void moviepicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = moviepicker.SelectedIndex;

            Movie chosenmovie = movies[i];
            movienamelabel.Text = chosenmovie.getname();
            lenghtlabel.Text = chosenmovie.getlength().ToString();
            availablelabel.Text = chosenmovie.isavailable().ToString();
        }

        private void borrowbutton_Click(object sender, EventArgs e)
        {
            int i = moviepicker.SelectedIndex;
            Movie chosenmovie = movies[i];

            chosenmovie.borrowmovie();
            availablelabel.Text = chosenmovie.isavailable().ToString();
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            int i = moviepicker.SelectedIndex;
            Movie chosenmovie = movies[i];

            chosenmovie.returnmovie();
            availablelabel.Text = chosenmovie.isavailable().ToString();
        }
    }
   
}
