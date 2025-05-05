
namespace Tasks.ConsoleApplication;
 class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
    public Employee(int empId, string name, string department, decimal salary)
    {
        EmployeeId = empId;
        Name = name;
        Department = department;
        Salary = salary;
    }

}
class PermanentEmployee : Employee
{
    public DateOnly JoingDate { get; set; }
    public bool HasInsuranceCoverage { get; set; }
    public int LeaveEncashmentBalance { get; set; }
    public PermanentEmployee(int empId, string name, string department, 
        decimal salary, DateOnly joingDate, bool hasInsuranceCoverage,
        int leaveEncashmentBalance) : base(empId, name, department, salary)
    {
        JoingDate = joingDate;
        HasInsuranceCoverage = hasInsuranceCoverage;
        LeaveEncashmentBalance = leaveEncashmentBalance;
    }
    public  void ShowEmployeeDetails()
    {
        Console.WriteLine($"{EmployeeId}\t{Name}\t" +
            $"{Department}\t\t{Salary}\t{JoingDate}" +
            $"\t\t{HasInsuranceCoverage}\t\t{LeaveEncashmentBalance}");
    }

}
class ContractEmployee : Employee
{
    public int ContractDurationMonths { get; set; }
    public bool IsRemote { get; set; }
    public ContractEmployee(int empId, string name, string department, decimal salary,
        int contractDurationMonths, bool isRemote) : base(empId, name, department, salary)
    {
        ContractDurationMonths = contractDurationMonths;
       IsRemote = isRemote;
    }
    public  void ShowEmployeeDetails()
    {
        Console.WriteLine($"{EmployeeId}\t{Name}" +
            $"\t{Department}\t\t{Salary}\t\t" +
            $"{ContractDurationMonths}\t\t{IsRemote}");
    }
}
internal class EmployeeManagementSystem
{
    List<PermanentEmployee> permanetEmployees = new List<PermanentEmployee>()
    {
        {new PermanentEmployee(1,"boobathi","Testing",5000,new DateOnly(2025,5,5),true ,10 )  },
        {new PermanentEmployee(2,"santhosh","Developer",50000, new DateOnly(2023,10,5),true ,9 )  },
    };

    List<ContractEmployee> contractEmployees = new List<ContractEmployee>()
    {
        {new ContractEmployee(3,"durai","Testing",5000,6,true  )  },
        {new ContractEmployee(4,"surya","Testing",5000,12,false )  },
        }; 
  
    public void Management()
    {
        ShowEmployees();
        UpdateEmployeeDetails();
    }

    private void ShowEmployees()
    {
        Console.WriteLine("Permanent Employees:");
        Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");
        Console.WriteLine("ID\tName\t\tDepartment\tSalary\tJoiningDate\tInsuranceCoverage\tLeaveEncashmentBalance");
        Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");
        foreach (var employee in permanetEmployees)
        {
            employee.ShowEmployeeDetails();
        }
        Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");

        Console.WriteLine("\nContract Employees:");
        Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");
        Console.WriteLine("ID\tName\t\tDepartment\tSalary\tContractDurationMonths\tIsRemote");
        Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");
        foreach (var employee in contractEmployees)
        {
            employee.ShowEmployeeDetails();
        }
        Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");

    }

    private void UpdateEmployeeDetails()
    {
        Console.WriteLine("\n1. Create a New Permanent Employee\n2. Create a New Permanent Employee\n3. Delete an Employee\n4. Exit");
        int option = GetOption();
        do
        {
            if (option == 1)
            {
                Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");
                Console.WriteLine("Creating a new Permanent Employee...");
                int employeeId = GetEmployeeId();
            CheckAgain1:
                if (permanetEmployees.Any(employee => employee.EmployeeId == employeeId))
                {
                    Console.Write("Employee ID already exists. Please enter a unique Employee ID....");
                    employeeId = GetEmployeeId();
                    goto CheckAgain1;
                }
                else if(contractEmployees.Any(employee => employee.EmployeeId == employeeId))
                {
                    Console.Write("Employee ID already exists. Please enter a unique Employee ID....");
                    employeeId = GetEmployeeId();
                    goto CheckAgain1;
                }
                    string employeeName = GetEmployeeName();
                string employeeDepartment = GetEmployeeDepartment();
                decimal employeeSalary = GetEmployeeSalary();
                DateOnly joiningDate = GetJoiningDate();
                bool hasInsuranceCoverage = HasInsuranceCoverage();
                int leaveEncashmentBalance = LeaveEncashmentBalance();
                PermanentEmployee newPermanentEmployee = new PermanentEmployee(employeeId, employeeName, employeeDepartment, employeeSalary, joiningDate, hasInsuranceCoverage, leaveEncashmentBalance);

                permanetEmployees.Add(newPermanentEmployee);

                Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");
                ShowEmployees();
            }
            else if (option == 2)
            {
                Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");
                Console.WriteLine("Creating a new Contract Employee...");
                int employeeId = GetEmployeeId();
            CheckAgain:
                if (contractEmployees.Any(employee => employee.EmployeeId == employeeId) )
                {
                    Console.Write("Employee ID already exists. Please enter a unique Employee ID....");
                    employeeId = GetEmployeeId();
                    goto CheckAgain;
                }
                else if (permanetEmployees.Any(employee => employee.EmployeeId == employeeId))
                {
                    Console.Write("Employee ID already exists. Please enter a unique Employee ID....");
                    employeeId = GetEmployeeId();
                    goto CheckAgain;
                }
                string employeeName = GetEmployeeName();
                string employeeDepartment = GetEmployeeDepartment();
                decimal employeeSalary = GetEmployeeSalary();
                int contractDuration = GetContractDuration();
                bool isRemote = GetIsRemote();
                ContractEmployee contractEmployee = new ContractEmployee(employeeId, employeeName, employeeDepartment, employeeSalary, contractDuration, isRemote);
                contractEmployees.Add(contractEmployee);
                Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");
                ShowEmployees();
            }
            else if (option == 3)
            {
                Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");
                Console.WriteLine("Removing employee from the list...");
                Console.WriteLine("Enter Employee ID to remove:");
                int employeeId = GetEmployeeId();
                var employeeToRemove = permanetEmployees.FirstOrDefault(e => e.EmployeeId == employeeId);
                if (employeeToRemove != null)
                {
                    permanetEmployees.Remove(employeeToRemove);
                    Console.WriteLine($"Employee with ID {employeeId} removed from the list.");
                    Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");
                }
                else
                {
                    ContractEmployee employeeToRemove2 = contractEmployees.FirstOrDefault(employee => employee.EmployeeId == employeeId);
                    if (employeeToRemove2 != null)
                    {
                        contractEmployees.Remove(employeeToRemove2);
                        Console.WriteLine($"Employee with ID {employeeId} removed from the list.");
                        Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");

                    }
                    else
                    {
                        Console.WriteLine($"Employee with ID {employeeId} not found.");
                        Console.WriteLine("Enter a valid Employee ID to remove:");
                        employeeId = GetEmployeeId();
                    }
                }
                ShowEmployees();
            }
            else if (option == 4)
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
            Console.WriteLine("\n1. Create a New Permanent Employee\n2. Create a New Permanent Employee\n3. Delete an Employee\n4. Exit");
            option = GetOption();
        } while (option != 4);
    
    }

