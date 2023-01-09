using TPVoiture;

#region First car
//Created first car
Car Car1 = new Car();
Car1.Brand = "Audi";
Car1.Model = "TT";
Car1.Registration = "AV48CE";
Car1.OriginalInServiceDate = new DateOnly(2012, 2, 21);
Car1.Power = 211;
Car1.KLM = 15000;
#endregion

#region Second car
//Created second car
Car Car2 = new Car();
Car2.Brand = "BMW";
Car2.Model = "X5";
Car2.Registration = "FH55EE";
Car2.OriginalInServiceDate = new DateOnly(2009, 11, 10);
Car2.Power = 235;
Car2.KLM = 85000;
#endregion

#region First Person
//Created Person
Person Person1 = new Person();
Person1.Name = "Doe";
Person1.FirstName = "John";
Person1.Age = 54;
#endregion

#region Person1's car
//Add car to Person1
Person1.Cars.Add(Car1);
Person1.Cars.Add(Car2);
#endregion

#region Car's Owner

//Add owner to car
Car1.Owner = Person1;
Car2.Owner = Person1;
#endregion

//Display of the Car1
Car1.Print();
Console.WriteLine();
//Display of the Car2
Car2.Print();
Console.WriteLine();
//Display of the person1
Person1.Print();


