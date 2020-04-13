using ObserverSample.News;
using ObserverSample.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
     class Program
     {
          static void Main(string[] args)
          {
               var newsAggregator = new NewsAggregator();
               var franceFootballWidget = new FranceFootballWidget();
               var deportivoWidget = new DeportivoWidget();
               var barcaNewsWidget = new BarcaNewsWidget();

               newsAggregator.NewsChanged += franceFootballWidget.Update;
               newsAggregator.NewsChanged += deportivoWidget.Update;
               newsAggregator.NewsChanged += barcaNewsWidget.Update;

               newsAggregator.NewNewsAvailable();
               Console.WriteLine();

               newsAggregator.NewsChanged -= franceFootballWidget.Update;
               newsAggregator.NewNewsAvailable();

               Console.ReadLine();
          }
     }
}
