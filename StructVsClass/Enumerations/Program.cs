using Enumerations;

Weekday today = Weekday.Friday;

Console.WriteLine($"Today is {today}, its index is {(int)today}.");

if (today == Weekday.Monday)
{
    Console.WriteLine("I don't like Mondays!");
}

Console.WriteLine("+++ for loop +++");
for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"The day with index {i} is {(Weekday)i}.");
}

Weekday[] weekdays = Enum.GetValues<Weekday>();
Dwarf[] dwarves = Enum.GetValues<Dwarf>();

Console.WriteLine("+++ foreach loop +++");
foreach (Weekday day in weekdays)
{
    Console.WriteLine($"The day with index {(int)day} is {day}.");
}

foreach (Dwarf dwarf in dwarves)
{
    Console.WriteLine($"{dwarf} has index {(int)dwarf}.");
}

Weekday parsedDay;
bool success = Enum.TryParse("Wednesday", out parsedDay);

if (success)
{
    Console.WriteLine($"The day is {parsedDay} with index {(int)parsedDay}.");
}
else
{
    Console.WriteLine($"Invalid Weekday! {parsedDay}");
}

return;


enum Dwarf
{
    Grumpy = 3,
    Dopey = 5,
}