using System;


namespace Lessons_7_
{
    internal class Pair<S, T>
    {
        public S Name;
        public T Age;
        public Pair(S name, T age)
        {
            Name = name ;
            Age = age;
        }   
    }

}


