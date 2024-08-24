/*Task-1 
Add two new variables to your program that stores string values. One of them is going 
to store your first name and the other your last name, so give them informative 
names. Then let the program out put the following text on console.
“Hello <firstname> <lastname>! I’m glad to inform you that you are the test 
subject of my very first assignment!”*/


using System.Net.Security;
using System.Runtime.InteropServices;

//string Name = "";
//string lastname = "";
Console.WriteLine("Name?");string Name = Console.ReadLine();Console.WriteLine("Lastname?");string lastname = Console.ReadLine();Console.WriteLine($" Hello {Name},{lastname}");
Console.ReadKey();

/*
* Task-2 
Create three newvariables oftype Date Time andletthemstoreyesterdays,todaysand
tomorrowsdate. Rememberto give theminformative names. Thenlet yourprogram
output them to the screen like:
“Todays date is <todays date>” 
“Tomorrows date is <tomorrows date>”
“Yesterdays date was <yesterdays date>”
*/

DateTime _now = DateTime.Now;
DateTime _tomorrow = _now.AddDays(1);
DateTime _yesterday = _now.AddDays(-1);
Console.WriteLine($"Today is {_now},\nTomorrow is{_tomorrow},\n Yesterday was{_yesterday}");
Console.ReadKey();