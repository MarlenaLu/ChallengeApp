string name = "Ewa";
string sex = "kobieta";
var age = 26;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex != "kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

