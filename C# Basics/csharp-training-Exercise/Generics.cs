using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_training_Exercise
{
    public class Generics<T>
    {

        public T add_or_concatenate(T a, T b)
        {
            dynamic first = a;
            dynamic second = b;
            T answer = first + second;
            return answer;
        }
    }
}
