using System;
namespace Projet
{
    public class Equipement
    {

            #region Variables
        public string Name;
        public string Description;
        public float Value;
        public float Weight;

        #endregion
        public Equipement(string name, string description, float value, float weight)
        {
            this.Name = name;
            this.Description = description;
            this.Value = value;
            this.Weight = weight;
        }

        public void Print()
        {
            Console.WriteLine(this.Name + " : " + this.Description);
        }

        // Fonction pour ramasser les Objets
        virtual public void PickUp()
        {

        }

        // Fonction pour utiliser les Objets
        virtual public void Use()
        {

        }

        /*
            Virtualisation: Si j'ai besoin d'ajouter des choses specifique a mon Objet
         */
    

    }
}
