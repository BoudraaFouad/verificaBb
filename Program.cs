namespace verificaBb
{
    internal class Program
    {
    
        
        static bool trova(int[,] m)
        {
            Console.WriteLine("dammi valore da 0 a 4(RIGHE");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("dammi valore da 0 a 4(colonne");
            int n1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i < m.GetLength(0); i++)
            {
                for (int j=0; j < m.GetLength(1); j++)
                {
                    if (m[n,n1] == 1)
                    {
                        Console.WriteLine("trovato");
                        return true;
                        
                    }
                    else
                    {
                        if (m[i, j] < n1)
                        {
                            Console.WriteLine("sinistra");
                            return true;
                        }
                        else if(m[i, j] < n1)
                        {
                            Console.WriteLine("destra");
                            return true;
                        }
                        else if (m[i,j]==n && m[i, j] == n1)
                        {
                            Console.WriteLine("stesso");
                            return true;
                        }
                    }
                   
                }
            }
            return false;
        }



        static void Main(string[] args)
        {
            string[,] m =
            {
                {"g","a","l","e","g" },
                {"r","o","k","n","o" },
                {"m","e","l","e","s" },
                {"c","i","n","i","s" },
            };
            int[,] m1 =
            {
                {0,0,0,0,0 },
                {0,0,0,0,0 },
                {0,0,1,0,0 },
                {0,0,0,0,0 },
                {0,0,0,0,0 },
            };




         
            Console.WriteLine("--------------");
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    Console.Write(m1[i, j] + " \t");
                }
                Console.WriteLine();
            }
            trova(m1);
           
        }
    }
}
