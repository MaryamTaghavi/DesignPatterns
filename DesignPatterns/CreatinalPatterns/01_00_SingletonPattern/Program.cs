// Ensure a class has only one instance, and provide a global point of access to it.

/* Properties :
 1) The class that we define instance must be sealed
 2) The variable must be private 
 3) We define static method to get that private variable
 4) The instance must be static because we must create one and access that from others */

/* Static constructor :
 1) Must be parameterless
 2) It doesn't have access modifier
 3) Just run for once.
 4) We can not call it. */

/*
معایب این پترن :
1) در مباحث چند تردی ممکنه مدیریت آن مشکل ساز بشود.
2) چون یک کلاس هم مسئولیت ایجاد و هم نگهداری یک نمونه را به عهده دارد اصل single responsibility زیر سوال میرود.
3) scalibility (گسترش) ممکن است مشکل ایجاد کند.
4) تست نویسی برای متغییر singletone مشکل است.
 */

namespace SingletonPatternUsingStaticConstructor;


// First way
public sealed class Singleton
{

    private static readonly Singleton Instance;
    private static int TotalInstances;

    // توی سی شارپ اگه ما کانستراکتور تعریف نکنیم کامپایلر به صورت پیش فرض یک کانستراکتور پابلیک پیش فرض ایجاد میکند.
    // پس برای محافظت از کلاس باید یک کانستراکتور خصوصی تعریف کنیم که کسی از بیرون نتواند آن را ایجاد (new) کند
    private Singleton()
    {
        Console.WriteLine("--Private constructor is called.");
        Console.WriteLine("--Exit now from private constructor.");
    }

    // روش اول : static constructor
    static Singleton()
    {
        Console.WriteLine("-Static constructor is called.");
        Instance = new Singleton();
        TotalInstances++;
        Console.WriteLine($"-Singleton instance is created.Number of instances:{TotalInstances}");
        Console.WriteLine("-Exit from static constructor.");
    }
    public static Singleton GetInstance
    {
        get
        {
            return Instance;
        }
    }

    public static int MyInt = 25;
}

// Second way
public sealed class Singleton2
{

    private static Singleton2 Instance;
    private static int TotalInstances;

    // توی سی شارپ اگه ما کانستراکتور تعریف نکنیم کامپایلر به صورت پیش فرض یک کانستراکتور پابلیک پیش فرض ایجاد میکند.
    // پس برای محافظت از کلاس باید یک کانستراکتور خصوصی تعریف کنیم که کسی از بیرون نتواند آن را ایجاد (new) کند
    private Singleton2()
    {
        Console.WriteLine("--Private constructor is called.");
        Console.WriteLine("--Exit now from private constructor.");
    }

    public static Singleton2 GetInstance()
    {
        if (Instance == null)
        {
            // روش دوم : static initiialization
            Instance = new Singleton2();
        }
        return Instance;
    }

    public static int MyInt = 25;
}

// Third way
// در روش دوم ممکن است همزمانی رخ دهد برای حل این مشکل روش زیر را پیاده سازی میکنیم
public sealed class Singleton3
{

    private static Singleton3 Instance;
    private static object lockObject = new object();
    private static int TotalInstances;

    private Singleton3()
    {
    }

    public static Singleton3 GetInstance()
    {
        // first check
        if (Instance == null)
        {
            lock (lockObject)
            {
                // second(double) check
                if (Instance == null)
                {
                    Instance = new Singleton3();
                }
            }
        }
        return Instance;
    }

    public static int MyInt = 25;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Singleton Pattern Demonstration.***\n");
        /* The following line is used to discuss
        the drawback of the approach. */
        //Console.WriteLine($"The value of MyInt is :{Singleton.MyInt}");
        // Private Constructor.So, you cannot use the 'new' keyword.
        //Singleton s = new Singleton(); // error

        Console.WriteLine("Trying to get a Singleton instance, called firstInstance.");
        Singleton firstInstance = Singleton.GetInstance;
        Console.WriteLine("Trying to get another Singleton instance,called secondInstance.");
        Singleton secondInstance = Singleton.GetInstance;
        if (firstInstance.Equals(secondInstance))
        {
            Console.WriteLine("The firstInstance and secondInstance are the same.");
        }
        else
        {
            Console.WriteLine("Different instances exist.");
        }

        Console.WriteLine("Trying to get a Singleton instance, called firstInstance2.");
        Singleton2 firstInstance2 = Singleton2.GetInstance();
        Console.WriteLine("Trying to get another Singleton instance,called secondInstance2.");
        Singleton2 secondInstance2 = Singleton2.GetInstance();
        if (firstInstance2.Equals(secondInstance2))
        {
            Console.WriteLine("The firstInstance2 and secondInstance2 are the same.");
        }
        else
        {
            Console.WriteLine("Different instances exist.");
        }
        Console.Read();
    }
}

