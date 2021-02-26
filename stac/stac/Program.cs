using System;

namespace stac
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int a = int.Parse(Console.ReadLine());

            for(int i = 0; i < a; i++)
            {
                stack.Push(random.Next(-i, i));
            }

            Console.WriteLine(stack.ToString());
        }
        public class Stack<T> {
            private T[] array;
            private int size;
            public int Count
            {
                get => size;
            }
            public Stack()
            {
                size = 0;
                array = new T[1];
            }
            public bool isEmpty()
                => size == 0;
            public bool isFull()
                => size == array.Length;
            public T Pop()
            {
                if (isEmpty()) 
                    throw new Exception("Empty");    
                return array[--size];
            }
            public T Peek()
            {
                if (isEmpty())
                    throw new Exception("Empty");
                return array[size - 1];
            }
            public void Push(T element)
            {
                if (isFull())
                    ReSizeArray();
                array[size++] = element;
            }
            private void ReSizeArray()
                =>Array.Resize(ref array, size * 2);            
            public override string ToString()
            {
                if (isEmpty())
                    return "Empty"; //throw new Exception("Empty");
                return string.Join(',', array).Substring(0, Count * 2 - 1);
            }
        }
    }
}
