namespace Exercises_2;
public class CarCollection
{
    public string CarInfo { get; set; }
    public string Model { get; set; }
    public int AgeCar { get; set; }
    public string Color { get; set; }
}

public class InfoCar
{
    public string Model { get; set; }
    public string NameVlad { get; set; }
    public int PhoneNumber { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        var carCollection = new List<CarCollection>
        {
                new CarCollection {CarInfo = "Nisan", Model = "V4", AgeCar=2007,Color = "Red"},
                new CarCollection {CarInfo = "Mitsubisu", Model = "Lound",AgeCar=2021,Color = "White"},
                new CarCollection {CarInfo = "Toyota", Model = "Colora",AgeCar=2019,Color = "Blue"},
                new CarCollection {CarInfo = "Porshe", Model = "B3",AgeCar=2008,Color = "Green"}
        };
        var peopleColl = new List<InfoCar>
        {
                new InfoCar { Model = "V4", NameVlad="Alex",PhoneNumber = 192010},
                new InfoCar {Model = "B3",NameVlad=" Vlad",PhoneNumber = 20493}
                
        };

        var query = from info in carCollection
                    join n in peopleColl
                    on info.Model equals n.Model
                    orderby n.NameVlad descending // ascending - по возрастанию | descending - по убыванию.
                    select new
                    {
                        CarInfo = info.CarInfo,
                        Model = info.Model,
                        AgeCar = info.AgeCar,
                        Color = info.Color,
                        NameVlad = n.NameVlad
                    };
        foreach (var person in query)
        {
            Console.WriteLine("{0}, {1}, ,{2} , {3} , {4}", person.CarInfo, person.Model, person.AgeCar, person.Color, person.NameVlad);
        }
        
        // Delay.
        Console.ReadKey();
    }
}

