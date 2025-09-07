using _05_00_CompositePattern;

/*
مزایای این پترن : یکنواختی (uniformity) است و میتوان با یک اینترفیس به کل ساختار دسترسی داشت.
انعلاف پذیری و مدیریت سلسله مراتب ها
 */

/*
معایب این پترن :
پیچیدگی مدیریت فرزندان : ordering آنها،
افزایش هزینه نگهداری نودها، امکان نقض کنترل دسترسی (چون همه نودها از یک اینترفیس پیروی میکنند، ممکنه عملیاتی به انها تحمیل شود که معنادار نیست)
 */
Console.WriteLine("***Composite Pattern Demo. ***");

#region Mathematics department
// 2 lecturers work in Mathematics department
Employee mathTeacher1 = new Employee
{
    Name = "M.Joy",
    Dept = "Mathematic",
    Designation = "Lecturer"
};
Employee mathTeacher2 = new Employee
{
    Name = "M.Roony",
    Dept = "Mathematics",
    Designation = "Lecturer"
};
// The college has a Head of Department in Mathematics
CompositeEmployee hodMaths = new CompositeEmployee
{
    Name ="Mrs.S.Das",
    Dept = "Maths",
    Designation = "HOD-Maths"
};
// Lecturers of Mathematics directly reports to HOD-Maths
hodMaths.AddEmployee(mathTeacher1);
hodMaths.AddEmployee(mathTeacher2);
#endregion

#region Computer Science department
// 3 lecturers work in Computer Sc. department
Employee cseTeacher1 = new Employee
{
    Name = "C.Sam",
    Dept = "Computer Science",
    Designation = "Lecturer"
};
Employee cseTeacher2 = new Employee
{
    Name = "C.Jones",
    Dept = "Computer Science.",
    Designation = "Lecturer"
};
Employee cseTeacher3 = new Employee
{
    Name = "C.Marium",
    Dept = "Computer Science",
    Designation = "Lecturer"
};
// The college has a Head of Department in Computer science
CompositeEmployee hodCompSc = new CompositeEmployee
{
    Name = "Mr.V.Sarcar",
    Dept = "Computer Sc.",
    Designation = "HOD - Computer Sc."
};
/* Lecturers of Computer Sc. directly reports to HOD-CSE */
hodCompSc.AddEmployee(cseTeacher1);
hodCompSc.AddEmployee(cseTeacher2);
hodCompSc.AddEmployee(cseTeacher3);
#endregion

#region Top level management
// The college also has a Principal
CompositeEmployee principal = new CompositeEmployee
{
    Name = "Dr.S.Som",
    Dept = "Planning-Supervising-Managing",
    Designation = "Principal"
};
/* Head of Departments's of Maths and Computer Science directly
reports to Principal.*/
principal.AddEmployee(hodMaths);
principal.AddEmployee(hodCompSc);
#endregion

/*
* Printing the leaf-nodes and branches in the same way. i.e.
in each case, we are calling DisplayDetails() method.
*/
Console.WriteLine("\nDetails of a Principal object is as follows:");
// Prints the complete structure
principal.DisplayDetails();
Console.WriteLine("\nDetails of a HOD object is as follows:");
/* Prints the details of Computer Science department */
hodCompSc.DisplayDetails();
// Leaf node
Console.WriteLine("\nDetails of an individual employee(leafnode) is as follows:");
mathTeacher1.DisplayDetails();
/*
* Suppose, one Computer Science lecturer(C.Jones)
* is leaving now from the organization.
*/
hodCompSc.RemoveEmployee(cseTeacher2);
Console.WriteLine("\nAfter the resignation of C.Jones, the organization has the following members: ");
principal.DisplayDetails();
// Wait for user
Console.ReadKey();