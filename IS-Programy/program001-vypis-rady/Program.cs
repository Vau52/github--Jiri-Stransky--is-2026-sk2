// jednořádkový
/*
Toto je
více řádkový
komentář
*/


// jako první si připravíme smyčku pro opakování programu

using System.Runtime.ExceptionServices;

string again = "a";
// .ToLower() převede vstup na mála písmena, takže program bude pokračovat při zadávaní "a" tak i A
while(again.ToLower() == "a" )
{
Console.Clear();
Console.WriteLine("******************************************");
Console.WriteLine("***************Výpis řady*****************");
Console.WriteLine("******************************************");
Console.WriteLine("***************Jiří Stránský**************");
Console.WriteLine("******************************************");
Console.WriteLine("******************************************");

// Vstup počáteční hodnoty - špatně řešený
Console.Write("Zadejte první číslo řady: ");
int first = int.Parse(Console. ReadLine());

// Dotaz směrem k uživateli na opakování
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Pro opakování proramu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
int fisrt;
while(!int.TryParse(Console.ReadLine(), out first))
{
Console. Write("Nezadali jste celé číslo! Zadejte první číslo řady znovu (celé číslo): ");
}


// vstup koncové hodnoty - správně řešený
Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");

Console.WriteLine();
Console.Write("Chcete program spustit znovu? ");
again= Console.ReadLine() ?? "";
}
//Vstup diference s kontrolkou kladné hodnoty
Console. Write("Zadejte diferenci (kladné celé číslo): ");
int step;
while(!int.TryParse(Console.ReadLine(), out step)  step);

    Console.WriteLine();
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("=================================================");
    Console.WriteLine($"První číslo: {first}");
     Console.WriteLine($"Poslední číslo: {last}");
      Console.WriteLine($"První číslo: {step}");
       Console.WriteLine("==============================================");
       Console.WriteLine();
       // Jádro algoritmu pro výpis řad čísel
       
       if(First = last)

       else
       {
        Console.WriteLine("Řadu nelze vypsat)