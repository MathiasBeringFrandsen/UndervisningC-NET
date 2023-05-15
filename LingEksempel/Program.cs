using LingEksempel;

Person lasse = new Person(1, "Lasse", 23, "12345678");
Person morten = new Person(2, "Morten", 23, "11345678");
Person alin = new Person(3, "Alin", 22, "22345678");
Person kristina = new Person(4, "Kristina", 27, "11335678");

List<Person> list = new List<Person>();
list.Add(lasse);
list.Add(morten);
list.Add(alin);
list.Add(kristina);

Console.WriteLine(list.Where(i => i.Age );