using _02_02_Demonstration3;


Console.WriteLine("***Shallow vs Deep Copy Demo.***\n");
EmpAddress initialAddress = new EmpAddress("Yazd, Mehravaran");
Employee emp = new Employee(1, "Maryam", initialAddress);
Console.WriteLine("The original object is emp1 which is as follows: ");
Console.WriteLine(emp);
Console.WriteLine("Making a clone of emp1 now.");
Employee empClone = (Employee)emp.Clone();
Console.WriteLine("empClone object is as follows:");
Console.WriteLine(empClone);
Console.WriteLine("\n Now changing the name, id and address of the cloned object ");
empClone.Id = 10;
empClone.Name = "Parsa";
empClone.EmpAddress.Address = "Tehran, Satarkhan";
Console.WriteLine("Now emp1 object is as follows:");
Console.WriteLine(emp);
Console.WriteLine("And emp1Clone object is as follows:");
Console.WriteLine(empClone);