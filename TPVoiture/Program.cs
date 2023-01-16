using System.IO;
using TPVoiture;

#region First car
//Creat first car
Car Car1 = new Car("AV48CE", "TT", "Audi", 15000, 211);
#endregion
#region Second car
//Creat second car
Car Car2 = new Car("FH55EE", "X5", "BMW", 85000, 235);
#endregion
#region Third car
Car Car3 = new Car("FH55EE", "X5", "BMW", 85000, 235);
#endregion
//#region First Person
////Creat Person
//Person Person1 = new Person("Doe", "John", 54);
//#endregion
//#region Second person
//Person Person2 = new Person("Toto", "Tata", 32);
//#endregion
//#region Third Person
//Person Person3 = new Person("Titi", "Tutu", 45);
//#endregion
//#region Person1's car
////Add car to Person1
//Person1.AddCar(Car1);
//Person1.AddCar(Car2);
////Person1.RemoveCar(Car1);
//#endregion
//#region Car's Owner
//Car1.AddOwner(Person1);
//Car2.AddOwner(Person1);
////Remove car from Person1
////Car1.RemoveOwner();
//#endregion
#region Method
////Display of Car1
//Car1.Print();
////Display of Car2
//Car2.Print();
////Display of Car3
//Car3.Print();   
////Display of the person1
//Person1.Print();
////Display of the person2
//Person2.Print();
////Display of the person3
//Person3.Print();
//Console.WriteLine($"Il y a eu {Person.GetInstance()} personne créées");
//Console.WriteLine();
//Console.WriteLine(Person.AverageAges());
Customer Customer1 = new Customer("Test", "Test2", 25);
Mechanic Mechanic1 = new Mechanic("Test3", "Test4", 48);
Company Company1 = new Company(5444, "Mon Entreprise");
Garage Garage1 = new Garage(6400, "Mon Garage");
Customer1.AddCar(Car1);
Customer1.Print();
Console.WriteLine();
Console.WriteLine();
Company1.PrintCompany();
Console.WriteLine();
Console.WriteLine();
Garage1.AddCar(Car1);
Garage1.Print();
Console.WriteLine();
Console.WriteLine();
Garage1.AssignMechanic(Mechanic1, Car1);
Mechanic1.Print();
Console.WriteLine();
Console.WriteLine();
Customer1.WithdrawCar(Garage1, Car1);
Customer1.Print();
Console.WriteLine(); 
Console.WriteLine();
Garage1.Print();



#endregion