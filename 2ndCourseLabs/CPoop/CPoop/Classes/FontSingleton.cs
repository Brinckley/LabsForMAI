using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPoop.Classes
{
    class FontSingleton
    {
        private static FontSingleton instance;
        
        public Font font { get; set; }

        private FontSingleton()
        {
            font = new Font("Lato", 9, FontStyle.Regular);
        }

        public static FontSingleton getInstance()
        {
            if (instance == null) {
                instance = new FontSingleton();
                
            }
            return instance;
        }
    }
}
