using DelegateEksempel;

string testString = "Hej  Med  Dig";

UppercaseFormatter uppercaseFormatter = new UppercaseFormatter();
RemovedoubleSpacesFormatter removedoubleSpacesFormatter = new RemovedoubleSpacesFormatter();

Udskriver.UdskrivVhaInterface(testString, uppercaseFormatter);
Console.WriteLine();
Udskriver.UdskrivVhaInterface(testString, removedoubleSpacesFormatter);