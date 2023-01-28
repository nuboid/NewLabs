//TODO : LAB_001.1
//1. Set this console app as startup and run it.
//2. What happens ?
//3. Read https://learn.microsoft.com/en-us/dotnet/api/system.nullreferenceexception?view=net-6.0

using PlayNullableReferenceTypes;

var student = new Student();
student.FirstName = "XXXXXXXXX";
student.LastName = "XXXXXXXXX";

Console.WriteLine("Number of programming languages student : " + student.CodingExperience.ProgrammingLanguages.Count);

//TODO : LAB_001.3
//1. Open the project file by double clicking on the name of the project.
//2. Notice line 7
//3. Remark line 7, so it becomes  <!--<Nullable>enable</Nullable>-->
//4. Go back to the Student.cs file (wait a couple of seconds)
//5. What happened with the squiggly lines ?
//6. Run the app again ?
//7. Unremark line 7 again so it becomes <Nullable>enable</Nullable> ... the squigly lines and warning are back.

//TODO : LAB_001.6
//1. Open the project file by double clicking on the name of the project.
//2. Unremark lines 10 to 16
//3. Build the project.
//4. What happens ?