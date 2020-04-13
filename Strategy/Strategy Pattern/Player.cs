using System;

namespace Strategy_Pattern
{
     public abstract class Player
     {
          protected ISave iSave;
          public Player()
          {
               iSave = new SaveWithHands();
          }
          public void Shoot()
          {
               Console.WriteLine("Shoot");
          }

          public void Fall()
          {
               Console.WriteLine("Fall");
          }
          
          public virtual void Save()
          {
               iSave.Save();
          }

          public abstract void Jump();
     }
}
