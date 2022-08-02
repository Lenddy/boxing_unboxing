// Create an empty List of type object

List<object> objlist = new List<object>();
// Add the following values to the list: 7, 28, -1, true, "chair"


objlist.Add(7);
objlist.Add(28);
objlist.Add(-1);
objlist.Add(true);
objlist.Add("chair");
int sum = 0 ;

// Loop through the list and print all values
foreach(object item in objlist){
    if( item is int){
        // Add all values that are Int type together and output the sum
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
// print all values that are Int type together and output the sum
Console.WriteLine($"the sum of all the number is {sum} nicely done");
