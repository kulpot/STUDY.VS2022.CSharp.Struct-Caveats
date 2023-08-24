using System;

//ref link:https://www.youtube.com/watch?v=zshqT8atdXI&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=9
// stack - low room vs heap - high room storage
// semantics of change between ref/class vs struct/value types
// struct/value types = stack   vs  ref/class types = heap

// Struct/Value type Caveats

//class Cow : object { }
struct Cow
//class Cow
{
    int numSteaks;
    float ouncesOfMilk;
    float ouncesOfMilk2;
    float ouncesOfMilk3;
    float ouncesOfMilk4;
    float ouncesOfMilk5;
    //public Cow()  // error struct parameterize
    public Cow(int numSteaks)
    {
        //numSteaks = 5;
        this.numSteaks = numSteaks;
        //ouncesOfMilk = 3.4f;
        this = new Cow(23124124); // for adding a default value 0 to this instance object   // error for ref/class type
    }
}

//class MyWeirdCow : Cow { }  // error: cant inherit cow(struct/value) because its sealed

class MainClass
{
    static void Main()
    {
        int i = 5;
        Console.WriteLine(i.GetType());
        Console.WriteLine(i.GetType().BaseType);
        Console.WriteLine(i.GetType().BaseType.BaseType);
        Console.WriteLine(i.GetType().BaseType.BaseType.BaseType);
        //Console.WriteLine(i.GetType().BaseType.BaseType.BaseType.BaseType);

        //////

        string str = 5.ToString(); ;
        Console.WriteLine(str);

        /////

        //Cow c = new Cow();
        //Console.WriteLine(c.GetType().BaseType);
        //Console.WriteLine(c.GetType().BaseType.BaseType);

        /////

        Cow c = new Cow(10);

    }
}