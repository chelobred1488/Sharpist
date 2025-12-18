using System.Net.Http.Headers;

namespace Delegates;

class Program
{
    enum OperationType
    {
        Add,
        Subtract,
        Multiply
    }
    delegate void Message();
    delegate int Operation(int x, int y);
    // delegate void DomeDel(int a, double b);
    // delegate T Operation<T, K>(K val);
    public Program()
    {
    }

    static void Main(string[] args)
    {
        // Message mes;
        // mes = Hello;
        // mes();
        // void Hello() => Console.WriteLine("Hello METANIT.COM!");

        // Message message1 = Welcome.Print;
        // Message message2 = new Hello().Display;
        //
        // message1();
        // message2();

        // Operation operation = Add;
        // int result = operation(10, 20);
        // Console.WriteLine(result);
        //
        // operation = Multiply;
        // result = operation(10, 20);
        // Console.WriteLine(result);
        //
        int Add(int x, int y) => x + y;
        int Subtract(int x, int y) => x - y;
        int Multiply(int x, int y) => x * y;

        // Operation operation = Add;
        // Operation operation2 = new Operation(Add); Another option
        
        // void SomeMethod1(int g, double n) { } Only 'll accept this method!

        // double SomeMethod2(int g, double n) => g + n;
        // void SomeMethod3(int n, double g) { }
        // void SomeMethod4(ref int g, double n) { }
        // void SomeMethod5(out int g, double n) { g = 6; } Don't accept cause' of parameters

        
        // Message? message = Hello;
        // message += HowAreYou;
        // message();
        // message -= HowAreYou;
        // if (message != null) message();
        
        
        // Message mes1 = Hello;
        // Message mes2 = HowAreYou;
        // Message mes3 = mes1 + mes2;  IMPORTATNT PART!!!
        // mes3();
        
        
        // Message mes = Hello;
        // mes();  Calling like Methods
        //
        // Operation op = Add;
        // int n = op(10, 20);  Also...
        // Console.WriteLine(n);

        
        // Message mes = Hello;
        // mes.Invoke();  Using Method 'Invoke()' to call a delegate instead of '()'
        //
        // Operation op = Add;
        // int n = op.Invoke(1, 2);
        // Console.WriteLine(n);

        
        // Message? mes = null;
        // mes?.Invoke();
        //
        // Operation? op = Add;
        // op -= Add;
        // int? n = op.Invoke(1, 2);  If delegate don't have an  instance, than won't return anything

        // Operation op = Subtract;
        // op += Multiply;
        // op += Add;
        // Console.WriteLine(op.Invoke(1, 2));  Return only the last reference!

        
        // Operation<decimal, int> squareOperation = Square;
        // decimal result1 = squareOperation(5);
        // Console.WriteLine(result1);
        //
        // Operation<int, int> doubleOperation = Double;
        // int result2 = doubleOperation(5);
        // Console.WriteLine(result2);
        //
        // decimal Square(int x) => x * x;
        // int Double(int x) => x + x;      IMPORTANT PART WITH GENERICS!!!

        
        // DoOperation(5, 4, Add);
        // DoOperation(5, 4, Subtract);
        // DoOperation(5, 4, Multiply);
        //
        // void DoOperation(int a, int b, Operation op)
        // {
        //     Console.WriteLine(op(a,b));
        // }        Using delegate as parameter of Method!
        
        
        Operation operation = SelectOperation(OperationType.Add);
        Console.WriteLine(operation(10, 20));
        
        operation = SelectOperation(OperationType.Subtract);
        Console.WriteLine(operation(10, 20));
        
        operation = SelectOperation(OperationType.Multiply);
        Console.WriteLine(operation(10, 20));

        Operation SelectOperation(OperationType opType)
        {
            switch (opType)
            {
                case OperationType.Add: return Add;
                case OperationType.Subtract: return Subtract;
                default: return Multiply;
            }
        }
        
        void Hello() => Console.WriteLine("Hello, Metanit.com");
        void HowAreYou() => Console.WriteLine("How are you?");
        void HowOldAreYou() => Console.WriteLine("How old are you?");

    }
}

class Welcome
{
    public static void Print() => Console.WriteLine("Welcome");
}

class Hello
{
    public void Display() => Console.WriteLine("Hello");
}