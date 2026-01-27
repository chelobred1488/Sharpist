namespace Interfaces;

interface IMovable
{
    void Move() => Console.WriteLine("Walking");
    // public const int minSpeed = 0;
    // private static int maxSpeed = 60;
    // static double GetTime(double distance, double speed) => distance / speed;
    //
    // static int MaxSpeed
    // {
    //     get
    //     {
    //         return maxSpeed;
    //     }
    //     set
    //     {
    //         if (value > 0) maxSpeed = value;
    //     }
    // }
}

class Person : IMovable { }
struct Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Driving");
    }
}


// public abstract interface IAction    // We cannot use modificator abstract for interfaces!
// {
//     void Move();
// }
// internal interface IRunAction : IAction
// {
//     void Run();
// }


// class RunAction : IRunAction
// {
//     internal void Move()     // Don't use any access mod beside public!
//     {
//         Console.WriteLine("I am running!");
//     }
// }
// interface IAction
// {
//     void Move();
// }
// interface IRunAction : IAction
// {
//     new void Move();
// }


// interface IFoo
// {
//     void Execute();
// }
// interface IBar
// {
//     void Execute();
// }
// class Tester : IFoo, IBar
// {
//     void IFoo.Execute()
//     {
//         Console.WriteLine("Tester Executes!");
//     }
//     void IBar.Execute()
//     {
//         Console.WriteLine("Tester Executes!");
//     }
// }

interface IMessage
{
    string Text { get; set; }
}

interface IPrintble
{
    void Print();
}

class Message : IMessage, IPrintble
{
    public string Text { get; set; }
    public Message(string text) => Text = text;
    public void Print() => Console.WriteLine(Text);
}