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
        private int levelChange = 3;

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

        private void InitializeBall()
        {
            pause = true;
            ball.Location = new Point(Width / 2, Height / 2);
        }

        private void LoseCurrentMatch()
        {
            InitializeBall();
            MessageBox.Show("Your score was: " + score);
            score = 0;
            scoreLabel.Text = score.ToString();
        }

        private void BallTouchesPlayer()
        {
            ballVelY *= -1;
            score += 1;
            scoreLabel.Text = score.ToString();
        }

        private void ShowLevelInformation()
        {
            if (level < 10)
            {
                MessageBox.Show("LEVEL UP");
            }
        }

        private void ShowIfWon()
        {
            if (level == 10)
            {
                MessageBox.Show("You won");
                Close();
            }
        }

        private void MakeMoreDifficult()
        {
            if (level > 5)
            {
                player.Width -= 10;
            }
            else
            {
                if (ballVelX < 0)
                {
                    ballVelX -= 2;
                }
                else
                {
                    ballVelX += 2;
                }
                ballVelY -= 2;
            }
        }

        private void PrepareGift()
        {
            if (level == 5)
            {
                gift.Visible = true;
            } else if (level == 6)
            {
                gift.Visible = false;
            }
            
        }

        private void LevelGoesUp()
        {
            levelProgress.Value = 100;
            InitializeBall();
            level += 1;
            levelLabel.Text = level.ToString();
            ShowLevelInformation();
            ShowIfWon();
            levelProgress.Value = 0;
            MakeMoreDifficult();
            PrepareGift();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (!pause)
            {
                ball.Location = new Point(ball.Location.X + ballVelX, ball.Location.Y + ballVelY);
                player.Location = new Point(player.Location.X + playerVelX, player.Location.Y);
                if (gift.Visible)
                {
                    gift.Location = new Point(gift.Location.X, gift.Location.Y + 5);
                }
            }

            if (player.Bounds.IntersectsWith(gift.Bounds))
            {
                player.Width += 20;
                gift.Location = new Point(0, 0);
                gift.Visible = false;
            }

            if (gift.Location.Y + gift.Height >= Height)
            {
                gift.Location = new Point(0, 0);
                gift.Visible = false;
            }

            if (player.Bounds.IntersectsWith(ball.Bounds))
            {
                BallTouchesPlayer();
                if (score % levelChange == 0)
                {
                    LevelGoesUp();
                }
                else
                {
                    try
                    {
                        levelProgress.Value += 100 / levelChange;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        levelProgress.Value = 100;
                    }
                }
            }

            if (ball.Location.Y + ball.Height >= Size.Height)
            {
                LoseCurrentMatch();
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
