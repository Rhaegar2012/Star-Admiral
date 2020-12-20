using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Star_Admiral_V0._0
{
    public class Enemy : Admiral
    {
        private int FleetRow = 0;
        private int[] myFleetPositions = new int[1] { 1 };
        private PictureBox[] enemySprites = new PictureBox[1];
        private Admiral player;
        
        public Enemy(Board Board, int FleetSize, int MovementsLeft, PictureBox[] EnemySprites,Admiral Player,Label HealthLabel)
            : base(Board, FleetSize, MovementsLeft, EnemySprites,HealthLabel){
            //Enemy Constructor, in principle same as Admiral's
            player = Player;
            enemySprites = EnemySprites;
            }


        public override void createFleet()
        {
            Node shipNode = MyBoard.board[FleetRow, myFleetPositions[0]];
            for (int i = 0; i < fleet_size; i++)
            {
                //Locates the initial ship nodes in the board nodes array list
                Ship newShip = new Ship(shipNode, enemySprites[i], this);
                newShip.name = "Nicole";
                newShip.MyNode.shipPresent = true;
                newShip.MyNode.shipPlaced = newShip;
                newShip.MyPictureBox = this.enemySprites[i];
                this.fleet.Add(newShip);
                    
            }

        }
        //A* pathfinding algortihm
        private ArrayList DeterminesMovementDirection(Ship enemyShip,Ship PlayerShip)
        {
            Node enemyNode = enemyShip.MyNode;
            Node playerNode = PlayerShip.MyNode;
            Queue Frontier = new Queue();
            //Enemy agents scans the board
            Frontier.EnQueue(enemyNode);
            //C# Dictionary data structure
            Dictionary<Node, Node> cameFrom = new Dictionary<Node, Node>();
            cameFrom.Add(enemyNode, null);
            while (Frontier.Count()!= 0)
            {
                Node currentNode = (Node) Frontier.Peek();
                Frontier.DeQueue();
                foreach(Node neighbor in currentNode.neighbors)
                {
                    if (!cameFrom.ContainsKey(neighbor))
                    {
                        Frontier.EnQueue(neighbor);
                        cameFrom.Add(neighbor, currentNode);
                    }
                }
            }
            //Enemy Agent builds the path towards the player
            ArrayList path = new ArrayList();
            Node current = playerNode;
            while (!current.Equals(enemyNode))
            {
                path.Add(current);
                current = cameFrom[current]; 
            }
            return path;
        }
        public  void EnemyMove()
        {
            Ship enemyShip =(Ship) this.fleet[0];
            Console.WriteLine("Ship name: " + enemyShip.name);
            Console.WriteLine(enemyShip.MyPictureBox.ToString());
            //Enemy Ship node
            Console.WriteLine("Enemy initial node " + enemyShip.MyNode.X_coordinate + enemyShip.MyNode.Y_coordinate);
            Ship playerShip =(Ship) player.fleet[0];
            ArrayList movementPath = new ArrayList();
            movementPath = DeterminesMovementDirection(enemyShip, playerShip);
            Console.WriteLine("My path is " + movementPath.ToString());
            // Needs to be the length of the movement path 
            Node newNode =(Node) movementPath[movementPath.Count-1];
            Console.WriteLine("I'm going to move here " + newNode.X_coordinate + newNode.Y_coordinate);
            //Calculates movement distance
            int deltaX = (newNode.X_coordinate - enemyShip.MyNode.X_coordinate);
            int deltaY = (newNode.Y_coordinate - enemyShip.MyNode.Y_coordinate);

            //Updates ship node
            enemyShip.MyNode.shipPlaced = null;
            enemyShip.MyNode.shipPresent = false;
            enemyShip.MyNode = newNode;
            enemyShip.MyNode.shipPresent = true;
            enemyShip.MyNode.shipPlaced = enemyShip;
            //Moves ship on board
            enemyShip.MyPictureBox.Left += deltaX * 50;
            enemyShip.MyPictureBox.Top += deltaY * 50;
            //Acquires enemy ship
            this.scansBoard();
            if (checkIfShipAcquired())
            {
                MessageBox.Show("Enemy has acquired you!");
            }

            
        }
        public bool checkIfShipAcquired()
        {
            if (this.shipAcquired == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void EnemyTurn()
        {
            this.movements_left = 5;
            while (this.movements_left > 0)
            {
                if (checkIfShipAcquired())
                {
                    Ship selectedShip = (Ship)this.fleet[0];
                    Attack(selectedShip);
                    selectedShip.shipAcquired.MyTextBox.Text = "Health: "+ selectedShip.shipAcquired.health;


                }
                else 
                {
                    EnemyMove();
              
                }
                this.movements_left--;
            }
        }
        

    }

}

