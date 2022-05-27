using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones_cSharp_Martinez_Blanca_21211990
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un número: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca otro número: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Num1/Num2);

            //try
           // {
                //el codigo esta generardon un error
            //}
            //catch(Exception e)
            //{
             //   Console.Write("Error");
           // }
           // try
           // {

          //  }
            //catch (Exception e)
           // {
             //   Console.Write(e.Message);
           // }

            Console.ReadLine();
            try
            {

            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);

            }
            cath(FormatException e)
                {
                Console.Write(e.mess)
                }
                
        }

    }
}
