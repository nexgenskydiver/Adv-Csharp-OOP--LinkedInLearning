﻿// Challenge: create a class hierarchy to represent employees

var Emp1 = new HourlyEmployee() { FullName = "John Doe", Department = "Sales", PayRate = 35.0m };
var Emp2 = new SalariedEmployee() { FullName = "Jane Deaux", Department = "Marketing", Salary = 75000.0m };

Console.WriteLine($"Count: {Employee.EmployeeCount}");

var Emp3 = new SalariedEmployee() { FullName = "Jenny Doh", Department = "Engineering", Salary = 95000.0m };
Console.WriteLine($"Count: {Employee.EmployeeCount}");

var Emp4 = new HourlyEmployee() { FullName = "Jim Dough", Department = "Tech Support", PayRate = 45.0m };
Console.WriteLine($"Count: {Employee.EmployeeCount}");

Console.WriteLine($"{Emp1}");
Console.WriteLine($"{Emp2}");
Console.WriteLine($"{Emp3}");
Console.WriteLine($"{Emp4}");