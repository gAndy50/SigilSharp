# SigilSharp

SigilSharp is a wrapper of Sigil for the C# programming language. Sigil is a simple multimedia library for creating simple games or rapid prototyping. Sigil has a small set of commands for making windows and handling graphics, sound and fonts.


#Example
```C#
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

```


#License

This software is provided as-is. There is no warranty for this software. You use this software at your
own risk. You may not hold the developer responsible for any damages or mis-use
of this software. You may use this wrapper to write C# programs using SigilSharp. You can distribute software you make with this wrapper as you please. 


#Links
```
http://www.libsigil.com/
```
