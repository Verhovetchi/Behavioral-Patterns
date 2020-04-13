using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;

namespace ObserverSample.Widgets
{
     class BarcaNewsWidget : IWidget
     {
          private string _barcaNews;

          public void Update(object sender, NewsEventArgs e)
          {
               _barcaNews = e.BarcaNews;
               Display();
          }

          public void Display()
          {
               Console.WriteLine("BarcaNews: {0}", _barcaNews);
          }
     }
}
