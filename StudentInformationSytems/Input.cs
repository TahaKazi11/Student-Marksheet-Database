using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSytems
{
    class Input
    {
        //ENHANCEMENT: Using get set method SOURCE: https://stackoverflow.com/questions/5096926/what-is-the-get-set-syntax-in-c
        private static string Name1;
        private static string Name2;
        private static string DOB;
 
        public string FirstNames
        {
            get
            {
                return Name1; 
            }
            set
            {
                Name1 = value; 
            }
        }
        public string LastNames
        {
            get
            {
                return Name2; 
            }
            set
            {
                Name2 = value; 
            }
        }
        public string DOBs
        {
            get
            {
                return DOB; 
            }
            set
            {
                DOB = value; 
            }
        }
       

    }
}
