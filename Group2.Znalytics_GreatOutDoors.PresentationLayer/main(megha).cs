using Znalytics.Group2.GreatOutDoor.Entity;

public class program
{
    static void Main()
    {
        StartMenu a; 

        System.Console.WriteLine("Select The below options for your product");
        System.Console.WriteLine("enter 1 for  personal accessories ");
        System.Console.WriteLine("enter 2 for golf equipment");
        System.Console.WriteLine("enter 3 for camping equipment");
        System.Console.WriteLine("enter 4 for mountaineering equipment ");
        System.Console.WriteLine("enter 5 for outdoor protection");
        System.Console.WriteLine("Enter your product option ");
        int choice = System.Convert.ToInt32(System.Console.ReadLine());
        switch (choice)
        {
            case 0:
                System.Console.WriteLine("personal accessories");
                switch (choice)
                {
                    case 0: System.Console.WriteLine("bangle");
                        break;
                    case 1: System.Console.WriteLine("hand bags");
                        break;
                    case 2:System.Console.WriteLine("makeup");
                        break;
                }
                break;
            case 1:
                System.Console.WriteLine("golf equipment");
                switch (choice)
                {
                    case 0:
                        System.Console.WriteLine("pitching wedge");
                        break;
                    case 1:
                        System.Console.WriteLine("sand wedge");
                        break;
                    case 2:
                        System.Console.WriteLine("gap wedge");
                        break;
                }
                break;
            case 2:
                System.Console.WriteLine("camping equipment");
                switch (choice)
                {
                    case 0:
                        System.Console.WriteLine("tarptant");
                        break;
                    case 1:
                        System.Console.WriteLine("tent");
                        break;
                    case 2:
                        System.Console.WriteLine("trangia");
                        break;
                }
                break;
            case 3:
                System.Console.WriteLine("mountaineering equipment");
                switch (choice)
                {
                    case 0:
                        System.Console.WriteLine("Climbing");
                        break;
                    case 1:
                        System.Console.WriteLine("gas stove");
                        break;
                    case 2:
                        System.Console.WriteLine("climbing rope");
                        break;
                }
                break;
            case 4:
                System.Console.WriteLine("outdoor protection");
                switch (choice)
                {
                    case 0:
                        System.Console.WriteLine("outdoor");
                        break;
                    case 1:
                        System.Console.WriteLine("hand bags");
                        break;
                    case 2:
                        System.Console.WriteLine("makeup");
                        break;
                }
                break;
           
        }
        System.Console.WriteLine("Enter your Id");
        m.SetId(System.Console.ReadLine());
        System.Console.WriteLine("your id:" + m.GetId());
        System.Console.WriteLine("Enter your FirstName");
        m.SetId(System.Console.ReadLine());
        System.Console.WriteLine("your FirstName:" + m.GetId());
        System.Console.WriteLine("Enter your LastName");
        m.SetId(System.Console.ReadLine());
        System.Console.WriteLine("your LastName:" + m.GetId());
        System.Console.WriteLine("Enter your Number");
        m.SetNumber(System.Convert.ToInt64(System.Console.ReadLine()));
        System.Console.WriteLine("your Number:" + m.GetId());
    }
}






// ANOTHER CLASS FOR CATEGORIES//

public class Categories
{
    private string _personalAccessories;
    private string _golfEquipment;
    private string _campingEquipment;
    private string _mountaineeringEquipment;
    private string _outdoorProtection;

    public void SetPersonalAccessories(string PersonalAccessories)
    {
        this._personalAccessories = _personalAccessories;
    }
    public string GetPersonalAccessories()
    {
        return this._personalAccessories;
    }


    public void SetGolfEquipment(string GolfEquipment)
    {
        this._golfEquipment = _golfEquipment;
    }
    public string GetGolfEquipment()
    {
        return this._golfEquipment;
    }


    public void SetcampingEquipment(string campingEquipment)
    {
        this._campingEquipment = _campingEquipment;
    }
    public string GetCampingEquipment()
    {
        return this._golfEquipment;
    }



    public void SetMountaineeringEquipment(string MountaineeringEquipment)
    {
        this._mountaineeringEquipment = _mountaineeringEquipment;
    }
    public string GetMountaineeringEquipment()
    {
        return this._mountaineeringEquipment;
    }




    public void SetOutdoorProtection(string OutdoorProtection)
    {
        this._mountaineeringEquipment = _mountaineeringEquipment;
    }
    public string Get_outdoorProtection()
    {
        return this._outdoorProtection;
    }
}

