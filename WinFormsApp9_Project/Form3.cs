using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WinFormsApp9_Project
{
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VS6LDVR\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        bool gameOver = false;
        public Form3()
        {
            InitializeComponent();
            
        }

        public void setBird(PictureBox pictureBox)
        {
            
            flappyBird = pictureBox;
        }
        
        public void ReplacePictureBox(PictureBox pictureBox)
        {
            
            this.Controls.Remove(flappyBird);
            this.Controls.Add(pictureBox);
            pictureBox.Location = flappyBird.Location;
            flappyBird = pictureBox;
        }



        public void setPipeSpeed(int speed)
        {
            pipeSpeed = speed;
        }

       



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void timerEvent(object sender, EventArgs e)
        {
            
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            Form1 form = new Form1();

            scoreText.Text = "Score:" + score.ToString();

            if (pipeBottom.Left < -50)
            {
                pipeBottom.Left = 700;
                score++;
            }
            if (pipeTop.Left < -60)
            {
                pipeTop.Left = 750;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();

                conn.Open();

                int highestScore = Convert.ToInt32(score.ToString());
                string username = Form1.text;
                string sql = "UPDATE LoginGame SET highestScore = @highestScore WHERE username = @username AND highestScore < @highestScore";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@highestScore", highestScore);
                command.Parameters.AddWithValue("@username", username);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Row updated");
                }
                conn.Close();
            }

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

            if (e.KeyCode == Keys.R && gameOver)
            {
                restartGame();
            }

            if (e.KeyCode == Keys.X && gameOver)
            {
                Environment.Exit(1);
            }
        }


        private void Restart(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {

            }

        }
        private void endGame()
        {
            timer.Stop();
            gameOver = true;
            scoreText.Text += "Game over!! PRESS R TO RESTART || PRESS X TO EXIT THE GAME";

        }

        private void restartGame()
        {
            gameOver = false;
            flappyBird.Location = new Point(109, 170);
            pipeTop.Left = 750;
            pipeBottom.Left = 700;
            score = 0;
            pipeSpeed = 8;
            scoreText.Text = "Score: 0";
            timer.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer.Start();
        }
    }


}
