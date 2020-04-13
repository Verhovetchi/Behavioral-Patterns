using Strategy_Pattern.Save;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
     class Defender : Player 
     {
          public Defender()
          {
               iSave = new noSave();
          }
          public override void Jump()
          {
               Console.WriteLine("Jump for shoot");
          }
     }
}
