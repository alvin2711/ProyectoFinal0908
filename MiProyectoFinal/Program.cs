using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("-------------- MI NOMBRE ES: ALVIN JOSE VOLQUEZ --------------");
            Console.WriteLine("-------------- MI MATRICULA ES: 15-EISN-1-192 ----------------");
            Console.WriteLine("-------------- MI SECCION ES: 0908 ---------------------------");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("CALCULO DE CALIFICACIONES DE SECCION 0908");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("-------------------- RECUERDE PARA EMPEZAR---------------------");
            Console.WriteLine("LA ASISTENCIA VALE 10 PUNTOS");
            Console.WriteLine("LA PRACTICA VALE 20 PUNTOS");
            Console.WriteLine("EL EXAM.PARCIAL VALE 20 PUNTOS");
            Console.WriteLine("EL EXAM.FINALVALE 50 PUNTOS");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------");

            int ASIST, PRACT, PP, EXMF;
            int NOTAT;
            string linea;

        
            Console.WriteLine("Calificacion de asistencia:");
            linea = Console.ReadLine();
            ASIST = int.Parse(linea);

            Console.WriteLine("Calificacion de Practica:");
            linea = Console.ReadLine();
            PRACT = int.Parse(linea);

            Console.WriteLine("Calificacion de Primer Parcial:");
            linea = Console.ReadLine();
            PP = int.Parse(linea);

            Console.WriteLine("Calificacion de Examen Final:");
            linea = Console.ReadLine();
            EXMF = int.Parse(linea);

            NOTAT = ASIST + PRACT + PP + EXMF;

            Console.WriteLine("Tu calificacion es:" + NOTAT);

            if (NOTAT >= 70)
            {
                Console.WriteLine("FELICIDADES PASASTE!");
            }
            else
            {
                if (NOTAT < 70)
                {
                    Console.WriteLine("USTED REPITE LA MATERIA T.T !");
                }
            }
            
            Console.ReadKey();

        
        
        
        
        
        }
    }
}
