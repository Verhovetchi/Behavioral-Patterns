using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;

namespace ObserverSample.Widgets
{
     class DeportivoWidget : IWidget
     {
          private string _deportivo;

          public void Update(object sender, NewsEventArgs e)
          {
               _deportivo = e.Deportivo;
               Display();
          }

          public void Display()
          {
               Console.WriteLine("Deportivo: {0}", _deportivo);
          }
     }
}
