using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Star_Admiral_V0._0
{
   public class Board
    {
        public ArrayList Nodes = new ArrayList();
        private static int boardHeight = 10;
        private static int boardWidth = 10;
        public Node[,] board=new Node[boardHeight,boardWidth];

        //Method for creating and storing nodes 
        public void CreateNodes()
        {
            int nodeCount = 1;
            for (int i=0; i < boardWidth; i++)
            {
                for(int j = 0; j < boardHeight; j++) 
                {
                    Node node = new Node(nodeCount, i, j);
                    board[i, j] = node;
                    Nodes.Add(node);
                    nodeCount++;
                }
            }
        }
        //Method to create the board and store the nodes
    
        //Creates the nodes neighbors
        public void createNodeNeighbors()
        {
            foreach(Node node in Nodes)
            {
                node.CreateNeighbors(Nodes);
            }
        }
        //Finds a node given set of coordinates
        public Node findNode(int Node_X_Coordinate, int Node_Y_Coordinate)
        {
            Node foundNode = null;
            foreach(Node node in Nodes)
            {
                if(Node_X_Coordinate==node.X_coordinate && Node_Y_Coordinate == node.Y_coordinate)
                {
                    foundNode = node;
                }
            }
            return foundNode;
        }
        //Testing function to display nodes and node coordinates
        public void DisplayBoard()
        {
            foreach(Node node in Nodes)
            {
                Console.WriteLine("Node No "+node.Node_Number+" Coordinate X "+ node.X_coordinate+" Coordinate Y "+ node.Y_coordinate);
                foreach(Node neighbor in node.neighbors)
                {
                    Console.WriteLine("Neigbhor coordinates " + neighbor.X_coordinate + neighbor.Y_coordinate);
                }
                
            }
            for (int i = 0; i < boardWidth; i++) 
            {
              for(int j = 0; j < boardHeight; j++) 
                {
                    Console.WriteLine(board[i, j].Node_Number);
                }  
            } 
        }

    }
}
