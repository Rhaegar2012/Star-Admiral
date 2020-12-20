using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;


namespace Star_Admiral_V0._0
{
    public class Admiral
    {
        public ArrayList fleet = new ArrayList();
        public int fleet_size;
        public int movements_left;
        public Board MyBoard;
        private int myFleetRow = 9;
        private int myFleetColumn=5;
        public bool shipFound = false;
        public Ship shipAcquired;
        private PictureBox[] playerSprites = new PictureBox[1];
        public Label textBox;

        //Creates Admiral
        public Admiral(Board Board, int FleetSize, int MovementsLeft, PictureBox[] PlayerSprites,Label shipHltTextBox)
        {
            MyBoard = Board;
            fleet_size = FleetSize;
            movements_left = MovementsLeft;
            playerSprites = PlayerSprites;
            textBox = shipHltTextBox;

        }
        public virtual void moveShip(string direction, string orientation, Ship selectedShip)
        {


            //Access and updates current node coordinates
            int X_coordinate = selectedShip.MyNode.X_coordinate;
            int Y_coordinate = selectedShip.MyNode.Y_coordinate;
            int[] NewNodeCoordinate = new int[2] { X_coordinate, Y_coordinate };
            Console.WriteLine("Original Coordinates" + NewNodeCoordinate[0] + NewNodeCoordinate[1]);
            if (direction == "horizontal" && orientation == "positive")
            {
                NewNodeCoordinate[1] += 1;
                selectedShip.MyPictureBox.Left += 50;
            }
            else if (direction == "horizontal" && orientation == "negative")
            {
                NewNodeCoordinate[1] -= 1;
                selectedShip.MyPictureBox.Left -= 50;
            }
            if (direction == "vertical" && orientation == "positive")
            {
                NewNodeCoordinate[0] -= 1;
                selectedShip.MyPictureBox.Top -= 50;

            }
            else if (direction == "vertical" && orientation == "negative")
            {
                NewNodeCoordinate[0] += 1;
                selectedShip.MyPictureBox.Top += 50;
            }
           
            Node newNode =MyBoard.board[NewNodeCoordinate[0], NewNodeCoordinate[1]];
            selectedShip.MyNode.shipPresent = false;
            selectedShip.MyNode.shipPlaced = null;
            selectedShip.MyNode = newNode;
            selectedShip.MyNode.shipPresent = true;
            selectedShip.MyNode.shipPlaced = selectedShip;
            movements_left -= 1;
            this.scansBoard();
           // Console.WriteLine("Update node" + selectedShip.MyNode.Node_Number);
           // Console.WriteLine("Updated Coordinates" + selectedShip.MyNode.X_coordinate + selectedShip.MyNode.Y_coordinate);

            
        }
        public virtual void createFleet()
        {
            Node shipNode=MyBoard.board[myFleetRow,myFleetColumn];
            for (int i = 0; i < fleet_size; i++)
            {

               // Console.WriteLine("Ship Created");
               // Console.WriteLine("Ship Node number" + shipNode.Node_Number);
               // Console.WriteLine("Ship X coordinate " + shipNode.X_coordinate);
               // Console.WriteLine("Ship Y coordinate " + shipNode.Y_coordinate);
                Ship newShip = new Ship(shipNode, playerSprites[i], this);
                newShip.MyTextBox = textBox;
                newShip.MyNode.shipPresent = true;
                newShip.MyNode.shipPlaced = newShip;
               // Console.WriteLine(newShip.MyNode.shipPlaced.ToString());
                fleet.Add(newShip);
     

            }
        }
        public virtual void scansBoard()
        {
            ArrayList enemyNodes = new ArrayList();
            //Finds all enemy ships
            foreach(Node node in MyBoard.Nodes)
            {
                if (node.shipPresent)
                {
                   // Console.WriteLine(node.X_coordinate.ToString());
                   // Console.WriteLine(node.shipPlaced.name);
                    if (!node.shipPlaced.MyAdmiral.Equals(this))
                    {
                        enemyNodes.Add(node);
                    }
                }
            }
           //Checks position relative to ship's current node
           foreach(Node node in enemyNodes) 
            { 
                foreach(Ship ship in fleet)
                {
                    int ship_row = ship.MyNode.Y_coordinate;
                    int ship_col = ship.MyNode.X_coordinate;
                    int enemy_row = node.Y_coordinate;
                    int enemy_col = node.X_coordinate;
                   
                    int delta_row = Math.Abs(ship_row - enemy_row);
                    int delta_col = Math.Abs(ship_col - enemy_col);
                    Console.WriteLine(delta_row.ToString() + delta_col.ToString());
                    if(delta_row<=ship.range_of_attack && delta_col <= ship.range_of_attack)
                    {
                        Console.WriteLine("Ship Acquired" + node.shipPlaced.name);
                        shipFound = true;
                        ship.shipAcquired = node.shipPlaced;
                        shipAcquired = node.shipPlaced;
                        Console.WriteLine(ship.shipAcquired.name);
                        
                    }
                }
            }
        }
        public virtual void Attack(Ship selectedShip)
        {
            //Random chance generator 
            Random random = new Random();
            int randomChance = random.Next(100);
            Ship targetShip = selectedShip.shipAcquired;
            movements_left--;
            if (randomChance >= 60)
            {
                int HitValue = selectedShip.attack_power - targetShip.defense_power;
                targetShip.health -= HitValue;
                MessageBox.Show("Ship " + selectedShip.name + " deals " + HitValue+
                    " damage points to" + targetShip.name,"Attack Report");
            }
            else
            {
                MessageBox.Show("Attack missed!", "Attack Report");
            }
        }


    }

}

