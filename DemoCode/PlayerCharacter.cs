using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCode
{
    public class PlayerCharacter
    {
        public int Health { get; set; }
    
        public string Name { get; set; }

        public string Nickname { get; set; }

        public bool IsNoob { get; set; }

        public List<String> Weapons { get; set; }

        public PlayerCharacter()
        {
            Name = GenerateName();

            IsNoob = true;

            CreateStartingWeapons();

        }

        private void CreateStartingWeapons()
        {
            Weapons = new List<string>() { "Gun", "Sword", "Wip" /*,"Staff"*/};
        }

        public string GenerateName()
        {

            var names = new[] {
                "Duriel",
                "Nandrael",
                "Balahuz",
                "Meertremb",
                "Soichiro"
            };

            return names[new Random().Next(0, names.Length)];
        }

        public void Sleep()
        {

            var rnd = new Random();

            var healthIncrease = rnd.Next(1, 101);

            Health += healthIncrease;
        }


    }
}
