using System;

namespace Array
{
    class Array 
    {
        static void Main(String[] args)
        {
            int i , j;
            int [ , ] arr1 = new int[3,3];

            Console.Write("To Print the 2D array of size 3x3: \n");
            Console.Write("--------------------------------------\n \n ");
            Console.Write("Input elements in the matrix: \n");

            for(i=0 ; i<3 ; i++)
            {
                for(j=0 ; j<3 ; j++)
                {
                    Console.Write("Elements - [{0} {1}]: ",i,j);
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            
            }
            Console.Write(" The matrix is : ");

            for(i=0;i<3;i++){
                Console.Write("\n\n");
                for (j=0;j<3;j++)
                {
                    Console.Write("{0}\t",arr1[i,j]);
                }
            }Console.Write("\n\n");

        }
    }
}
