using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveMgmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar Collector", "Honey Manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg Care", "Baby Bee Tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive Maintenance", "Sting Patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar Collector", "Honey Manufacturing", "Egg Care", "Baby Bee Tutoring", "Hive Maintenance", "Sting Patrol" }, 155);
            queen = new Queen(workers, 275);
        }

        private Queen queen; 

        private void jobAssign_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)numericUpDown1.Value) == false)
                MessageBox.Show("No workers are available to do this job '" + workerBeeJob.Text + "'", "The queen bee says...");
            else
                MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in " + numericUpDown1.Value + " shifts", "The queen bee says ...");
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

        private void workerBeeJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
