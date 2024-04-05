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
        private object data; 
        
        public User Value {get; set;}
        
        public Node Next { get; set; }
      
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
