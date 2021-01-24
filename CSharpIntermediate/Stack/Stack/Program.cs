using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Stack
    {
        private readonly List<object> _stack = new List<object>();

        public List<object> Get()
        {
            return _stack;
        }
        public void Push(object obj)
        {
            if (obj is null)
            {
                throw new InvalidOperationException("Item cannot be null");
            }

            _stack.Insert(0, obj);
        }

        public object Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            List<object> placeholder = _stack.Select(ele => ele).ToList();
            //question: what if the object is reference type & requires deep copy?
            _stack.RemoveAt(0);
            Console.WriteLine(placeholder[0]);
            return placeholder[0];
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = new Stack();
                stack.Push("abc");
                stack.Push(23);
                stack.Push(true);

                stack.Clear();
                stack.Pop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           

        }
    }
}
