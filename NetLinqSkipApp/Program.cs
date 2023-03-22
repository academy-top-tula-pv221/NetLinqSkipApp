using ExampleClassLibrary;

var users = new List<User>()
{
    new("Sam", 35),
    new("Bob", 31),
    new("Tim", 29),
    new("Joe", 42),
    new("Leo", 35),
    new("Tom", 41),
    new("Bill", 19),
    new("Ann", 35),
    new("Poul", 24),
    new("Leo", 30),
    new("Phill", 37),
    new("Elisa", 25),
};



//var usersSkip = users.Skip(5);
//var usersSkip = users.SkipLast(5);
//var usersSkip = users.SkipWhile(u => u.Age < 40);

//foreach (var user in usersSkip)
//    Console.WriteLine($"User name: {user.Name}, age: {user.Age}");


//var usersTake = users.Take(4);
//var usersTake = users.TakeLast(4);
//var usersTake = users.TakeWhile(u => u.Age != 19);

//foreach (var user in usersTake)
//    Console.WriteLine($"User name: {user.Name}, age: {user.Age}");

int position = 0;
int count = 3;

while (position < users.Count)
{
    Console.Clear();
    var result = users.Skip(position).Take(count);
    foreach(var user in result)
        Console.WriteLine($"User name: {user.Name}, age: {user.Age}");
    position += count;
    Console.ReadKey();
}
