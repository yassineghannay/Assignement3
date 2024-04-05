using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//test commit 
//test commit2.0 visual studio
namespace Assignment3.Utility
{
    //Set Node class up
    public class Node
    { 

       // To store data
        private object data; 
        
        public User Value {get; set;}
        
        public Node Next { get; set; }


        // Node constructor
        public Node(User value)
        {
            Value = value;
            Next = null;
        }

        public Node(object data)
        {
            this.data = data;
        }
    }
}
// Constructor to initialize a node with a specified data object (not used in this implementation)
        //public Node(object data)
        //{
        //    this.data = data;
        //}
