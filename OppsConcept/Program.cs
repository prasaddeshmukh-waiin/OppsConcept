// See https://aka.ms/new-console-template for more information


//A a=new A();

//Console.WriteLine(a.add(10, 20));
//Console.WriteLine(a.division(10, 20));
//Console.WriteLine(a.multiply(10, 20));
//class A
//{
//    public int add(int a, int b)
//    {
//        return a + b;
//    }
//    public int multiply(int a, int b)
//    {
//        return a * b;
//    }
//    public int division(int a, int b)
//    {
//        return a/b;
//    }
//}
//----------------------------------------------------

//A a = new A(3,2);
//Console.WriteLine(a.add());
//Console.WriteLine(a.div());
//Console.WriteLine(a.mul());
//class A
//{
//    public int a;
//    public int b;

//    public A(int aa,int bb)
//    {
//       a = aa;
//        b = bb;

//    }
//    public int add()
//    {
//        return a + b;
//    }
//    public int mul()
//    {
//        return a * b;
//    }
//    public int div()
//    {
//        return a / b;
//    }
//}
//-----------------------------------------------------------

//Student student = new Student("abc",1, "ngr",90987654,"nacs");
//string s=Student.ClgN;
//student.Display();
//student.Update(1111111111,"shubham"); //change name and phone  function required
//student.Phone = 88888888; // change only phone no
//student.Display();

//class Student
//{
//    public static string ClgN="zzzzzz";  //static variable access only class name commonly use
//    public string Name;
//    public int Id;
//    public string Address;
//    public long Phone;
//    public string Clg;

//    public Student(string Name, int Id, string Address, long Phone,string Clg)
//    {
//        this.Name = Name;
//        this.Id = Id;
//        this.Address = Address;
//        this.Phone = Phone;
//        this.Clg = Clg;

//    }

//    public void Display()
//    {
//        Console.WriteLine($"{Name}, {Id} ,{ Address},{Phone},{Student.ClgN}");
//    }

//    public void Update(int Phone ,string Name)
//    {
//        this.Phone=Phone;
//        this.Name=Name;
//    }
//}
//-----------------------------------------------------------------------------------


Oraganation org = new Oraganation("prasad", "ngr", 1, 9011410653);
org.Display();
org.Update("shubham", "pune");
org.Display();


class Oraganation
{
    private string Name;
    private string Address;
    private int Id;
    private long Phone;

    public Oraganation(string Name,string Address,int Id,long Phone)
    {
        this.Name = Name;
        this.Address = Address;
        this.Id = Id;
        this.Phone = Phone;
    }

    public void Display()
    {
        Console.WriteLine($"{Name} , {Address} , {Id} ,{Phone}");
    }

    public void Update(string Name, string Address)
    {
        this.Name = Name;
        this.Address = Address;
    }
    
   
}