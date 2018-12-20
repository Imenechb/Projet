using System;
namespace Projet
{
    public class Game
    {
        public string Name;
        protected int PointDeVie;
        protected int Force;
        protected int Endurance;
        protected int Taille;

        public string NOMPlayer { get; }

        private string NomPlayer;
        public static Equipement[] Inventaire;
        public Player player;
        public Map map;


        public Game(string Nom)
        {
            this.NomPlayer = Nom;


            Inventaire = new Equipement[10];

            Inventaire[0] = new Potion("Soin", "Une potion de soin", 1, 2, Potion.PotionType.Heal);
        }

        public Game()
        {
        }

        public virtual int Damage(int degats)
        {
            PointDeVie -= degats;
            if (PointDeVie <= 0)
            {
                Console.WriteLine("DEAD");
            }
            return PointDeVie;
        }


        public virtual int Attack()
        {
            return 1;
        }
        public void StartGame()
        {
            Game game = new Game();
        }
        public void Deplacement()
        {
            PrintMenu();
            int choice = AskChoice(0, 3);
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Go EAST");
                    break;
                case 1:
                    Console.WriteLine("GO NORTH");
                    break;
                case 2:
                    Console.WriteLine("GO WEST");
                    break;
                case 3:
                    Console.WriteLine("GO SOUTH");
                    break;
            }

           
        }


    }
}
