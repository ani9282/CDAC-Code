using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinEventDelegDemo
{
    class MITS
    {
        private int marks;
        public delegate void mydel();
        public event mydel Pass;
        public event mydel Fail;
       
        public int Marks
        {
            get { return marks; }
            set
            {
                if (value >= 40)
                {
                    Pass();
                    marks = value;
                }
                else
                {
                    Fail();
                }
            }
        }

    }
}
