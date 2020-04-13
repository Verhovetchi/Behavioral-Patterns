using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;

namespace ObserverSample.Widgets
{
     class FranceFootballWidget : IWidget
     {
          private string _franceFootball;

          public void Update(object sender, NewsEventArgs e)
          {
               _franceFootball = e.FranceFootball;
               Display();
          }

          public void Display()
          {
               Console.WriteLine("FranceFootball: {0}", _franceFootball);
          }
     }
}
