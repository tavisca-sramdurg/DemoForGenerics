﻿using System;

namespace DemoForGenerics
{

    class Program
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }

            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
            }

            Console.WriteLine();

            MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }

            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
            }
            Console.WriteLine();

            Console.ReadKey();

            DynamicClass<string> obj = new DynamicClass<string>();
            obj.SomeFunction("a", "b");
        }
    }
}
