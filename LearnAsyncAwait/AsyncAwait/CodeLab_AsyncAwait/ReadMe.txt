Start the winforms application CodeLab_AsyncAwait

This application will download a .jpg file from the NASA website.
This size of the file is 28.4 MB, so downloading will take a couple of seconds.

See : https://visibleearth.nasa.gov/

Exercise 1
 Examin the Download1 method in NasaBlueMarbleDownloader.cs.
 Click the Button Exercise 1.
 Click OK to start the download and try to check/uncheck the checkbox on the form.

Exercise 2
Examin the Download2 method in NasaBlueMarbleDownloader.cs.
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
 Fix the bug.
