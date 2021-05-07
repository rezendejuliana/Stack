using System;
using System.Collections.Generic;

namespace Stack
{
    partial class Program
    {
        public class Stack
        {
            private readonly List<object> _stackList = new List<object>();

            public void Push(object obj)
            {
                if(obj == null)
                    throw new InvalidOperationException("Object is null.");
                   
                _stackList.Add(obj);
                
            }

            public object Pop()
            {
                if(_stackList.Count ==0)
                    throw new InvalidOperationException("Object is null.");

                object obj = _stackList[_stackList.Count - 1];

                if(_stackList.Count >= 1)
                {
                    _stackList.Remove(_stackList[_stackList.Count - 1]);
                   
                }

                return obj;
            }
            
            public void Clear()
            {
                _stackList.Clear();
            }
        }
    }
}
