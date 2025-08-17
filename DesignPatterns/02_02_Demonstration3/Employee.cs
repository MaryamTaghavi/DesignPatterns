namespace _02_02_Demonstration3;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public EmpAddress EmpAddress { get; set; }
    public Employee(int id, string name, EmpAddress empAddress)
    {
        this.Id = id;
        this.Name = name;
        this.EmpAddress = empAddress;
    }
    public override string ToString()
    {
        return string.Format("Employee Id is : {0},Employee Name is: {1}, Employee Address is : {2} ", this.Id, this.Name, this.EmpAddress);
    }
    public object Clone()
    {
        // Shallow Copy
        //return this.MemberwiseClone();

        #region For deep copy

        Employee employee = (Employee)this.MemberwiseClone();
        employee.EmpAddress = (EmpAddress)this.EmpAddress.CloneAddress();
        /*
        * NOTE:
        * Error: MemberwiseClone() is protected, you cannot access
        it via a qualifier of type EmpAddress. The qualifier must be
        Employee or its derived type.
        */
        //employee.EmpAddress = (EmpAddress)this.EmpAddress.MemberwiseClone(); // error
        return employee;

        #endregion

        /* MemberwiseClone یک متد protected است
         یعنی داخل همان کلای یا کلاس های مشتق شده فقط کاربرد دارد */
    }
}
