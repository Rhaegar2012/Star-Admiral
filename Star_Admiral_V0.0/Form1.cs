using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Star_Admiral_V0._0
{
    public partial class Form1 : Form
    {

        Admiral Player;
        Enemy Enemy;
        Ship selectedShip;
        Board BattleBoard;
        PictureBox[] playerSprites = new PictureBox[1];
        PictureBox[] enemySprites = new PictureBox[1];
        public Form1()
        {
            InitializeComponent();
            BattleBoard = new Board();
            BattleBoard.CreateNodes();
            BattleBoard.createNodeNeighbors();
            playerSprites[0] = playerPictureBox;
            enemySprites[0] = enemyPictureBox;
            Player = new Admiral(BattleBoard, 1, 3,playerSprites,playerShipHlt);
            Player.createFleet();
            Enemy = new Enemy(BattleBoard,1,3,enemySprites,Player,enemyShipHlt);
            Enemy.createFleet();
            timer1.Start();
           
            
        }

        //Updates player ship stats when chip si clicked
        public void updateStatsLabel(Ship selectedShip)
        {
            if (selectedShip.MyAdmiral.Equals(Player))
            {
                
                playerShipName.Text = "Name "+selectedShip.name;
                playerShipAtk.Text ="Attack: "+selectedShip.attack_power;
                playerShipDef.Text ="Defense: "+ selectedShip.defense_power;
                playerShipHlt.Text ="Health: "+ selectedShip.health;
            }
            else
            {
                enemyShipName.Text = "Name " + selectedShip.name;
                enemyShipAtk.Text = "Attack: " + selectedShip.attack_power;
                enemyShipDef.Text = "Defense: " + selectedShip.defense_power;
                enemyShipHlt.Text="Health: "+selectedShip.health;
            }
        }
        //Updates the enemy ship stats when the ship is acquired
        public void updateEnemyStatsLabels(Ship acquiredShip)
        {
            ProxAlert.Text = "ENEMY FOUND!";
            enemyShipName.Text = "Name " + acquiredShip.name;
            enemyShipAtk.Text = "Attack: " + acquiredShip.attack_power;
            enemyShipDef.Text = "Defense: " + acquiredShip.defense_power;
            enemyShipHlt.Text = "Health: " + acquiredShip.health;
        }

        private void playerPictureBox_Click(object sender, EventArgs e)
        {
            
            foreach(Ship ship in Player.fleet)
            {

                if (playerPictureBox.Equals(ship.MyPictureBox))
                {
                    
                    updateStatsLabel(ship);
                    selectedShip = ship;
                    
                }
            }
            
            
        }
        

        private void UpButton_Click(object sender, EventArgs e)
        {
            string direction = "vertical";
            string orientation = "positive";
            Player.moveShip(direction, orientation, selectedShip);
            if (Player.shipFound)
            {
                updateEnemyStatsLabels(Player.shipAcquired);
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            string direction = "horizontal";
            string orientation = "negative";
            Player.moveShip(direction, orientation, selectedShip);
            if (Player.shipFound)
            {
                updateEnemyStatsLabels(Player.shipAcquired);
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            string direction = "horizontal";
            string orientation = "positive";
            Player.moveShip(direction, orientation, selectedShip);
            if (Player.shipFound)
            {
                updateEnemyStatsLabels(Player.shipAcquired);
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            string direction = "vertical";
            string orientation = "negative";
            Player.moveShip(direction, orientation, selectedShip);
            if (Player.shipFound)
            {
                updateEnemyStatsLabels(Player.shipAcquired);
            }
        }

        private void pass_Button_Click(object sender, EventArgs e)
        {
            Enemy.movements_left = 5;
            Enemy.EnemyTurn();
            checkEndgame();
            pass_Button.Enabled = false;
            UpButton.Enabled = true;
            DownButton.Enabled = true;
            LeftButton.Enabled = true;
            RightButton.Enabled = true;
            fireButton.Enabled = true;
            Player.movements_left = 3;
            timer1.Start();
        }
        private bool noMoreMoves()
        {
            Console.WriteLine("checking movement left" + Player.movements_left.ToString());
            if (Player.movements_left == 0)
            {
                timer1.Stop();
                MessageBox.Show("No movements left");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (noMoreMoves())
            {
                UpButton.Enabled = false;
                DownButton.Enabled = false;
                LeftButton.Enabled = false;
                RightButton.Enabled = false;
                fireButton.Enabled = false;
                pass_Button.Enabled = true;
            }
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            Player.Attack(selectedShip);
            updateStatsLabel(selectedShip.shipAcquired);
            checkEndgame();
        }
        private bool checkEndgame()
        {
            Ship playerShip = (Ship) Player.fleet[0];
            Ship enemyShip = (Ship)Enemy.fleet[0];
            Console.WriteLine("Checking game completion");
            if (playerShip.health>0 && enemyShip.health <= 0)
            {
                MessageBox.Show("You win!", "Endgame");
                Console.Write("Player loses");
                return true;
            }
            else if (playerShip.health<=0 && enemyShip.health > 0)
            {
                MessageBox.Show("You loose!, try again", "Endgame");
                Console.Write("Enemy loses");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
