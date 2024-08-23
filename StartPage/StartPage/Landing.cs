using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPage
{
    public partial class Landing : Form
    {
        public Landing()
        {
            
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Width = 100;
            guna2HtmlLabel2.Width = 200;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Hide();
            f2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string instructions = "Follow these steps to use the application:\n\n" +
                      "1. Input the names of items you wish to include in the knapsack.\n" +
                      "   - The item name must consist of characters and items should be separated by commas (,).\n" +
                      "2. Input the value, and weight of each product.\n" +
                      "   - The value and weight should be separated by commas (,) and must be positive numbers.\n" +
                      "3. Enter the knapsack weight constraint, which must also be a positive number.\n" +
                      "4. Click the 'Calculate' button to run the Knapsack algorithm and find the optimal solution.\n" +
                      "5. The results, including the selected items and their total value, will be displayed on the screen in a table format.\n" +
                      "   - You can also view a live chart based on the selected items.\n" +
                      "6. Click the 'Clear' button to clear all data.";

            MessageBox.Show(instructions, "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
