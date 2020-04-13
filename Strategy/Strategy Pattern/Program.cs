using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
     class Program
     {
          static void Main(string[] args)
          {
               List<Player> players = new List<Player>();
               players.Add(new Goalkeeper());
               players.Add(new Defender());
               players.Add(new Midfielder());
               players.Add(new Forward());

               foreach (var player in players)
               {
                    player.Fall();
                    player.Jump();
                    player.Save();
                    player.Shoot();
                    Console.WriteLine();
               }
               Console.ReadKey();
          }
     }
}
