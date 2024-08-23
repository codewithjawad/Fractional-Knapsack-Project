using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StartPage
{
    public partial class Form1 : Form
    {

        private knapsack k;
        public Form1()
        {
            k = new knapsack(this);
            InitializeComponent();
        }
        public TextBox MyTextBox
        {
            get { return textBox1; }
        }
        public TextBox tbname1
        {
            get { return tbname; }
        }
        public TextBox tbweight1
        {
            get { return tbweight; }
        }
        public TextBox tbvalue1
        {
            get { return tbvalue; }
        }
        public Label label7t
        {
            get { return label7; }
        }
        public Label label9t
        {
            get { return label9; }
        }
        public DataGridView table
        {
            get { return guna2DataGridView1; }
        }

        public DialogResult  msg1
        {
            get { return MessageBox.Show("Enter Values first"); }
        }

        public DialogResult msg2
        {
            get { return MessageBox.Show("Knapsack is Full");}
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbname.Text != "" && tbvalue.Text != "" && tbweight.Text != "" && textBox1.Text != "")
            {
            
            if (tbname.Text.Split(',').Any(name => name.All(char.IsDigit)))
            {
                MessageBox.Show("Item names must consist of characters, not numbers.");
                return;
            }

            bool isWeightValid = double.TryParse(tbweight.Text, out double weight) && weight > 0;
            bool isValueValid = double.TryParse(tbvalue.Text, out double value) && value > 0;
            bool isKnapsackCapacityValid = double.TryParse(textBox1.Text, out double knapsackCapacity) && knapsackCapacity > 0;

            if (isWeightValid && isValueValid && isKnapsackCapacityValid)
            {
                k.Calculate();
            }
            else
            {
                MessageBox.Show("Weights, values, and knapsack capacity must be positive numbers.");
            }

            }
            else
            {
                MessageBox.Show("Enter Values First");
            }
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.Rows.Count == 0 || guna2DataGridView1.Rows[0].IsNewRow)
            {
                MessageBox.Show("First Calculate values for viewing chart");
            }
            else
            {
                Chart c = new Chart(k.gname, k.item_per, k.val_per);
                c.Show();
            }


        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label7.Text == "0" && label9.Text == "0" && tbname.Text == "" && tbvalue.Text == "" && tbweight.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("Data Already Cleared");
            }
            else
            {
            tbname.Text = "";
            tbvalue.Text = "";
            tbweight.Text = "";
            textBox1.Text = "";
            label7.Text = "0";
            label9.Text = "0";
            guna2DataGridView1.Rows.Clear();
            MessageBox.Show("Data Cleared Successfully");

            }
            
        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Landing l1 = new Landing();
            l1 .Show();
        }
    }
}
