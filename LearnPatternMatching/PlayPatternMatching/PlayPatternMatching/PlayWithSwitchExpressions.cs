using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayPatternMatching.Data;

namespace PlayPatternMatching
{

    internal static class PlayWithSwitchExpressions
    {

        public static void Lab001_1()
        {
            //TODO LAB001.1
            //1. Change the FirstName so the output is 'Case where FirstName is Thomas'
            //2. Change the so the output is 'Other Case'
            //Obviously you cannot change the returned string !
            var developer = new Developer();
            developer.FirstName = "Julia";

            string result = developer.FirstName switch
            {
                "Julia" => "Case where FirstName is Julia",
                "Thomas" => "Case where FirstName is Thomas",
                _ => "Other Case",
            };

            Console.WriteLine(result);
        }

        public static void Lab001_2()
        {
            //TODO LAB001.2
            //Give the developers the needed properties for returning each one of the 3 cases
            //Obviously you cannot change the returned string !
            var developer1 = new Developer();

            string result1 = developer1 switch
            {
                { FirstName: "Julia" } => "Case where FirstName is Julia",
                { LastName: "Edison" } => "Case where LastName is Edison",
                _ => "Other Case",
            };

            Console.WriteLine(result1); //Case where FirstName is Julia

            var developer2 = new Developer();

            string result2 = developer1 switch
            {
                { FirstName: "Julia" } => "Case where FirstName is Julia",
                { LastName: "Edison" } => "Case where LastName is Edison",
                _ => "Other Case",
            };

            Console.WriteLine(result2); //Case where LastName is Edison

            var developer3 = new Developer();

            string result3 = developer1 switch
            {
                { FirstName: "Julia" } => "Case where FirstName is Julia",
                { LastName: "Edison" } => "Case where LastName is Edison",
                _ => "Other Case",
            };

            Console.WriteLine(result3); //"Other Case
        }

        public static void Lab001_3()
        {
            //TODO LAB001.3
            //1. Examine the 4 switch arms.
            //2. Change the YearOfBirth to 1981 (do not change the switch).
            //3. Run it
            //4. Uncomment the 2 lines where the employee is a manager (you might need to comment another line of code)
            //5. Run it
            //6. Add a property to the Manager class for the managers salary (as an int)
            //7. Give the manager a decent salary
            //7. Update the switch arm for the manager so it returns 'This person is a manager with salary x' where x is this salary.
            //8. Run it

            var developer = new Developer();
            developer.FirstName = "Thomas";
            developer.YearOfBirth = 1981;

            var employee = (Employee)developer;

            //var manager = new Manager();            
            //var employee = (Employee)manager;

            string result = employee switch
            {
                Developer dev when dev.YearOfBirth == 1980 => $"{dev.FirstName} is a developer born in 1980",
                Developer dev => $"{dev.FirstName} is a developer not born in 1980",
                Manager => "This person is a manager",
                _ => "Non of the previous switch arms were executed",
            };

            Console.WriteLine(result);
        }


        public static void Lab001_4()
        {
            //TODO LAB001.4
            //1. Examine the second switch arm.
            //2. Set the year of birth to 1970
            //3. Run it.
            //4. Add a switch arm for a developer having loads of experience
            //      - add a property LinesOfCodeWritten to the developer class
            //      - set the property for the developer to 2 million;
            //      - write the switch arm restulting in 'this developer has loads of experience' using the IsExperienced function below.
            //      - add this new switch arm as the last one before the 'other case' arm.
            //5. Run it
            //6. Change the order of this new switch arm so it preceeds the 'older than 50' switch arm.
            //7. Run it
            var developer = new Developer();
            developer.FirstName = "Kurt";
            developer.YearOfBirth = 1970;

            string result = developer switch
            {
                Developer dev when dev.YearOfBirth >= 1980 && dev.YearOfBirth <= 1989
                  => $"{dev.FirstName} was born in the 80's",
                                  

                Developer dev when dev.YearOfBirth <= DateTime.Now.Year - 50
                  => "our trainer is not so young anymore",

                
                _ => "other case"
            };

            Console.WriteLine(result);
        }

        private static bool IsExperienced(int linesCodeWritten)
        {
            Console.WriteLine("Calculating is expierenced");
            if (linesCodeWritten > 1000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Lab001_5()
        {
            //TODO LAB001.5
            //1. Uncomment these lines of code.
            //2. Does it compile ?
            //3. Check the error.
            //4. Comment the lines again so we can continue ....

            //var input = 4;
            //var output = 4 switch
            //{
            //    < 3 => "less than 3",
            //    <= 7 => "less than or equal to 7",
            //    < 1 => "less than 10",
            //    _ => "greater than or equal to 10"
            //};

        }

        public static void Lab001_6()
        {
            //TODO LAB001.6
            //Look at this, ...
            //-> no type matching
            //-> the boolean logic is on the left of the =>
            //-> this boolean logic is expressed in natural language (or instead of ||, ...)
            var output = 4 switch
            {
                1 or 2 or 3 => "1, 2, or 3",
                > 3 and <= 6 => "between 3 and 6",
                not 7 => "not 7",
                _ => "7"
            };
        }

        public static void Lab001_7()
        {
            //TODO LAB001.7
            //1. Run it. Output should be "normal"
            //2. Change Height and Width to 9
            //3. Run it again. What Happens ?
            //4. Add a default siwtch arm so the app doesn't crash.
            var rectangle = new Rectangle
            {
                Width = 11,
                Length = 11,
            };

            string result = rectangle switch
            {
                { Width: > 100, Length: > 100 } => "big",
                { Width: > 10, Length: > 10 } => "normal"
            };

            Console.WriteLine(result);
        }

        public static void Lab001_8()
        {
            //TODO LAB001.8
            //1. Notice the (x,y) variables before the switch statement.
            //2. Run it
            //3. Change the y value to 11
            //4. Run it
            //5. Change the x value to SomeEnum.That
            //6. Change the y value to whatever you want.
            //7. Run it
            //8. Uncomment the SomethingElse switch arm
            //9. See the error
            //10. Delete the SomethingElse switch arm
            //11. Add 4 switch arms
            //      - for AnotherThing with a y value above 0 and less or equal to 5
            //      - for AnotherThing with a y value above 5 and less or equal to 10
            //      - for AnotherThing with a y value above 10 and less or equal to 15
            SomeEnum x = SomeEnum.That;
            var y = 11;
            string result = (x, y) switch
            {
                (SomeEnum.This, 10) => "This is 10",
                (SomeEnum.This, < 10) => "This is below 10, it's acutally " + y,
                (SomeEnum.This, > 10) => "This is above 10, it's acutally " + y,
                (SomeEnum.That, _) => "That, not evaluating the y value",                
                //SomeEnum.SomethingElse => "Something else",
                _ => throw new NotImplementedException(),
            };

            Console.WriteLine(result);
        }

       
    }
}
