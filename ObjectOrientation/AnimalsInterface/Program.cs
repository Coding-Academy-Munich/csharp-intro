using AnimalsInterface;

Cat garfield = new Cat("Garfield");

Console.WriteLine($"The cat is called {garfield.Name}.");
garfield.Meow();
garfield.Pet();

Dog fluffy = new Dog("Fluffy");
Console.WriteLine($"The dog is called {fluffy.Name}.");
fluffy.Pet();

IAnimal myPet = garfield;

Console.WriteLine($"The name of my pet is {myPet.Name}.");
myPet.Pet();

//Console.WriteLine("\nPettable");
//IPettable myPettable = fluffy;
//myPettable.Pet();
//myPettable = garfield;
//myPettable.Pet();
//Console.WriteLine($"The name of my pettable pet is {((INamed)myPettable).Name}.");

myPet = fluffy;

Console.WriteLine($"The name of my pet is {myPet.Name}.");
myPet.Pet();