using System;

namespace Last2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numList = new int[number];
            
            for (int i=0;i<number;i++)
            {
                numList[i] = int.Parse(Console.ReadLine());
            }
            AI_think(numList);
        }
        static void AI_think(int[] list)
        {
            int[] hole = new int[list.Length];
            int[] newList = new int[list.Length];
            for (int i = 0; i < newList.Length; i++)
            {
                for(int j = 0; j < list.Length; j++)
                {
                    if (list[j]<newList[i]||list[j]>0)
                    {
                        newList[i] = list[j];
                    }
                }
                for (int j = 0; j < list.Length; j++)
                {
                    if(list[j] == newList[i])
                    {
                        list[j] = hole[j];
                    }
                }
                Console.WriteLine(newList[i]);
            }
        }
    }
}
