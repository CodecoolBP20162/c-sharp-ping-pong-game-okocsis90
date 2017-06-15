namespace PingPongGame
{
    partial class Board
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.levelProgress = new System.Windows.Forms.ProgressBar();
            this.ball = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.gift = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(513, 30);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(10, 13);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Level";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(16, 29);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(10, 13);
            this.levelLabel.TabIndex = 5;
            this.levelLabel.Text = "-";
            // 
            // levelProgress
            // 
            this.levelProgress.Location = new System.Drawing.Point(19, 46);
            this.levelProgress.Name = "levelProgress";
            this.levelProgress.Size = new System.Drawing.Size(100, 23);
            this.levelProgress.TabIndex = 6;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.GrayText;
            this.ball.Location = new System.Drawing.Point(287, 182);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(12, 13);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.GrayText;
            this.player.Location = new System.Drawing.Point(228, 375);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(123, 15);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // gift
            // 
            this.gift.Image = global::PingPongGame.Properties.Resources.gift;
            this.gift.Location = new System.Drawing.Point(384, 13);
            this.gift.Name = "gift";
            this.gift.Size = new System.Drawing.Size(40, 39);
            this.gift.TabIndex = 7;
            this.gift.TabStop = false;
            this.gift.Visible = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 420);
            this.Controls.Add(this.gift);
            this.Controls.Add(this.levelProgress);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Name = "Board";
            this.Text = "PingPong 3000";
            this.Load += new System.EventHandler(this.Board_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Board_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Board_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.ProgressBar levelProgress;
        private System.Windows.Forms.PictureBox gift;
    }
}

