// See https://aka.ms/new-console-template for more information
using AnimalAbstraction.Models.Classes;
using AnimalAbstraction.Models.SuperClasses;

Console.WriteLine("Hello, World!");




Tree p = new Tree("Palme", 2);

p.writeCharacteristics();



Fish gubbi = new Fish(1,10);
Console.WriteLine(gubbi.GenderDescription);
Console.WriteLine(gubbi.Age);


Spider s = new Spider(1,10);
Console.WriteLine("Does it spindle?: " + s.IsSpindler);
Console.WriteLine("Age: " + s.Age);
Console.WriteLine("Gender: " + s.GenderDescription);
