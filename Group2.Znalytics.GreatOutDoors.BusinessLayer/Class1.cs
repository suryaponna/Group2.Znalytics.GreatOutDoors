public class Master
{
    private string _id;
    private string _password;
    private string _firstName;
    private string _lastName;
    private long _number;

    public void SetId(string Id)
    {
        this._id = Id;
    }
    public string GetId()
    {
        return this._id;
    }
    public void SetPassword(string Password)
    {
        this._password = Password;
    }
    public string GetPassword()
    {
        return this._password;
    }

    public void SetFirstName(string Firstname)
    {
        this._firstName = Firstname;
    }
    public string GetFirstName()
    {
        return this._firstName;
    }


    public void SetLastName(string lastname)
    {
        this._lastName = lastname;
    }
    public string GetLastName()
    {
        return this._lastName;
    }

    public void SetNumber(long number)
    {
        this._number = number;
    }
    public long GetNumber()
    {
        return this._number;
    }
}