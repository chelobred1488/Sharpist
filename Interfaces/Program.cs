namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        // Application of Interfaces
        
        // Person person = new Person();
        // Car car = new Car();
        // DoAction(person);
        // DoAction(car);
        // void DoAction(IMovable movable) => movable.Move();
        
        
        // Default Interface implementation

        // IMovable tom = new Person();
        // Car tesla = new Car();
        // tom.Move();
        // tesla.Move();
        // Person bob = new Person();
        // bob.Move();      // Error!
        
        
        // Multiple Interface Implementation

        Message hello = new Message("Hello World!");
        hello.Print();
        
        IMessage sayHello = new Message("Hello METANIT.COM!");
        Console.WriteLine(sayHello.Text);

        // Не все объекты IMessage являются объектами Message, необходимо явное приведение
        // Message someMessage = sayHello;     // Error!

        // Интерфейс IMessage не имеет свойства Print, необходимо явное приведение
        // sayHello.Print();   // Error!
        
        // если hello представляет класс Message, выполняем преобразование
        if (sayHello is Message someMessage) someMessage.Print();
    }
}