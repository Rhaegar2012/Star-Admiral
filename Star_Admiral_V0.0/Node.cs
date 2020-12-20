using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Star_Admiral_V0._0
{
   public  class Node
    {   
        // Node coordinates within the board 
        private int y_coordinate;
        private int x_coordinate;
        // Node designation within the board 
        public int Node_Number;
        public int X_coordinate 
        { get 
            {
                return x_coordinate;
            } 
          set {
                
                x_coordinate = value;
            }
        }
        public int Y_coordinate 
        { get 
            {
                return y_coordinate;
            }
            set 
            {
                y_coordinate = value;
            } 
        }
        
        public ArrayList neighbors = new ArrayList();
        public bool shipPresent = false;
        public Ship shipPlaced;
        //Node Constructor 
        public Node(int number,int xCoordinate,int yCoordinate)
        {
            Node_Number = number;
            X_coordinate = xCoordinate;
            Y_coordinate = yCoordinate;
        }
        //Adds neighbors to current node
        public void CreateNeighbors(ArrayList nodes)
        {
            int[] direction1 = new int[2] { 1, 0 };
            int[] direction2 = new int[2] { 0, 1 };
            int[] direction3 = new int[2] { -1, 0 };
            int[] direction4 = new int[2] { 0, -1 };
            int[][] directions = new int[][] { direction1, direction2, direction3, direction4 };
            for (int i = 0; i < directions.Length; i++)
            {
                int[] neighborCoordinates = new int[2] { x_coordinate + directions[i][0], y_coordinate + directions[i][1]};
                foreach(Node node in nodes)
                {
                    int[] nodeCoordinates = new int[] { node.X_coordinate, node.Y_coordinate };
                    if (nodeCoordinates.SequenceEqual(neighborCoordinates) )
                    {
                        neighbors.Add(node);
                        
                    }
                }
            }
        }
    }
}
