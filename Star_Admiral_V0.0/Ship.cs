using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Admiral_V0._0
{
    public class Ship
    {
       public  string name="Audrey";
       public int action_points=2;
       public int attack_power=10;
       public int defense_power=3;
       public int health=30;
       public bool destroyed=false;
       public int range_of_attack=3;
       public int movement_points=20;
       public PictureBox MyPictureBox;
       public Admiral MyAdmiral;
       public Node MyNode;
       public Ship shipAcquired;
       public Label MyTextBox;
       
       //Creates Ship
       public Ship(Node node,PictureBox myPicture,Admiral admiral)
        {
            MyNode = node;
            MyPictureBox = myPicture;
            MyAdmiral = admiral;
        }

        //checks if the ship is alive or destroyed

        public bool check_if_destroyed()
        {
            if (health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
 
   
}

