using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MyBaseClass
{
    protected int protectedField = 99;

    protected void ProtectedMethod()
    {
        Console.WriteLine("This is a protected method.");
    }
}

class MyDerivedClass : MyBaseClass
{
    public void AccessProtectedMembers()
    {
        Console.WriteLine("Accessing protected field from the derived class: " + protectedField);
        ProtectedMethod();
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyDerivedClass derivedObject = new MyDerivedClass();

        derivedObject.AccessProtectedMembers();
    }
}
