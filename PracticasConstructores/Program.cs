using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rect1 = new Rectangulo();
            rect1.describir();
            float area1 = rect1.calcArea();
            Console.WriteLine("Area=" + area1);


            Rectangulo rect2 = new Rectangulo();
            rect2.setAlto(12);
            rect2.describir();
            float area2 = rect2.calcArea();
            Console.WriteLine("Area=" + area2);


            /*Construyo un rect definiendo los 
              valores desde el constructor*/
            Rectangulo rect3 = new Rectangulo(3, 2);
            rect3.describir();
            float area3 = rect3.calcArea();
            Console.WriteLine("Area=" + area3);



            //Constructor para circulo
            Circulo cir1 = new Circulo(3);
            cir1.describir();
            float per1 = cir1.calcPer();
            Console.WriteLine("Perimetro=" + per1);

            Circulo cir2 = new Circulo(8);
            cir2.describir();
            float per2 = cir2.calcPer();
            Console.WriteLine("Perimetro=" + per2);

            // Constructor para triangulo
            Triangulo tri1 = new Triangulo(2, 5, 7);
            tri1.describir();
            float perim1 = tri1.calcPerim();
            Console.WriteLine("Perimetro=" + perim1);

            
            Triangulo tri2 = new Triangulo(2, 5, 7);
            tri1.describir();
            float perim2 = tri2.calcPerim();
            Console.WriteLine("Perimetro=" + perim2);

            //Obtener precio con iva
            Producto p1 = new Producto("Play station 5", 12000);
            p1.describir();
            float preIVA = p1.calcIva();
            Console.WriteLine("Precio con iva=" + preIVA);
             
            
            Zapato zap1 = new Zapato("Amarillo", 27.5f);
            zap1.describir();

            Persona perso1 = new Persona(2002);
            perso1.describir();
            int edad = perso1.calEdad();
            Console.WriteLine("La persona tiene " + edad + " años");

            Email email1 = new Email("Platzi", "Carlos Garcia", 
                "Aun tienes tiempo para potencIAr tu conocimiento, " +
                "precio especial");
            email1.leer();


            Console.ReadLine();
        }
    }
}
