using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsKeyBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyValue.ToString());
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left -= 10;
            }
            if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Top -= 10;
            }
            if (e.KeyCode == Keys.Right)
            {   
                pictureBox1.Left += 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seriesName1 = "stock";
            Series ser1 = chart1.Series.Add(seriesName1);
            ser1.Points.AddXY(1, 44);
            ser1.Points.AddXY(2, 14);
            ser1.Points.AddXY(3, 144);
            ser1.ChartType = SeriesChartType.Line;
        }
    }
}
