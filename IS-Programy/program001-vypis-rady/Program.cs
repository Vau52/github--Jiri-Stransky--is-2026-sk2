// jednořádkový
/*
Toto je
více řádkový
komentář
*/


// jako první si připravíme smyčku pro opakování programu

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

// Vstup počáteční hodnoty - čpatně řešený
Console.Write("Zadejte první číslo řady: ");
int first = int.Parse(Console. ReadLine());

// Dotaz směrem k uživateli na opakování
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Pro opakování proramu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
Console.WriteLine("Jakoukoli jinou klávesou program ukončíte.");
Console.WriteLine();
Console.Write("Chcete program spustit znovu? ");
again= Console.ReadLine() ?? "";
}