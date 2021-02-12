/*
 * 
 * Name: Logan Brown
 * File: IToyBear.cs
 * Date: 2/12/2021
 * Description: Creates an interface for Toy Bears, and implements it with a concrete class.
 * 
 */
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
