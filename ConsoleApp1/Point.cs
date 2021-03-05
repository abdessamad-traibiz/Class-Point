using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
              private double x, y; // déclaration de deux objets  private 

                /*private string System = "system";
                private string Console ="console";
                public void affichage()
                 {
                    System.Console.WriteLine("Hello Abdessamad !!");//Erreur
                    global::System.Console.WriteLine("Hello Abdessamad !!");//OK
                 }*/

        public  Point(double X, double Y) // constructeur avec paramétres pour l'initialisation des objets 
        {
            this.x = X;
            this.y = Y;
        }
              public void Afficher() //méthode d'affichage
        {
            Console.WriteLine("X = " + this.x + "  Y = " + this.y);
           
        }
              public double Distance(Point P) //méthode pour calculer la distance 
        {
            double Resultat;
            Resultat=Math.Sqrt(Math.Pow((P.x-this.x),2)+ Math.Pow((P.y - this.y),2));
            return Resultat;
        }

        public Point Deplacer(double a,double b)
        {
            
            this.x = this.x + a;
            this.y = this.y + b;
            return this;
        }

}


}





