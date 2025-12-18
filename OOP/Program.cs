Transport bmw = new Car("BMW", 300, 3);
bmw.Move();
bmw.Move();
bmw.Move();
bmw.Move();
Car car = (Car)bmw;
car.Refuel(2);
bmw.Move();
bmw.Move();
bmw.Move();

abstract class Transport
{
    public string Model { get; set; }
    public int Speed { get; set; }

    abstract public void Move();
}

class Car : Transport
{
    private int fuel;

    public Car(string model, int speed, int fuel)
    {
        Model = model;
        Speed = speed;
        this.fuel = fuel;
    }

    public void Refuel(int amount)
    {
        fuel += amount;
    }
    
    public override void Move()
    {
        if (fuel > 0)
        {
            Console.WriteLine($"The car {Model} is moving with {Speed} km/h");
            fuel--;
        }
        else
        {
            Console.WriteLine($"The car {Model} is currently in fuel less than 0!");
        }
    }
}