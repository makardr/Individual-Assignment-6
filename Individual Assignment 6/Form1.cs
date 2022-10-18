using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_6
{
    public partial class Form1 : Form
    {
        int current_number;
        public Form1()
        {
            InitializeComponent();
        }


        public int generate_random_number()
        {
            Random rnd = new Random();
            int random_number = rnd.Next(1, 4);
            return random_number;
        }
        public void start_new_game()
        {
            current_number = generate_random_number();
        }

        private void rock_btn_Click(object sender, EventArgs e)
        {
            if (current_number==1) {
                MessageBox.Show("You won");
            }
            else
            {
                MessageBox.Show("You lose");
            }
            start_new_game();
        }

        private void paper_btn_Click(object sender, EventArgs e)
        {
            if (current_number == 2)
            {
                MessageBox.Show("You won");
            }
            else
            {
                MessageBox.Show("You lose");
            }
            start_new_game();
        }

        private void scissors_btn_Click(object sender, EventArgs e)
        {
            if (current_number == 3)
            {
                MessageBox.Show("You won");
            }
            else
            {
                MessageBox.Show("You lose");
            }
            start_new_game();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start_new_game();
        }
    }
}
