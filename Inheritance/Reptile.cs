using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile()
        {
           hasHair = false;
           WarmOrColdBlooded = "cold";
           legCount = 4;
           isAlive = true;
           


        }
        
        public bool HasTeeth { get; set; }  
        public string SkinColor { get; set; }
        public bool HasLegs { get; set; }
        public string Size { get; set; } 
        public string Name { get; set; }    


    
    
    
    
    }
}
