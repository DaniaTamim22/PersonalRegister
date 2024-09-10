

Console.WriteLine("Hello! Please enter employee information ....");

 class Employee
{
    string name;
    double salary;
    private void printEmployee (Employee emp)
    {
        Console.WriteLine("Employee Name is : " + emp.name);
        Console.WriteLine("the Salary is : " + emp.salary);
    }

}




Employee employee1 = new Employee();

Console.WriteLine("Enter Employee Name : ");
employee1.name=Console.ReadLine();

Console.WriteLine("Enter Salary: ");
employee1.salary = Console.ReadLine();


Employee employee2 = new Employee();  