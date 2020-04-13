using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverSample.Widgets
{
     public interface IObserver
     {
          void Update(string franceFootball, string deportivo, string barcaNews);
          void RemoveFromSubject();
     }
}
