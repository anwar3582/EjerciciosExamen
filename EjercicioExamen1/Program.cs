using System;

namespace EjercicioExamen
{
    class Programd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("una Palabra");
           String palabra=Console.ReadLine();
           char[] charPalabra = palabra.ToCharArray();
            int inc=0;
            int des = charPalabra.Length;

            bool bError= false;

            while((inc<des)&&(!bError)){
                
                if(charPalabra[inc]==charPalabra[des]){
                    inc++;
                    des--;
                } else {
                    bError=true;
                }


            }

           
        }
    }
}
