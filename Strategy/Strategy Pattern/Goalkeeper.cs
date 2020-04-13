using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
     class Goalkeeper : Player, ISave
     {
          public void Save()
          {
               Console.WriteLine("Goalkeeper.Save()");
          }
          public override void Jump()
          {
               Console.WriteLine("Jump for save");
          }
     }
}
