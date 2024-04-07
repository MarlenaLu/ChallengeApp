using ChallengeApp;

Employee employee1 = new Employee("Monika", "Kowalska", 25);
Employee employee2 = new Employee("Jan", "Nowak", 42);
Employee employee3 = new Employee("Marek", "Korek", 38);

employee1.AddScore(5);
employee1.AddScore(6);
employee1.AddScore(3);
employee1.AddScore(7);
employee1.AddScore(8);

employee2.AddScore(3);
employee2.AddScore(6);
employee2.AddScore(4);
employee2.AddScore(2);
employee2.AddScore(8);

employee3.AddScore(3);
employee3.AddScore(7);
employee3.AddScore(4);
employee3.AddScore(8);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int MaxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > MaxResult)
    {
        MaxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Pracownik z najwyższą liczbą ocen:");
Console.WriteLine("Imię:" + employeeWithMaxResult.name + "");
Console.WriteLine("Nazwisko:" + employeeWithMaxResult.surname + "");
Console.WriteLine("Wiek:" + employeeWithMaxResult.age + "");
Console.WriteLine("Liczba ocen:" + MaxResult);