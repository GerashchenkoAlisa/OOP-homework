namespace Transport1;
class Program
{
    static void Main(string[] args)
    {
        Transport car = new Car();
        Transport boat = new Boat();
        Transport airplane = new Airplane();

        car.Move();
        boat.Move();
        airplane.Move();

        Console.ReadLine();
    }
}

