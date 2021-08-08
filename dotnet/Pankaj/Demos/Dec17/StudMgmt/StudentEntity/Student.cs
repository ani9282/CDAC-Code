using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentExceptions;

namespace StudentEntity
{
    public class Student
    {

        private int rollNo;

       
        private string name;

      
        int phy;
        int chem;
        int maths;
        int tot;
        float perc;

        #region Properties

        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Phy
        {
            get
            {
                return phy;
            }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    phy = value;
                }
                else
                {
                    throw new InvalidMarksException("Invalid Physics Marks");
                }
            }
        }

        public int Chem
        {
            get
            {
                return chem;
            }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    chem = value;
                }
                else
                {
                    throw new InvalidMarksException("Invalid Chemistry Marks");
                }
            }
        }

        public int Maths
        {
            get
            {
                return maths;
            }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    maths = value;
                }
                else
                {
                    throw new InvalidMarksException("Invalid Maths Marks");
                }
            }
        }

        public int Tot
        {
            get
            {
                return tot;
            }

            set
            {
                tot = value;
            }
        }

        public float Perc
        {
            get
            {
                return perc;
            }

            set
            {
                perc = value;
            }
        }

        #endregion

    }
}
