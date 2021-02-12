using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPractice
{
    public interface IToyBear
    {
        public void Hug();
    }

    public class TeddyBear : IToyBear
    {
        public void Hug()
        {
            Console.WriteLine("You feel the \"Fur\" of the Teddy against you.");
        }
    }
}
