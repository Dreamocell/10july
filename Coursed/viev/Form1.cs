using Coursed.viev;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_start_MouseHover(object sender, EventArgs e)
        {
            label_start.Font = new Font(label_start.Font, FontStyle.Bold);
        }

        private void label_information_MouseHover(object sender, EventArgs e)
        {
            label_start.Font = new Font(label_start.Font, FontStyle.Bold);
        }

        private void label_exit_MouseHover(object sender, EventArgs e)
        {
            label_start.Font = new Font(label_start.Font, FontStyle.Bold);
        }

        private void label_start_MouseLeave(object sender, EventArgs e)
        {
            label_start.Font = new Font(label_start.Font, FontStyle.Bold);
        }

        private void label_information_MouseLeave(object sender, EventArgs e)
        {
            label_start.Font = new Font(label_start.Font, FontStyle.Bold);
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_start.Font = new Font(label_start.Font, FontStyle.Bold);
        }

        private void label_start_Click(object sender, EventArgs e)
        {
            Form2 result = new Form2();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }

        private void label_information_Click(object sender, EventArgs e)
        {
            Form3 result = new Form3();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }
    }
}
