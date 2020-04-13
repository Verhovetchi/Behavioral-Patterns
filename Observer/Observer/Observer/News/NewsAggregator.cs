using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.Widgets;

namespace ObserverSample.News
{
     public class NewsEventArgs
     {
          public NewsEventArgs(string franceFootball, string deportivo, string barcaNews)
          {
               FranceFootball = franceFootball;
               Deportivo = deportivo;
               BarcaNews = barcaNews;
          }

          public string FranceFootball { get; private set; }
          public string Deportivo { get; private set; }
          public string BarcaNews { get; private set; }
     }

     public delegate void NewsChangedEventHandler(object sender, NewsEventArgs e);

     public class NewsAggregator
     {
          private static Random _random;

          public NewsAggregator()
          {
               _random = new Random();
          }

          public event NewsChangedEventHandler NewsChanged;

          public string GetFranceFootballNews()
          {
               var news = new List<string>
                           {
                               "News from FranceFootball 1",
                               "News from FranceFootball 2",
                               "News from FranceFootball 3"
                           };

               return news[_random.Next(3)];
          }

          public string GetDeportivoNews()
          {
               var news = new List<string>
                           {
                               "News from Deportivo 1",
                               "News from Deportivo 2",
                               "News from Deportivo 3"
                           };

               return news[_random.Next(3)];
          }

          public string GetBarcaNews()
          {
               var news = new List<string>
                           {
                               "News from BarcaNews 1",
                               "News from BarcaNews 2",
                               "News from BarcaNews 3"
                           };

               return news[_random.Next(3)];
          }

          public void NewNewsAvailable()
          {
               string franceFootball = GetFranceFootballNews();
               string deportivo = GetDeportivoNews();
               string barcaNews = GetBarcaNews();

               if (NewsChanged != null)
                    NewsChanged(this, new NewsEventArgs(franceFootball, deportivo, barcaNews));
          }
     }
}
