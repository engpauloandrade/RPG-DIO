using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoRpg.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }  

        public string Name;
        public int Level;
        public string HeroType;


        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack(){

            return this.Name + "Atacou com a sua espada";

        }

    }
}