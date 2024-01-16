namespace ejercicio.array2
{
    class program
    {
        public static void Main(string[] args)
        {
            string[] arrayString = { "Hola", "Adiós", "Nuevo", "Viejo", "Vamos" };

            

            int posicion = Array.IndexOf(arrayString, "Adiós");

            Console.WriteLine(posicion);

            Console.WriteLine("Introduce una palabra");
            string palabra = Console.ReadLine();

            if (Array.IndexOf(arrayString,palabra) != -1)
            {
                Console.WriteLine("Existe");
            }
            else 
            { 
                Console.WriteLine("No existe");
            }

            int [] arrayEnteros = { 1, 5, 7, 8, 4, 3, 9 };

            var numerosMayor3 = arrayEnteros.Where(num => num > 3).ToArray();

            //Imprimir con un for el array 
            for( int i = 0; i < numerosMayor3.Length; i++ )
            {
                Console.WriteLine(numerosMayor3[i]);
            }

            //Imprimir con un foreach el array
           foreach(var num in numerosMayor3 )
            {
                Console.WriteLine(num);
            }

        }
    }
}
