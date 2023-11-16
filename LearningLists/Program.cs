

//List<int> myList = new List<int>();

//myList.Add(0);
//myList.Add(1);
//myList.Add(2);
//myList.Add(3);
//myList.Add(4);
//myList.Add(5);


//foreach (int i in myList)
//{
//    Console.WriteLine(i);
//}

List<string> firstNames = new List<string>();

firstNames.Add("Tim");
firstNames.Add("Bob");
firstNames.Add("Sue");
firstNames.Add("Jane");
firstNames.Add("Frank");

Console.WriteLine(firstNames[firstNames.Count - 1]);

List<int> ages = new List<int>();

ages.Add(1);
ages.Add(2);
ages.Add(3);
ages.Add(4);
ages.Add(5);

string data = "Corey,Smith,Jones";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Franklin");


