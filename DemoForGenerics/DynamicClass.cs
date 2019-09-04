using System;

namespace DemoForGenerics
{
    public class DynamicClass<T>
    {
        public void SomeFunction(T a, T b)
        {
            dynamic A = a;
            dynamic B = b;
            Console.WriteLine(A + B);
        }
    }
}
