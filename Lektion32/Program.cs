using Times;
using Lektion3_Værksted;

Time time = new Time(50, 45, 14);

Time time2 = time;

Console.WriteLine(time);
Console.WriteLine(time2);

time.Minute = 0;

Console.WriteLine(time);
Console.WriteLine(time2);

CprNr cpr = new CprNr("120598", "120598-1235");
Adresse adresse = new Adresse("HejVej", "12", "8000");
Mekaniker mekaniker1 = new Mekaniker(cpr, "01", "Jens", adresse, 150, 2015);

Mekaniker mekaniker2 = mekaniker1;

Console.WriteLine(mekaniker1);
Console.WriteLine(mekaniker2);

mekaniker2.Navn = "Morten";

Console.WriteLine(mekaniker1);
Console.WriteLine(mekaniker2);