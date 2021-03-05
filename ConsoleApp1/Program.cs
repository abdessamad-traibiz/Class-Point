using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            string chaine = "3";
            Int32 a = Int32.Parse(chaine) ; // pour convertir la chaine en entier
            Console.WriteLine("BONJOUR LES " + 3 + "IIR"); //+ pour la concaténation des chaines de caracteres
            Console.WriteLine("BONJOUR LES " + chaine + "IIR"); //+ pour la concaténation des chaines de caracteres
           
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------Lecture des coordonnées du point 1---------------------");
            //lecture des coordonnées du point 1 
            Console.Write("Entrer La valeur de X  :   ");//message
            double x = double.Parse(Console.ReadLine());//demander une valeur de x a l'utilisateur 
            Console.Write("Entrer La valeur de Y :   ");
            double y = double.Parse(Console.ReadLine());//demander une valeur de y a l'utilisateur 
            Point p1 = new Point(x, y);//création dynamique du point p2

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------Lecture des coordonnées du point 2---------------------");
            //lecture des coordonnées du point 2 
            Console.Write("Entrer La valeur de X  :   ");
            double xx = double.Parse(Console.ReadLine());
            Console.Write("Entrer La valeur de Y :   ");
            double yy = double.Parse(Console.ReadLine());
            Point p2 = new Point(xx, yy);//création dynamique du point p1
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("---------------------Affichage des coordonnées du point 1---------------------");
            p1.Afficher();//l'appel du méthode d'affichage
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------------Affichage des coordonnées du point 2---------------------");
            p2.Afficher();

            double d = p2.Distance(p1);//calcul de distance
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("---------------------Affichage de la distance entre P1 et P2---------------------");
            Console.WriteLine("La distance entre P1 et P2 est : " + d);//afficher la distance
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("---------------------Coordonnées du point 1 avant déplacement---------------------");
            p1.Afficher();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------Coordonnées du point 2 avant déplacement---------------------");
            p2.Afficher();
            p1.Deplacer(1, 2);
            p2.Deplacer(1, 2);
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("---------------------Coordonnées du point 1 après déplacement---------------------");
            p1.Afficher();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------Coordonnées du point 2 après déplacement---------------------");
            p2.Afficher();

            Console.ReadKey(); //Attendre que la touche entrée soit frappée avant de poursuivre
        }
    }
}
