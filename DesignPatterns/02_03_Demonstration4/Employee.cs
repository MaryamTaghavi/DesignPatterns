namespace _02_03_Demonstration4;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public EmpAddress EmpAddress { get; set; }

    // Instance Constructor
    public Employee(int id, string name, EmpAddress empAddress)
    {
        this.Id = id;
        this.Name = name;
        this.EmpAddress = empAddress;
    }

    // کپی کانستراکتور یکی از روش های deep copy است
    // Copy Constructor
    public Employee(Employee originalEmployee)
    {
        this.Id = originalEmployee.Id;
        this.Name = originalEmployee.Name;
        //this.EmpAddress = (EmpAddress)this.EmpAddress.CloneAddress(); // ok
        this.EmpAddress = originalEmployee.EmpAddress.CloneAddress() as EmpAddress; // Also ok
    }
    public override string ToString()
    {
        return string.Format("Employee Id is : {0},Employee Name is: {1}, Employee Address is : {2}", this.Id, this.Name, this.EmpAddress);
    }
}
