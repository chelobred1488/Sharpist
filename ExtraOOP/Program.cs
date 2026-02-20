namespace ExtraOOP;

class Program
{
    static void Main(string[] args)
    {
        Counter counter1 = new Counter() { Value = 23 };
        Counter counter2 = new Counter() { Value = 45 };
        
        bool result = counter1 > counter2;
        Console.WriteLine(result);
        
        Counter counter3 = counter1 + counter2;
        Console.WriteLine(counter3.Value);

        int summa = counter1 + 12;
        Console.WriteLine(summa);
        
        Counter counter4 = new Counter() { Value = 10 };
        Counter counter5 = counter4++;
        
        Console.WriteLine(counter4.Value);
        Console.WriteLine(counter5.Value);
        
        Counter counter6 = ++counter4;
        Console.WriteLine(counter4.Value);
        Console.WriteLine(counter6.Value);
        
        Counter counter7 = new Counter() { Value = 0 };
        if (counter7)
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
            
        Counter counter = new Counter() { Value = 2 };
        if (!counter)
            Console.WriteLine(true);
        else
            Console.WriteLine(false);
    }
}
public class Counter
{
    public int Value { get; set; }

    public static Counter operator +(Counter counter1, Counter counter2)
    {
        return new Counter() { Value = counter1.Value + counter2.Value };
    }

    public static bool operator >(Counter counter1, Counter counter2)
    {
        return counter1.Value > counter2.Value;
    }

    public static bool operator <(Counter counter1, Counter counter2)
    {
        return counter1.Value < counter2.Value;
    }

    public static int operator +(Counter counter1, int val)
    {
        return counter1.Value + val;
    }

    public static Counter operator ++(Counter counter1)
    {
        return new Counter() { Value = counter1.Value + 10 };
    }
    public static bool operator !(Counter counter1)
    {
        return counter1.Value == 0;
    }
    
    public static bool operator true(Counter counter1)
    {
        return counter1.Value != 0;
    }

    public static bool operator false(Counter counter1)
    {
        return counter1.Value == 0;
    }
}