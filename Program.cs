Console.WriteLine("Wprowadź z klawiatury dowolną liczbę rzeczywistą:   ");
string number = Console.ReadLine();
float numberToFloat = float.Parse(number);
if (numberToFloat == 0)
{
    Console.WriteLine("Wprowadzona liczba jest równa 0.");
}
else if (numberToFloat < 0)
{
    Console.WriteLine("Wprowadzona liczba jest ujemna.");
}
else if (numberToFloat > 0)
{
    Console.WriteLine("Wprowadzona liczba jest dodatnia.");
}
