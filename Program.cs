List<object> objlist = new List<object>();

objlist.Add(7);
objlist.Add(28);
objlist.Add(-1);
objlist.Add(true);
objlist.Add("chair");
int sum = 0 ;

foreach(object item in objlist){
    if( item is int){
        int intnum = (int)item;
        sum += intnum;
        Console.WriteLine($"{item} is an int");
    }
    if(item is bool){
        Console.WriteLine($"{item} is a boolean");
    }
    if (item is string){
        Console.WriteLine($"{item} is a string");
    }
}
Console.WriteLine($"the sum of all the number is {sum} nicely done");
