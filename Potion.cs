using System;
namespace Projet
{
    public class Potion : Equipement
    {

        public enum PotionType { Heal, Defense, Attack };
        public PotionType Type;

        public Potion(string name, string description, float value, float weight, PotionType type)
            : base(name, description, value, weight)
        {
            this.Type = type;
        }

        public override void PickUp()
        {
            base.PickUp();
            Console.WriteLine("Vous avez une nouvelle potion");
        }
        public override void Use()
        {
            base.Use();
            Console.WriteLine("Vous avez utilisé une potion");
        }
    }
}
