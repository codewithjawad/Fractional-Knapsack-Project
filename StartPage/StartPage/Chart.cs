using LiveCharts.Wpf;
using LiveCharts;
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
    public partial class Chart : Form
    {
        public Chart(string[] items, double[] weight, double[] benifit)
        {
            Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} : ({1:P})", chartpoint.Instance, chartpoint.Participation);
            InitializeComponent();
            try
            {
                for (int i = 0; i < items.Length; i++)
                {
                    pieChart3.Series.Add(new PieSeries
                    {
                        Title = items[i],
                        Values = new ChartValues<double>() { (int)weight[i] },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    });

                    pieChart1.Series.Add(new PieSeries
                    {
                        Title = items[i],
                        Values = new ChartValues<double>() { (int)benifit[i] },
                        DataLabels = true,
                        LabelPoint = labelPoint
                    });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter data to view Charts values");

            }
        }
        public Chart()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Chart_Load(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
