using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Birds : Animal
    {
        public Birds()
        {
            hasHair = true;
            WarmOrColdBlooded = "Warm";
            isAlive = true;
            legCount = 2;
            
        }
    
        public bool CanFly { get; set; }
        public string Name { get; set; }
        public string FeatherColor { get; set; }   
        public string Size { get; set; }    

    
    
    
    }
}
