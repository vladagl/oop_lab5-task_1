MyList<int> mylist = new MyList<int>(5);
mylist[0] = 1;
Console.WriteLine("Ємніть списку: {0} елементів", mylist.Capacity);
Console.WriteLine("Список містить: {0} елементів", mylist.Count);
mylist.Add(15);
Console.WriteLine("Ємність списку: {0} елементів", mylist.Capacity);
 
Console.ReadKey();