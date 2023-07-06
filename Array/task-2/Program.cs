using System;

namespace Array
{
    class Array
    {
        static void Main(String[] args)
        {
            int i, n;
            int[] a= new int[100];

            Console.WriteLine("Input the number of elements to store in the array:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} number of elements in the array :");
            for(i=0;i<n;i++){
                Console.Write("Elements -{0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            } 

            Console.WriteLine("\n The values store into the array are : \n");
                for(i=0;i<n;i++)
                    {
                    Console.Write("{0}  ",a[i]);
                    }
                
            Console.Write("\n\nThe values store into the array in reverse are :\n");
                    for(i=n-1;i>=0;i--)
                        {
                        Console.Write("{0} ",a[i]);
                        }
                 Console.Write("\n\n");


        }
    }

}