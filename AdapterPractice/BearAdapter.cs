/*
 * 
 * Name: Logan Brown
 * File: BearAdapter.cs
 * Date: 2/12/2021
 * Description: a concrete class that converts the single function of IToyBear to Maul() of real bear.
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPractice
{
    public class BearAdapter : IToyBear
    {

        IBear myBear;

        public BearAdapter(IBear bear)
        {
            this.myBear = bear;
        }

        public void Hug()
        {
            myBear.Maul();
        }
    }
}
