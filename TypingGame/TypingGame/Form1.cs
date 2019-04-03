using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Add a random key to the ListBox
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();
                tryAgain.Visible = true;

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {    //if the user pressed a key that's in the listbox, remove it
            //and then make the game a little faster
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;


                //The user pressed the correct key, so update the stats object
                //by calling its Update() method with the argument true
                stats.Update(true);
            }
            else
            {
                //The user pressed the incorrect key, so update the stats object
                //by calling its Update() method with the argument False
                stats.Update(false);
            }

            //Update the labels on the Status Strip

            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Incorrect: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (listBox1.Text != "Game Over")
            {
                
                Application.Restart();
            } 
            else
            {
                Application.Exit();
            }
        }
    }
}
