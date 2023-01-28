using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingNullableReferenceTypes
{
    //TODO : LAB_002.1
    //1. Check the squiggly line now.
    //2. Look at the declaration of the types for each property in Student and CodingExperience
    //3. Now read https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-reference-types
    //4. What does the ? do ?

    internal class Student
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public CodingExperience? CodingExperience { get; set; }
    }

    internal class CodingExperience
    {
        public List<String>? ProgrammingLanguages { get; set; }
    }
}
