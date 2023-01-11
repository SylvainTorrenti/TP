using System.IO;
using TPVoiture;

#region First car
//Created first car
Car Car1 = new Car();
Car1.SetBrand("Audi");
Car1.SetModel("TT");
Car1.SetRegistration("AV48CE");
Car1.SetOriginalInServiceDate(new DateOnly(2012, 2, 21));
Car1.SetPower(211);
Car1.SetKLM(15000);
#endregion
#region Second car
//Created second car
Car Car2 = new Car();
Car2.SetBrand("BMW");
Car2.SetModel("X5");
Car2.SetRegistration("FH55EE");
Car2.SetOriginalInServiceDate(new DateOnly(2009, 11, 10));
Car2.SetPower(235);
Car2.SetKLM(85000);
#endregion
#region First Person
//Created Person
Person Person1 = new Person();
Person1.SetName("Doe");
Person1.SetFirstName("John");
Person1.SetAge(54);
#endregion
#region Person1's car
//Add car to Person1
Person1.AddCar(Car1);
Person1.AddCar(Car2);
//Person1.RemoveCar(Car1);
#endregion
#region Car's Owner
Car1.AddOwner(Person1);
Car2.AddOwner(Person1);
//Remove car from Person1
//Car1.RemoveOwner();
#endregion
#region Method
//Display of the Car1
Car1.Print();
Console.WriteLine();
Console.WriteLine();
//Display of the Car2
Car2.Print();
Console.WriteLine();
Console.WriteLine();
//Display of the person1
Person1.Print();
#endregion
