-----------------------------------------------------------------------------------------
1. CodeLab_AsyncAwait
---------------------

Start the winforms application CodeLab_AsyncAwait

This application will download a .jpg file from the NASA website.
This size of the file is 28.4 MB, so downloading will take a couple of seconds.

See : https://visibleearth.nasa.gov/

Exercise 1
 Click the Button Exercise 1.
 Click OK to start the download and try to check/uncheck the checkbox on the form.

Exercise 2
 Click the Button Exercise 2
 Click OK to start the download and try to check/uncheck the checkbox on the form.


 What's the difference ?
 What will the user prefer ?


Exercice 3
 Uncomment the method starting at line 40 in the file Serivce/NasaBlueMarbleDownloader.cs
 You will see it does not compile. Read the error message carefully.
 Implement the proposed potential fix.

 What do you need to change in the method signature to make it compile ?

 Comment the method again.

Exercice 4
 See the method Download4 in the file Serivce/NasaBlueMarbleDownloader.cs
 Now update the button for exercise 2 so it now uses this Download4 method instead of he Download2 method.
 Start the download again (with button exercise 2) and check the debug window.
 Also set a breakpoint on the return statement in the Download4 method 
 Hover over the response variable and examin the flyover message.



-----------------------------------------------------------------------------------------
2. CodeLab_AsyncBreakfast_before and  CodeLab_AsyncBreakfast_after
------------------------------------------------------------------

Additional Tasks
 Run the CodeLab_AsyncBreakfast_before console app.
 Run the CodeLab_AsyncBreakfast_after console app.
 See the differences.
 Examin the CodeLab_AsyncBreakfast_after code, pay attention to await keywords and the return types of the called methods (like FryEggsAsync())

 Additional reading 
  https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
  https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/task-asynchronous-programming-model



-----------------------------------------------------------------------------------------
3. CodeLab_Demo1
-------------

Set CodeLab_Demo1 as Startup Projects.

Set 3 breakpoints
  one at line 10
  one at line 19
  one at line 29

Examine SomeMethod1 and SomeMethod2.
 Pay attention to the signature of the methods.
 You'll notice that SomeMethod2 does a call to read a file by using File.ReadAllTextAsync.

Run the application and write down the order in which the breakpoints are hit.

Now change line 8 so it calls SomeMethod2.

Run the application again write down the order in which the breakpoints are hit.

Compare the orders of the two scenarios.

Now examin SomeMethod3. 
 Is the signature the same as SomeMethod2 ? 
 What's the difference ?

Change line 8 so it calls SomeMethod3. 
 Notice the flyover warning and read it carefully.
 Add the await keyword before the SomeMethod3 call in line 8.
 You'll see the flyover warning has disapeared.

Now add a breakpoint in line 39.

Run the application again and write down the order in which the breakpoints are hit.

Encourage yourself to avoid using async void methods.


BTW : Check the content of SomeFile.txt. It contains dummy text generated by https://www.lipsum.com/.
Can be handy if you need some texts for demos.

-----------------------------------------------------------------------------------------
4. Make a presentation.
-----------------------

Make a 1 slide Presentation on the topic of Await / Async.
It should include 5 bullet points with advice on how to use Await / Async
We will review these slides in group.










  



