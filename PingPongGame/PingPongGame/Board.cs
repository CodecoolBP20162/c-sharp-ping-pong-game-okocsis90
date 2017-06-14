using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Board : Form
    {
        private int playerSpeed = 10;

        private int ballVelX = 5;
        private int ballVelY = 5;
        private int playerVelX;

        private int score;
        private int level = 1;
        private int levelChange = 2;

        private bool pause;

        public Board()
        {
            InitializeComponent();
        }

        private void Board_Load(object sender, EventArgs e)
        {
            scoreLabel.Text = score.ToString();
            levelLabel.Text = level.ToString();
        }

        private void Board_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                playerVelX = -playerSpeed;
            }
            else if (e.KeyCode == Keys.Right)
            {
                playerVelX = playerSpeed;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.Space)
            {
                if (!pause)
                {
                    pause = true;
                }
                else
                {
                    pause = false;
                }

            }
        }

        private void Board_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                playerVelX = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                playerVelX = 0;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!pause)
            {
                ball.Location = new Point(ball.Location.X + ballVelX, ball.Location.Y + ballVelY);
                player.Location = new Point(player.Location.X + playerVelX, player.Location.Y);
            }

            if (ball.Location.Y + ball.Height >= Size.Height)
            {
                pause = true;
                ball.Location = new Point(Width / 2, Height / 2);
                MessageBox.Show("Your score was: " + score);
                score = 0;
                scoreLabel.Text = score.ToString();
            }

            if (ball.Location.X + ball.Width >= player.Location.X &&
                ball.Location.X < player.Location.X + player.Width &&
                ball.Location.Y + ball.Height >= player.Location.Y &&
                ball.Location.Y + ball.Height < player.Location.Y + 2)
            {
                ballVelY *= -1;
                score += 1;
                scoreLabel.Text = score.ToString();
                levelProgress.Value += 100/levelChange;

                if (score % levelChange == 0)
                {
                    pause = true;
                    ball.Location = new Point(Width / 2, Height / 2);
                    MessageBox.Show("LEVEL UP");
                    level += 1;
                    levelLabel.Text = level.ToString();
                    levelProgress.Value = 0;
                }
            }

            if (ball.Location.Y <= 0)
            {
                ballVelY *= -1;
            }

            if (ball.Location.X <= 0 || ball.Location.X + ball.Width * 2 >= Width)
            {
                ballVelX *= -1;
            }
        }
    }
}
