using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StartPage
{
    public class knapsack
    {
        public string name;
        public string weight;
        public string value;
        public string[] gname;
        public double[] gweight;
        public double[] gvalue;
        public double[] sel_weight;
        public double[] sel_ben;
        public double[] item_per;
        public double[] val_per;
        int len;
        double[] ratio;
        int knap;
        private bool isHeightIncreased = false;
        private Form1 f1;
        
        public knapsack( Form1 form1)
        {
            f1= form1;
        }
        
        public void Calculate()
        {
           
            try
            {
                knap = int.Parse(f1.MyTextBox.Text);
                name = f1.tbname1.Text;
                gname = name.Split(',').ToArray();
                weight = f1.tbweight1.Text;
                gweight = weight.Split(',').Select(double.Parse).ToArray();
                value = f1.tbvalue1.Text;
                gvalue = value.Split(',').Select(double.Parse).ToArray();
                len = gname.Length;
                ratio = new double[len];
                f1.table.Rows.Clear();

                for (int i = 0; i < len; i++)
                {
                    f1.table.Rows.Add();
                }

                for (int i = 0; i < len; i++)
                {
                    ratio[i] = gvalue[i] / gweight[i];
                }

                int j = 0;
                while (j < len)
                {
                    f1.table.Rows[j].Cells[0].Value = gname[j];
                    f1.table.Rows[j].Cells[1].Value = gweight[j];
                    f1.table.Rows[j].Cells[2].Value = gvalue[j];
                    f1.table.Rows[j].Cells[3].Value = ratio[j];
                    j++;
                }
                fill();

                f1.table.Show();
                if (!isHeightIncreased)
                {
                    f1.Height += f1.table.Height;
                    isHeightIncreased = true;
                }
            }
            catch (Exception)
            {
                f1.msg1.ToString();
            }
        }

        public int highest()
        {
            double highest = 0;
            int index = -1;
            for (int i = 0; i < len; i++)
            {
                if (ratio[i] > highest)
                {
                    highest = ratio[i];
                    index = i;
                }
            }
            return index;
        }
        public void fill()
        {
            int[] itemarray = new int[len];
            double tem_weight, temp_benefit;
            sel_weight = new double[len];
            sel_ben = new double[len];
            int ind = 0;
            double cw = 0, cb = 0;
            while (cw < knap)
            {
                int item = highest();
                if (item == -1)
                {
                    break;

                }
                itemarray[ind] = (item + 1);
                ind++;
                if (cw + gweight[item] <= knap)
                {
                    tem_weight = gweight[item];
                    sel_weight[item] = tem_weight;
                    temp_benefit = gvalue[item];
                    sel_ben[item] = temp_benefit;
                    cw += tem_weight;
                    cb += temp_benefit;
                    ratio[item] = 0;
                }
                else
                {
                    temp_benefit = ratio[item] * (knap - cw);
                    sel_ben[item] = temp_benefit;
                    tem_weight = knap - cw;
                    sel_weight[item] = tem_weight;
                    cw += tem_weight;
                    cb += temp_benefit;
                    f1.msg2.ToString();
                    break;

                }
            }
            f1.label7t.Text = (cw + " Kg").ToString();
            f1.label9t.Text = (cb + " Rs").ToString();


            val_per = new double[len];
            item_per = new double[len];
            for (int i = 0; i < len; i++)
            {
                val_per[i] = (sel_ben[i] / cb) * 100;
                item_per[i] = (sel_weight[i] / cw) * 100;
            }


            int j = 0;
            while (j < len)
            {

                f1.table.Rows[j].Cells[4].Value = sel_weight[j].ToString();
                f1.table.Rows[j].Cells[5].Value = sel_ben[j].ToString();
                f1.table.Rows[j].Cells[6].Value = item_per[j].ToString();
                f1.table.Rows[j].Cells[7].Value = val_per[j].ToString();
                j++;
            }
        }
    }
}
