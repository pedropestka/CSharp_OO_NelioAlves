using System;
using System.Collections.Generic;
using System.Text;

namespace Aula73_Mod_ref
{
    class Calculator
    {
        //sem ref
        //public static void Triple (int x)
        //{
        //    x = x * 3;
        //}

        //com ref

        public static void Triple(ref int x)
        {
            x = x * 3;
        }


    }
}
