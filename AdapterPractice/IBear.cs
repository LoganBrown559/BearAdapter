/*
 * 
 * Name: Logan Brown
 * File: IBear.cs
 * Date: 2/12/2021
 * Description: Creates an interface for Real Bears, and implements it.
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPractice
{
    public interface IBear
    {
        public void Maul();

        public void Hibernate();
    }

    public class Grizzly : IBear
    {
        public void Maul()
        {
            Console.WriteLine("Swipe swipe, leg swap and kick. You've been mauled.");
        }

        public void Hibernate()
        {
            Console.WriteLine("With a great thud, the bear rests for winter.");
        }
    }
}
