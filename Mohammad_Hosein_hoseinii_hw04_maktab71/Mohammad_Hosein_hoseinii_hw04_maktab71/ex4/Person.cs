public class Person
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public float PrsonalCode { get; set; }
    public string Hight { get; set; }

    public float Phone { get; set; }

    public string FatherName { get; set; }

    public float Weight { get; set; }

    public float DateBeartheDay { get; set; }

    public string YourDirection { get; set; }

    public Person(string firstname, string lastname, float prsonalcode, string hight, float phone, string fathername, float weight, float datebeartheday, string yourdirection)
    {
        FirstName = firstname;
        LastName = lastname;
        PrsonalCode = prsonalcode;
        Hight = hight;
        Phone = phone;
        FatherName = fathername;
        Weight = weight;
        DateBeartheDay = datebeartheday;
        YourDirection = yourdirection;
    }
}

