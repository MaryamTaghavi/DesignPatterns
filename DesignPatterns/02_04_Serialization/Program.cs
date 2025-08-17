using _02_04_Serialization;

Console.WriteLine("***Prototype Pattern Demo With Deep copy***\n");
Person person = new Person();
person.UserName = "m.taghavi";
person.FirstName = "Maryam";
person.LastName = "Taghavi";

var newObject = person.DeepCopy();
var newPerson = newObject.Item2;
var newPerson2 = newObject.Item1;

Console.WriteLine($"UserName is: {newPerson.UserName}, FirstName is: {newPerson.FirstName}, LastName is: {newPerson.LastName}");

newPerson2.UserName = "p.ramezanpoor";
newPerson2.FirstName = "Parsa";
newPerson2.LastName = "Ramezanpoor";
Console.WriteLine($"UserName is: {newPerson2.UserName}, FirstName is: {newPerson2.FirstName}, LastName is: {newPerson2.LastName}");

Console.ReadLine();