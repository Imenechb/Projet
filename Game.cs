using System;
namespace Projet
{
    public class Game
    {
        public Player player;
        public Map map;

        public Game()
        {
            //TODO constucteur 
        }
        public void StartGame()
        {
             Game game = new Game();
        }
        public void Deplacement()
        {
            AfficherMenu();
            int choice = AskChoice(0, 3);

            // TODO Récupérer la case
            // TODO tester le contenu de la case
            // TODO lancer le combat
        }

      
    }
}
