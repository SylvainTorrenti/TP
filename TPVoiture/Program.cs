using TPVoiture;

Car Car1 = new Car();
Car1.Registration = "Audi TT";
Car1.Model = "AV48CE";
Car1.OriginalInServiceDate = new DateTime(2012, 02, 21);
Car1.Power = 211;

Car Car2 = new Car();
Car2.Registration = " BMW X5";
Car2.Model = "FH55EE";
Car2.OriginalInServiceDate = new DateTime(2009, 11, 10);
Car2.Power = 235;


Person Person1 = new Person();
Person1.Name = "Doe";
Person1.FirstName = "John";
Person1.Cars.Add(Car1);
Person1.Cars.Add(Car2);