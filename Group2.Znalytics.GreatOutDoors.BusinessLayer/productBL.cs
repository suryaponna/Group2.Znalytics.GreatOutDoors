

public class UserLogin
{

    private string _id;
    private string _password;
    private string _firstName;
    private string _lastName;
    private long _phonenumber;

    public void SetId(string value)
    {
        if (value.Length <= 10)
        {
            _id = value;
        }
    }
    public string GetId()
    {
        return _id;
    }

    
    public void SetFirstName(string value)
    {
        if (value.Length <= 20)
        {
            _firstName = value;
        }
    }
    public string GetFirstName()
    {
        return _firstName;
    }

    public void SetLastName(string value)
    {
        if (value.Length <= 20)
        {
            _lastName = value;
        }
    }
    public string GetLastName()
    {
        return _lastName;
    }

    public void SetPhoneNumber(long value)
    {
        if (value >= 0 && value <= 9)
        {
            _phonenumber = value;
        }

    }
    public long GetNumber()
    {
        return _phonenumber;

    }

}
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



