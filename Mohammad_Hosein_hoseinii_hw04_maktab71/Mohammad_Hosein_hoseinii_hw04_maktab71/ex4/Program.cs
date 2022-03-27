Console.WriteLine("How Many Person Do You Want To Insert Data : ");
int PersonNumber = Convert.ToInt32(Console.ReadLine());

string path = "C:\\Users\\Mohammad\\Desktop\\ex4\\data.txt";

List<string> name = new List<string>();
//List<float> NatinalCode = new List<float>();

Console.Clear();
for (int i = 0; i < PersonNumber; i++) { 
Console.WriteLine("-------------****** Please Enter Your Personal Data ******-------------");
//نام 
Console.WriteLine("FirstName");

string firstname = Convert.ToString(Console.ReadLine());

File.WriteAllText(path, firstname + "\t");


//نام خانوادگی
Console.WriteLine("LastName");

string lastname = Convert.ToString(Console.ReadLine());

    File.AppendAllText(path, lastname + "\t");

//کد ملی
Console.WriteLine("Prsonalcode");

    string prsonalcode =Convert.ToString(Console.ReadLine()) ;

    File.AppendAllText(path, prsonalcode + "\t");

//قد
Console.WriteLine("Hight");

string hight = Convert.ToString(Console.ReadLine());

   File.AppendAllText(path, hight + "\t");

//شماره همراه
Console.WriteLine("Phone");

    string phone = Convert.ToString(Console.ReadLine());

    File.AppendAllText(path, phone + "\t");

// نام پدر
Console.WriteLine("FatherName");

string fathername = Convert.ToString(Console.ReadLine());

    File.AppendAllText(path, fathername + "\t");

//وزن
Console.WriteLine("Weight");

    string weight = Convert.ToString(Console.ReadLine()); 

    File.AppendAllText(path, weight + "\t");

//تاریخ تولد
Console.WriteLine("DateBeartheDay \t (Such as '1377/11/23') .");

string datebeartheday = Convert.ToString(Console.ReadLine());

    File.AppendAllText(path, datebeartheday + "\t");

//آدرس 
Console.WriteLine("YourDirection");

string yourdirection = Convert.ToString(Console.ReadLine());

    File.AppendAllText(path, yourdirection + "\n");

    name.Add(firstname);
    name.Add(lastname);
    name.Add(prsonalcode);

    Console.Clear();
}

foreach (string item in name)
{
    Console.WriteLine(item);
}
File.ReadAllText(path);

File.WriteAllText(path, "Delet all of the line ..." + "\n");
Console.Read();



