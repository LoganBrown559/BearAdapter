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
