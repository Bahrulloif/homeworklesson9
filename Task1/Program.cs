var userNames = new User();
System.Console.WriteLine("Enter number of Users");
var size = Convert.ToInt32(System.Console.ReadLine());
for (int i = 0; i < size; i++)
{
    var user = new User();
    user.Name = Console.ReadLine();

    userNames.UserList.Add(user);
}

foreach (var us in userNames.UserList)
{
    System.Console.WriteLine(us.ToString());
}