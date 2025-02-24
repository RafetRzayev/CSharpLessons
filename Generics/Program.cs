using System.Collections;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSandvich();

            Animal cat = new Cat();
            cat.MakeSandvich();
        }
    }

    internal abstract class Animal
    {
        public abstract void Sound();
        public virtual void MakeSandvich()
        {
            Console.WriteLine("Sandcihch prepareing");
        }
    }

    internal class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("bark");
        }

        public override void MakeSandvich()
        {
            Console.WriteLine("I cant");
        }
    }

    internal class Cat : Animal
    {
        public override void Sound()
        {
            throw new NotImplementedException();
        }

        public new void MakeSandvich()
        {
            Console.WriteLine("hello");
        }
    }
    internal class MyStack<T>
    {
        private T[] _items;
        private int _size = 0;

        public MyStack(int capacity)
        {
            _items = new T[capacity];
        }

        public int Count => _size;
        public T this[int index] => _items[index];

        public void Push(T item)//Enqeue
        {
            if (_size >= _items.Length)
            {
                T[] newItems = new T[_items.Length * 2];
                Array.Copy(_items, newItems, _size);
                _items = newItems;
            }

            _items[_size++] = item;
        }

        public T Pop()//Deqeue
        {
            return _items[--_size];
        }

        public T Peek()
        {
            return _items[_size - 1];
        }
    }

    internal class MyQueue<T>
    {
        private T[] _items;

        private int _size = 0;
        private int _start = 0;

        public MyQueue(int capacity)
        {
            _items = new T[capacity];
        }

        public void Enqeue(T item)
        {
            _items[_size++] = item;
        }

        public T Dequeue()
        {
            return _items[_start++];
        }

        public T Peek()
        {
            return _items[_start];
        }
    }
}
