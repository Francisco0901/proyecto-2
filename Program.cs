using System;

namespace proyecto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int edad = 0;
            double altura = 0.0;
            
            
            Console.WriteLine("¡Bienevenido a super park!, por favor ingresa tu edad:");
            valor = Console.ReadLine();
            edad = Convert.ToInt32(valor);
            
            if(edad >= 18)
            {
                Console.WriteLine("Disculpe ha superado el limite de edad para el parque.");
            }
            else
            { 
                Console.WriteLine("Perfecto, por favor ahora indica tu altura en metros");
                valor = Console.ReadLine();
                altura = Convert.ToDouble(valor);

                if(altura < 1.50)
                {
                 Console.WriteLine("¡Podras disfrutar de el gusanito, el carrusel, las sillas voladoras y los carritos chocones");
                }
                {
                    Console.WriteLine("¡Genial!, puedes disfrutar de todas las atracciones del parque!"); 
                } 
                    Console.WriteLine("¡Que pases un excelente día en superpark!");
              
      }
    }
  }  
}