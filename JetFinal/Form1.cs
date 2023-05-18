using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetFinal
{
    public partial class JetGame : Form
    {

        Player player=new Player();

        bool Shooting=false, IsGameOver;
        int score;
        int PlayerSpeed = 20;
        int enemySpeed;
        int BulletSpeed=10;
        Random random = new Random();
        public JetGame()
        {
            InitializeComponent();
            ResetGame();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            if(player.GetLeft() && Hero.Left >0)
            {
                Hero.Left -= PlayerSpeed;
            }
            if(player.GetRight() && Hero.Left<750)
            {
                Hero.Left += PlayerSpeed;
            }
            if (Shooting == true)
            {
                pictureBox2.Left = Hero.Left;
                pictureBox2.Top -= BulletSpeed;
                if (Shooting == false)
                {
                    pictureBox2.Top -= BulletSpeed;
                }
                

            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                Shooting = false;
            if (e.KeyCode == Keys.Left)
            {
                player.SetLeft(false);
            }
            if (e.KeyCode == Keys.Right)
            {
                player.SetRight(false);
            }

        }

        //private void JetGame_Load(object sender, EventArgs e)
        //{

        //}

        //private void pictureBox3_Click(object sender, EventArgs e)
        //{

        //}

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                player.SetLeft(true);
            }
            if(e.KeyCode==Keys.Right)
            {
                player.SetRight(true); 
            }
            if (e.KeyCode == Keys.Space)
                Shooting = true;
        }
        private void ResetGame()
        {
            gameTimer.Start();
        }

        private void GameOver()
        {

        }
    }
}
