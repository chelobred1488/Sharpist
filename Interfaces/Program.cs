using System.Collections;
using System.Text.RegularExpressions;

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
        
        
        // Explicit interface implementation
        // BaseAction baseAction1 = new BaseAction();

        // baseAction1.Move();  // Error! there is not method Move() in BaseAction
        
        // Unsafe
        // ((IAction)baseAction1).Move();
        
        // Safe
        // if(baseAction1 is IAction action) action.Move();
        
        // else like this...
        // IAction baseAction2 = new BaseAction();
        // baseAction2.Move();
        //
        // Console.WriteLine("---------------");
        
        // Person person = new Person();
        // ((ISchool)person).Study();
        // ((IUniversity)person).Study();

        // Console.WriteLine();
        
        // #1
        // HeroAction action1 = new HeroAction();
        // action1.Move();
        // ((IAction)action1).Move();

        // Console.WriteLine();
        
        // Person tom = new Person("Tom");
        // подписываемся на событие
        // tom.MoveEvent += () => Console.WriteLine($"{tom.Name} is moving");
        // tom.Move();

        // Console.WriteLine();
        
        // Unbroken Society
        // Person bob = new Person("Bob");
        // bob.MoveEvent += () => Console.WriteLine($"{bob.Name} is moving");
        // bob.Move();

        Console.WriteLine();
        
        Person maxim = new Driver();
        maxim.Move();

        IAction action1 = new HeroClass();
        action1.Move();
        HeroClass action2 = new HeroClass();
        action2.Move();

        Console.WriteLine();
        
        BaseAction action3 = new HeroAction();
        action3.Move();
        IAction action4 = new HeroAction();
        action4.Move();
        HeroAction action5 = new HeroAction();
        action5.Move();

        Console.WriteLine();

        var telegram = new Messenger<IPrintableMessage>();
        var message = new PrintableMessage("Hello World!");
        telegram.Send(message);

        Console.WriteLine();

        IUser<int> user1 = new User<int>(1488);
        Console.WriteLine(user1.Id);
        IUser<string> user2 = new User<string>("st31679");
        Console.WriteLine(user2.Id);
        
        IUser<int> user3 = new User<int>(0771);
        Console.WriteLine(user3.Id);
        IntUser user4 = new IntUser(9);
        Console.WriteLine(user4.Id);

        Console.WriteLine();
        // <--- ICloneable --->
        var tom = new NewPerson("Tom", 19, new Company("Microsoft"));
        var bob = (NewPerson)tom.Clone();
        bob.Work.Name = "Google";
        Console.WriteLine(tom.Work.Name);

        Console.WriteLine();
        // <--- IComparable --->

        var vali = new OldPerson("Vali", 69);
        var ali = new OldPerson("Ali", 78);
        var akram = new OldPerson("Akram", 90);
        
        OldPerson[] people = { ali, vali, akram };
        Array.Sort(people);

        foreach (OldPerson person in people)
            Console.WriteLine($"{person.Name} - {person.Age}");
        Console.WriteLine();

        var alice = new Human("Alice", 68);
        var sam = new Human("Sam", 102);
        var max = new Human("Maxim", 97);
        
        Human[] people2 = { alice, sam, max };
        Array.Sort(people2, new PeopleComparer());
        foreach(Human human in people2)
            Console.WriteLine($"{human.Name} - {human.Age}");
        Console.WriteLine();
        // Co-variation and Contravariant

        IMessenger<Messages> outlook = new EmailMessenger();
        Messages mess = outlook.WriteMessage("Hello World!");
        Console.WriteLine(mess.Text);
        
        IMessenger<EmailMessage> emailClient = new EmailMessenger();
        IMessenger<Messages> messenger = emailClient;
        Messages emailMessage = messenger.WriteMessage("Hi!");
        Console.WriteLine(emailMessage.Text);

    }
}