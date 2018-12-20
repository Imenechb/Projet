using System;
public class Menu
    {
        public Menu()
        {
            PrintMenu();
            int choice = AskChoice(0, 3);
            switch (choice)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    Load();
                    break;
                case 2:
                    About();
                    break;
                case 3:
                    Quit();
                    break;
            }
        }
        public void PrintMenu()
        {
            Console.WriteLine("   |  0-StartGame.             ");
            Console.WriteLine("   |  1- Load.                 ");
            Console.WriteLine("   |  2- About.                ");
            Console.WriteLine("   |  3- Quit                  ");                  
        }

        public int AskChoice(int min, int max)
        {
            int result = int.Parse(Console.ReadLine());
            while (result>max || result>min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;
        }
        public void StartGame()
        {
            Game game = new Game();
        }
        public void Load()
        {
            //TODO  sauvgarde du jeu pour le reprendre ensuite
        }
        public void About()
        {
            Console.WriteLine("Bienvenu dans le jeu ")
        }
        public void Quit()
        {
            Environment.Exit(0);
        }
       
    }

               
            
