


using JogoRpg.src.Entities;

namespace dotnet_poo{

class Program{

    static void Main(string[] args){

            Knight  knight = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

           
           Console.WriteLine(wizard.Attack(1));
           Console.WriteLine(wizard.Attack(7));




    }



}


}