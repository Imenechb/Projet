using System;

namespace Projet
{
   
        public class Case
        {
            public enum CaseType { Monster, Player, Empty};
            public int X;
            public int Y;
            public CaseType Type;
            public string Description;
            public Monster m;
            public Equipement Item;
            public Player player;

            
            public Case(int x, int y, CaseType type, string description)
            {
                X = x;
                Y = y;
                Type = type;
                Description = description;
                player = null;
                Random r = new Random(DateTime.Now.Millisecond);
                if (r.Next() % 100 > 50)
                {
                    Item = new Potion("Soin", "Une potion de soin", 1, 2, Potion.PotionType.Heal);
                }
                else
                {
                    Item = null;
                }
            }

           
            public void StartFight()
            {

            }
        }
    }
