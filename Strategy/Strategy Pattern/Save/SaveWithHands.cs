using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
     class SaveWithHands : ISave
     {
          public void Save()
          {
               Console.WriteLine("Save for goalkeeper");
          }
     }
}
