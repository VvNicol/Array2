namespace practicaArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vocales = { 'a', 'w', 'i', 'o', 'q' };
            char[] vocales2 = { 'a', 'e', 'i', 'o', 'u' };

            bool buscar = false;
            
            //Array  de filas
            for (int fila = 0; fila < vocales.Length; fila++)
            {

                buscar = false;

                for (int columna = 0; columna < vocales2.Length; columna++)
                {
                    // Comparando la vocal actual con todas las vocales en el segundo arreglo
                    if (vocales[fila] == vocales2[columna])
                    {
                        //No hay discrepancia en las posiciones que han entrado
                        buscar = true;// establece las vocales true
                        break;//salen del bucle interno y se compara si es false
                    }
                }
                // Las que permanecen en false entran y muestra un mensaje
                if (!buscar)
                {
                    Console.WriteLine("En la posición " + fila + " hay algo extraño: " + vocales[fila] + " no coincide con ninguna vocal en la misma posición en el segundo arreglo.");
                }
            }
        }
    }
}