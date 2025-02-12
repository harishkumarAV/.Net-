//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
class Bird
{
    public virtual void fly()
    {
        Console.WriteLine("Birds can Fly");
    }
}
class Penguin : Bird
{
    public override void fly()
    {
        Console.WriteLine("Penguins can swim");
    }
}
class Ostrich : Bird
{
    public override void fly()
    {
        Console.WriteLine("Ostriches can't fly");
    }
}
class program
{
    public static void Main(string[] args)
    {
        Bird p = new Ostrich();
        p.fly();

        p = new Penguin();
        p.fly();

        p= new Bird(); 
        p.fly();
    }
}