    private int GetOption()
    {
        Console.Write("Enter your choice (1-4):");
        int option;
        while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 4)
        {
            Console.Write("Invalid input. Please enter a number between 1 and 4 : ");
        }
        return option;
    }
    private int GetEmployeeId()
    {
        Console.Write("Enter Employee ID:");
        int empId;
        while (!int.TryParse(Console.ReadLine(), out empId))
        {
            Console.Write("Invalid input. Please enter a valid Employee ID.");
        }
        return empId;
    }

    private string GetEmployeeName()
    {
        Console.Write("Enter Employee Name:");
        string name = Console.ReadLine();
        if(!int.TryParse(name , out int result))
        {
            return name;
        }
        Console.Write("Please enter a valid Employee Name : ");
        return GetEmployeeName();
    }

    private string GetEmployeeDepartment()
    {
        Console.WriteLine("\n--------------------------------------------------------------------------------------------\n");
        Console.WriteLine("Available Departments:");
        Console.WriteLine("* Finance\n* HR\n* IT\n* Testing");
        List<string> departments = new List<string>() { "finance", "hr", "it", "testing" };
        Console.Write("Enter Employee Department:");
        string department = Console.ReadLine().ToLower();
        if (!int.TryParse(department, out int result))
        {
            if (departments.Contains(department))
            {
                return department;
            }
        }
        Console.Write("Please enter a valid Employee Department : ");
        return GetEmployeeDepartment();
    }

    private decimal GetEmployeeSalary()
    {
        Console.Write("Enter Employee Salary:");
        decimal salary;
        while (!decimal.TryParse(Console.ReadLine(), out salary))
        {
            Console.Write("Please enter a valid Salary: ");
        }
        return salary;
    }

    private DateOnly GetJoiningDate()
    {
        Console.Write("Enter Joining Date (yyyy-mm-dd):");
        DateOnly joiningDate;
        while (!DateOnly.TryParse(Console.ReadLine(), out joiningDate))
        {
            Console.Write("Please enter a valid date (yyyy-mm-dd): ");
        }
        return joiningDate;
    }

    private bool HasInsuranceCoverage()
    {
        Console.Write("Does the employee have insurance coverage? (y/n):");
        string hasInsuranceCoverage=Console.ReadLine().ToLower().Trim();
        if (hasInsuranceCoverage == "y")
        {
            return true;
        }
        else if (hasInsuranceCoverage == "n")
        {
            return false;
        }
        else
        {
            Console.Write("Please enter a valid response (y/n): ");
            return HasInsuranceCoverage();
        }
    }

    private int LeaveEncashmentBalance()
    {
        Console.Write("Enter Leave Encashment Balance:");
        int leaveEncashmentBalance;
        while (!int.TryParse(Console.ReadLine(), out leaveEncashmentBalance))
        {
            Console.Write("Please enter a valid Leave Encashment Balance: ");
        }
        return leaveEncashmentBalance;
    }

    private int GetContractDuration()
    {
        Console.Write("Enter Contract Duration (in months):");
        int contractDuration;
        while (!int.TryParse(Console.ReadLine(), out contractDuration))
        {
            Console.Write("Please enter a valid contract duration: ");
        }
        return contractDuration;

    }

    private bool GetIsRemote()
    {
        Console.Write("Is the employee working remotely? (y/n):");
        string isRemote = Console.ReadLine().ToLower().Trim();
        if(isRemote == "y")
        {
            return true;
        }
        else if (isRemote == "n")
        {
            return false;
        }
        else
        {
            Console.Write("Please enter a valid response (true/false): ");
            return GetIsRemote();
        }
        
    }


}
