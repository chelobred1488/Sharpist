using System.Collections;
using System.Runtime.CompilerServices;

namespace ExceptionRS;

class Program
{
    static void Main(string[] args)
    {
        // try
        // {
        //     int x = 5;
        //     int y = x / 0;
        //     Console.WriteLine($"Result: {y}");
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine($"Exception: {ex.Message}");
        //     Console.WriteLine($"Method: {ex.TargetSite}");
        //     Console.WriteLine($"Stack Trace: {ex.StackTrace}");
        // }

        // try
        // {
        //     int[] numbers = new int[4];
        //     numbers[7] = 9; //IndexOutOfRangeException
        //
        //     int x = 5;
        //     int y = x / 0; // DivideByZeroException
        //     Console.WriteLine($"Результат: {y}");
        // }
        // catch (DivideByZeroException)
        // {
        //     Console.WriteLine("Возникла исключения DivideByZeroException");
        // }
        // catch (IndexOutOfRangeException ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }

        /*try
        {
            object obj = "you";
            int num = (int)obj;
            Console.WriteLine($"Result: {num}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Возникло исключения DivideByZeroException");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Возникло исключения IndexOutOfRangeException");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Исключения: {ex.Message}");
        }*/

        /*try
        {
            try
            {
                Console.Write("Enter your name: ");
                string? name = Console.ReadLine();
                if (name == null || name.Length < 2)
                {
                    throw new Exception("The length of the name is less than 2!");
                }
                else
                {
                    Console.WriteLine($"Hello, {name}!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }*/

        // try
        // {
        //     Person person = new Person() {Name = "John Doe", Age = 17};
        // }
        // catch (PersonException ex)
        // {
        //     Console.WriteLine($"Error: {ex.Message}");
        //     Console.WriteLine($"Some error occured: {ex.Value}");
        // }

        try
        {
            TestClass.Method1();
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Catch in method Main: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Block Finally in method Main");
        }
        
    }
}

class Person
{
    private int age;
    public string Name { get; set; } = "";

    public int Age
    {
        get => age;
        set
        {
            if (value < 18)
            {
                throw new PersonException("Лицам до 18 регистрация запрещена", value);
            }
            else
            {
                age = value;
            }
        }
    }
}

class PersonException : ArgumentException
{
    public int Value { get; }
    public PersonException(string message, int val) : base(message) => Value = val;
}

// Поиск блока catch при обработке исключений
class TestClass
{
    public static void Method1()
    {
        try
        {
            Method2();
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Catch in Method1: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Block Finally in Method1");
        }
        Console.WriteLine("End of Method1");
    }

    public static void Method2()
    {
        try
        {
            int x = 8;
            int y = x / 0;
            Console.WriteLine($"Reesult: {y}");
        }
        finally
        {
            Console.WriteLine("Block Finally in Method2");
        }
        Console.WriteLine("End of Method2");
    }
}
