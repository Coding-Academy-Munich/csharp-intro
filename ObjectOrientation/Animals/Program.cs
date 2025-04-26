using Animals;

Cat garfield = new Cat();

garfield.Pet();
// garfield.Meow();

Dog odie = new Dog("Odie");

odie.Pet();
// odie.Bark();

Animal myPet = new Dog("Fluffy");
myPet = garfield;
// myPet = new Animal("My Animal");

myPet.Pet();
// myPet.Bark();
myPet.MakeNoise();

//bool isCat = myPet is Cat;
//if (isCat)
//{
//    Cat myCat = (Cat)myPet;
//    myCat.Meow();
//}

//bool isDog = myPet is Dog;
//if (isDog)
//{
//    ((Dog)myPet).Bark();
//}