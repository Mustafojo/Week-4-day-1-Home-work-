public  class Car : IVehicle
{
    public void Drive()
    {
         System.Console.WriteLine("Driving");
    }

    public bool Refuel(int refuel)
    {
        refuel ++;
        return true;
    }
    
}
