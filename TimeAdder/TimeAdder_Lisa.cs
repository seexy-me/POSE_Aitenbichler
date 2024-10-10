/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: <3ACIF>
 *--------------------------------------------------------------
 *              <Lisa Seeberger> 
 *--------------------------------------------------------------
 * Description:
 * Uhrzeit in hh:mm:ss
 *--------------------------------------------------------------
*/

using System;

string input;
string timeParts;
int hh1;
int mm1;
int hh2;
int mm2;
int hh;
int mm;


Console.WriteLine("Einfacher Addierer für zwei Uhrzeiten");
Console.WriteLine("=====================================");
Console.WriteLine();

Console.WriteLine("Gib eine Uhrzeit oder Stunden und Minuten im Format hh:mm ein");
input = Console.ReadLine();
timeParts1 = input.Split(':');         // Split the input string by the colon
// Parse the hours and minutes
hh1 = int.Parse(timeParts[0]);
mm1 = int.Parse(timeParts[1]);

Console.WriteLine("Gib Stunden und Minuten im Format hh:mm ein, die hinzugefügt werden sollen");
input = Console.ReadLine();
timeParts2 = input.Split(':');         // Split the input string by the colon
// Parse the hours and minutes
hh2 = int.Parse(timeParts[0]);
mm2 = int.Parse(timeParts[1]);

// Perform calculations
mm = (mm1+mm2)%60;
hh = (mm1+mm2)/60+hh1+hh2;

Console.WriteLine($"{hh1:00}:{mm1:00} + {hh2:00}:{mm2:00} = {hh:00}:{mm:00}");
Console.ReadLine();