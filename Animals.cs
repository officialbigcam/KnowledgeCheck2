using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Animals



{
    public class Animal

    {
       
        public int numberOfLegs { get; set; }
        public int numberOfEyes { get; set; }
        public string name { get; set; }
            
    }

    public class Cat : Animal
    {
        public string nightVision { get; set; }
        public Cat()
       
        
        {   
            
            this.numberOfLegs = 4;
            this.numberOfEyes = 2;
            
            {



            }

        }
    }
}



