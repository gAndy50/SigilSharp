//Simple Sigil Example
//Example written by Andy P. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace SigilSharp
{
    class Program 
    {
       
        static void Main(string[] args)
        {
            sigil.slWindow(800, 600, "Hello World",flags.SL_FALSE);
            
            while(sigil.slShouldClose() == 0)
            {
                if(sigil.slGetKey(flags.SL_KEY_ESCAPE) == 1)
                {
                    sigil.slClose();
                }

                sigil.slRender();
            }

            sigil.slClose();
        }
    }
}
