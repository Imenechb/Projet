using System;
namespace Projet
{
    public class Equipement
    {

        public string Name;
        public string Description;
        public float Value;
        public float Weight;

        
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

        virtual public void PickUp()
        {

        }

        virtual public void Use()
        {

        }
    

    }
}
