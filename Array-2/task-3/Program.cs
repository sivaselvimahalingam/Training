using System;

namespace Array
{
    class Array
    {
        static void Main(String[] args)
        {
            int i,j,n;
            int[ , ] arr1= new int[50,50 ];
            int[ , ] arr2= new int[50,50 ];
            int[ , ] arr3= new int[50,50 ];

            Console.Write("Input the size of the square matrix (less then 3): \n");
             n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the elements in the first matrix: \n ");
        

            for(i=0;i<n;i++)
            {
                for(j=0;j<n;j++){
                    Console.Write("Elements -[ {0} {1}] - : ", i,j);
                    arr1[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Input the elements in the second matrix: \n ");
            for(i=0;i<n;i++)
            {
                for(j=0;j<n;j++){
                    Console.Write("Elements -[ {0} {1}] - : ", i,j);
                    arr2[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The elements in first matrix: \n ");

            for(i=0;i<n;i++)
            {
                Console.Write("\n");
                for(j=0;j<n;j++){
                    Console.Write("{0}\t",arr1[i,j]);
                }
            }Console.Write("\n");

             Console.Write("The elements in second matrix: \n ");

            for(i=0;i<n;i++)
            {
                Console.Write("\n");
                for(j=0;j<n;j++){
                    Console.Write("{0}\t",arr1[i,j]);
                }
            }Console.Write("\n");

            Console.Write("The subraction of two matrix: \n ");
            for(i=0;i<n;i++){
                for(j=0;j<n;j++){
                    arr3[i,j]=arr1[i,j]-arr2[i,j];
                    }
            }
            for(i=0;i<n;i++)
            {
                Console.Write("\n");
                for(j=0;j<n;j++){
                    Console.Write("{0}\t",arr3[i,j]);
                }
            }Console.Write("\n");

    
        }
    }
}

