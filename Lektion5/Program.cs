using Lektion5;

static void Exercise1(ref List<Person> list)
{
    try
    {
        list = Person.ReadCSVFile(@"C:\Users\Frand\Downloads\data1.csv");

    }
    catch (Exception ex)
    {
        Console.WriteLine("EXCEPTION: " + ex.Message);
        Console.WriteLine("You should probably set the filename to the Person.ReadCSVFile method to something on your disk!");
    }
}

//List<int> ints = new List<int> { 1, 20, 3, 4, 50, 6, 7, 8, 9 };

//List<int> result = ints.FindAll(i => i % 2 == 0);
//result.ForEach(i => Console.WriteLine(i));

//int lastOverFifteen = ints.FindLast(i => i > 15);
//Console.WriteLine(lastOverFifteen);

//int index = ints.FindLastIndex(i => i > 15);
//Console.WriteLine(index);

//var result = ints.Where(i => i % 2 == 0);
//foreach (var i in result)
//{
//    Console.WriteLine(i);
//}

//var result2 = ints.Where(i => i % 2 == 0 && i.ToString().Length == 2);
//foreach (var i in result2)
//{
//    Console.WriteLine(i);
//}

//List<Person> people1 = new List<Person>();
//Exercise1(ref people1);

//List<Person> under2 = people1.FindAll(p => p.Score < 2);
//under2.ForEach(p => Console.WriteLine(p));

//List<Person> equalScore = people1.FindAll(p => p.Score % 2 == 0);
//equalScore.ForEach(p => Console.WriteLine(p));

//List<Person> equalScoreAndWeightOverSixty = people1.FindAll(p => p.Score % 2 == 0 && p.Weight > 60);
//equalScoreAndWeightOverSixty.ForEach(p => Console.WriteLine(p));

//List<Person> weight3 = people1.FindAll(p => p.Weight % 3 == 0);
//weight3.ForEach(p => Console.WriteLine(p));

//int firstIndex3 = people1.FindIndex(p => p.Score == 3);
//Console.WriteLine(people1[firstIndex3]);

//int firstUnder10 = people1.FindIndex(p => p.Age < 10 && p.Score == 3);
//Console.WriteLine(people1[firstUnder10]);

//List<Person> under10Score3 = people1.FindAll(p => p.Age < 10 && p.Score == 3);
//Console.WriteLine(under10Score3.Count);

//int firstUnder8 = people1.FindIndex(p => p.Age < 8 && p.Score == 3);
//Console.WriteLine(firstUnder8);

//people1.SetAccepted(p => p.Score >= 6 && p.Age <= 40);
//people1.ForEach(p => Console.WriteLine(p));

//var sortedByScore = people1.OrderByDescending(p => p.Score).ToList();
//sortedByScore.ForEach(p => Console.WriteLine(p));


int[] numbers = { 34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20 };

//var twoDigits = numbers.Where(i => i.ToString().Length == 2).OrderByDescending(i => i).ToList();
//twoDigits.ForEach(i => Console.WriteLine(i));

var twoDigitsString = numbers.Where(i => i.ToString().Length == 2).OrderByDescending(i => i).Select(i => i.ToString()).ToList();
twoDigitsString.ForEach(i => Console.WriteLine(i));