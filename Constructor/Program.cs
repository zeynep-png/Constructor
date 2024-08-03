
using Constructor;

Baby baby1 = new Baby(); //Create a new baby object using the default constuctor
baby1.FirstName ="Ian";
baby1.LastName ="Fox";
Console.WriteLine($"---BABY NUMBER 1---\nNAME: {baby1.FirstName}\nLAST NAME: {baby1.LastName}\nBIRTH TIME: {baby1.BirthTime}");


//Crate a new baby obhect using parameterized constructor
Baby baby2 = new Baby("Jane","Bieber");
Console.WriteLine($"---BABY NUMBER 2---\nNAME: {baby2.FirstName}\nLAST NAME: {baby2.LastName}\nBIRTH TIME: {baby2.BirthTime}");
