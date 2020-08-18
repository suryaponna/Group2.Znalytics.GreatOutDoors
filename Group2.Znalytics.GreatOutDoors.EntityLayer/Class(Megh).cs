using System.Windows.Markup;

public class Master
{
    public string _id;
    public string _password;
    public string _firstName;
    public string _lastName;
    public long _number;

    public string ID
    {
        set
        {
            _id = value;
        }
        get
        {
            return _id;
        }
    }
    public string Password
    {
        set
        {
            _password = value;
        }
        get
        {
            return _password;

        }

    }

    public string FirstName
    {
        set
        {
            _firstName = value;
        }
        get
        {
            return _firstName;
        }
    }


    public string LastName
    {
        set
        {
            _lastName = value;

        }
        get
        {
            return _lastName;
        }
    }


    public long Number
    {
        set
        {
            _number = value;
        }
        get
        {
            return _number;
        }
    }
}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    