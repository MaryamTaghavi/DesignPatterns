// Shallow copy => کپی سطحی یعنی به هنگام کپی فقط سطح اول کپی شود، اگر متغیر
// reference type موجود بود فقط اشاره گر به حافظه کپی میشود پس هر تغییر در اولی روی دومی هم اثر میگذارد

/*
در شلو کپی فقط خود آبجکت اصلی کپی میشود ولی اعضای رفرنس تایپ هنوز مشترکند ولی
در دیپ کپی نه فقط آبجکت اصلی بلکه تمام آبجکت های داخلی هم جداگونه کپی میشوند و 
هیچ شیرد رفرنسی باقی نمی ماند.
 */

var p1 = new Person { Name = "Alice", Address = new Address { City = "Berlin" } };
var p2 = p1.ShallowCopy();

p2.Name = "Bob";              // فقط روی p2 اثر دارد
p2.Address.City = "Hamburg";  // روی هر دو اثر دارد!

try
{
    Console.WriteLine("p1 Address in shallow copy : {0}", p1.Address.City);
    Console.WriteLine("p2 Address in shallow copy : {0}", p2.Address.City);


    var p3 = new Person1 { Name = "Alice", Address = new Address { City = "Berlin" } };
    var p4 = p3.DeepCopy();

    p4.Address.City = "Hamburg"; // Berlin (تغییر نکرد)

    Console.WriteLine("p3 Address in deep copy : {0}", p3.Address.City);
    Console.WriteLine("p4 Address in deep copy : {0}", p4.Address.City);
}
catch (Exception ex)
{
}
Console.ReadLine();

// Example 1
public class Address
{
    public string City { get; set; }
}

public class Person
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public Person ShallowCopy()
    {
        return (Person)this.MemberwiseClone(); // کپی سطحی
    }
}

// Deep copy => یعنی کپی عمیق، کاملا وابستگی کپی با اولی از بین میرود و هر تغییری در اولی روی دومی اثری نمیگذارد.

public class Person1
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public Person1 DeepCopy()
    {
        return new Person1
        {
            Name = this.Name,
            Address = new Address { City = this.Address.City } // کپی جداگانه
        };
    }
}

// Example 2

public class ShallowDocument
{
    public List<string> Pages { get; set; }

    // Instance
    public ShallowDocument(List<string> Pages)
    {
        this.Pages = Pages;
    }

    // Shallow Copy
    public ShallowDocument(ShallowDocument newObject)
    {
        this.Pages = newObject.Pages;
    }
}

public class DeepDocument
{
    public List<string> Pages { get; set; }

    // Instance
    public DeepDocument(List<string> Pages)
    {
        this.Pages = Pages;
    }

    // Deep Copy
    public DeepDocument(DeepDocument newObject)
    {
        this.Pages = new List<string> ( newObject.Pages );
    }
}

public class Page
{
    public string Content { get; set; }
}

public class Chapter
{
    public string Title { get; set; }
    public List<Page> Pages { get; set; }
}

//Deep Copy from Book
public class Book
{
    public string Name { get; set; }
    public List<Chapter> Chapters { get; set; }

    // متد Clone (Prototype) باید اینجا باشه
    public Book Clone(Book oldObject)
    {
        var newBook = new Book();
        newBook.Name = oldObject.Name;
        foreach(var item in oldObject.Chapters)
        {
            newBook.Chapters.Add(new Chapter()
            {
                Pages = item.Pages.Select(p => new Page { Content = p.Content }).ToList(),
                Title = item.Title
            });
        }
        return newBook;
    }
}