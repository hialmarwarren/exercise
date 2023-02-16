Console.WriteLine("Wprowadź z klawiatury dowolną liczbę dni:   ");
string number = Console.ReadLine();
int numberOfDays = int.Parse(number);
int y, t, d;
y = numberOfDays / 365;
t = (numberOfDays-y*365)  / 7;
d = numberOfDays - y*365 - t*7;
//lata
Console.WriteLine("To " + numberOfDays / 365+" pełnych l");
//tygodnie
Console.WriteLine("lub " + numberOfDays / 7 + " pełnych t");
//dni
Console.WriteLine("lub "+numberOfDays+ " pełnych d");
Console.WriteLine();
Console.WriteLine("Co daje sumarycznie: "+y+" l, "+t+" t i "+ d+" d");

