using UsingNullableReferenceTypes;

var student = new Student();
student.FirstName = "XXXXXXXXX";
student.LastName = "XXXXXXXXX";


Console.WriteLine("Number of programming languages student : " + student.CodingExperience?.ProgrammingLanguages?.Count + ".");

//Here we instatiate the CodingExperience property and add Programmin Languages.
student.CodingExperience = new CodingExperience();
student.CodingExperience.ProgrammingLanguages = new List<string>();
student.CodingExperience.ProgrammingLanguages.Add("JavaScript");
student.CodingExperience.ProgrammingLanguages.Add("COBOL");

Console.WriteLine("Number of programming languages student : " + student.CodingExperience?.ProgrammingLanguages?.Count + ".");

Console.WriteLine("End of LAB_002.3");
Console.ReadKey();


var student2 = new Student();

student2.CodingExperience = new CodingExperience();
student2.CodingExperience.ProgrammingLanguages = new List<string>();
student2.CodingExperience.ProgrammingLanguages.Add("JavaScript");
student2.CodingExperience.ProgrammingLanguages.Add("COBOL");
student2.CodingExperience.ProgrammingLanguages.Add(null);

var programmingLanguages = student2?.CodingExperience?.ProgrammingLanguages;

foreach (var item in programmingLanguages ?? new List<string>())
{
    Console.WriteLine(item ?? "was null");
}

Console.WriteLine("End of LAB_002.4");
Console.ReadKey();

object? o1 = null;
if (o1 == null)
{
    Console.WriteLine("object is null");
}
else
{
    Console.WriteLine(o1);
}

Console.WriteLine(o1 ?? "object is null" );

o1 = "now it's something";
Console.WriteLine(o1 ?? "object is null");

Console.WriteLine("End of LAB_002.5");
Console.ReadKey();

var student3 = new Student();
//Console.WriteLine(student3!.CodingExperience!.ProgrammingLanguages!.Count());

Console.WriteLine("End of LAB_002.6");
Console.ReadKey();


Student student4a1 = null;
Student student4b1 = new();

//student4a1.FirstName= "Kurt"; //Does not compile
student4b1.FirstName= "Kurt";

Student student4a2 = student4a1 ??= new Student { FirstName = "***********" };
Student student4b2 = student4b1 ??= new Student { FirstName = "***********" };

Console.WriteLine("a:" +student4a2.FirstName);
Console.WriteLine("b:" +student4b2.FirstName);


Console.WriteLine("Done");



//TODO : LAB_002.2
//1. Notice the squiggly lines in this file.
//2. Compare it to the program.cs file 
//3. Set this app as startup
//4. Run it.
//5. Remember : it's all about warning other developers about potential runtime exception.

//TODO : LAB_002.3
//1. Remark line 7
//2. Examin line 9
//3. Run the app again
//4. Stop the app when it says 'End of LAB_002.3'

//TODO : LAB_002.4
//1. Remark line 19
//2. Examin lines 30 to 35, notice the use of ?? (called the null coalescing operator)
//3. Run the app again
//4. Stop the app when it says 'End of LAB_002.4'

//TODO : LAB_002.5
//1. Remark line 38
//2. Examin the if statement starting at line 41. this is a 'classical' aproach to check for an object being NULL or not
//3. Examin lines 50 and 53, notice the use of ??
//4. Run the app again
//5. Stop the app when it says 'End of LAB_002.5'

//TODO : LAB_002.6
//1. Remark line 56
//2. Examin line 59, notice the use of ! (called the null forgiving operator)
//3. Run the app again, what happens.
//4. Just remember this null forgiving operator isn't usefull at all.

//TODO : LAB_002.7
//Carefully examine lines 65 to 75
//Make yourself understand why a: shows "***********" and b: shows "Kurt"
//Watch https://www.youtube.com/watch?v=7KJmdE93HkI