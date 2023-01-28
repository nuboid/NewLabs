using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayNullableReferenceTypes
{
    internal class Student
    {
        //TODO : LAB_001.2
        //Notice the squiggly lines, fly over them and read the warnings.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CodingExperience CodingExperience { get; set; }


        //TODO : LAB_001.4
        //1. Uncomment this constructor
        //2. Notice the squiggly lines for the whole file.
        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;

            //TODO : LAB_001.5
            //1. Uncomment following line
            CodingExperience = new CodingExperience();
            //2. Notice the squiggly line at the constructor disappears
            //3. But the ProgrammingLanguages property still has the squiggly line.

        }
    }

    internal class CodingExperience
    {
        public List<String> ProgrammingLanguages { get; set; }
    }
}
