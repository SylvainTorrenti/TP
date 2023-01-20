using TPObjet;
using TPVoiture;

Client client1 = new Client("Doe", "John", 30);
Vehicle audiTT = new Car("AV48CE", "TT", "Audi", 80000,
    new DateTime(2012, 2, 21), 211, client1, true,5);
Car x5 = new Car("FH55EE", "X5", "BMW", 80000,
    new DateTime(2009, 11, 10), 235, client1, true,3);
client1.AcquisitionDunVehicule(x5);
client1.AcquisitionDunVehicule(audiTT);
Vehicle iveco = new Truck("DV48CE", "Eurocargo", "Iveco", 80000,
    new DateTime(2012, 2, 21), 211, client1, true, 1);

Client client2 = new Client("Doe", "John", 30);
Car chevrolet = new Car("AV48CE", "Camaro", "Chevrolet", 80000,
    new DateTime(2009, 2, 21), 211, client1, false,0);
Car peugeot = new Car("FH55EE", "208", "Peugeot", 80000,
    new DateTime(2006, 11, 10), 235, client1, true,5);
client2.AcquisitionDunVehicule(chevrolet);
client2.AcquisitionDunVehicule(peugeot);

Garage garage1 = new Garage("8888775244896");
Garagiste paul = new Garagiste("Dumoulin", "Paul", 42, 1);
Garagiste didier = new Garagiste("Dubois", "Didier", 38, 3);

garage1.EngagerUnGaragiste(paul);
garage1.EngagerUnGaragiste(didier);

garage1.RecupererUnVehiculeAReparer(audiTT);
garage1.AssignerUnVehiculeUnGaragiste(audiTT, didier);
//didier.ReparationsFinis(audiTT);
//garage1.RecuperationDeLaVoitureParLeClient(audiTT, client1);
audiTT.AfficherLaPersonneEnCharge();
audiTT.ReparationTime(paul);
iveco.ReparationTime(didier);
