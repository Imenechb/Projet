using System;
namespace Projet
{
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
            //TODO Affichage du menu
        }

        public int AskChoice(int min, int max)
        {
            //TODO le choix du joueur 
            int result = int.Parse(Console.ReadLine());
            while (result>max || result>min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;
        }
        public void StartGame()
        {

        }
        public void Load()
        {
            //TODO  sauvgarde du jeu pour le reprendre ensuite
        }
        public void About()
        {
            //TODO A propos le jeu comment il est // un simple tuto eg..
        }
        public void Quit()
        {
            // TODO Pour quitter le jeu 
        }
       
    }
}
