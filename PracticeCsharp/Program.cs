

using PracticeCsharp;

class Demo
{
    static void Main(string[] args)
    {
        User user1 = new User("Vasya", 25,true, "vasya@.kt.ua", "948n5v45h46");
        User user2 = new User("Petya", 18, false, "petya@.kt.ua", "356h56h");
        User user3 = new User("Kolya", 43, true ,"vasya@.kt.ua", "45g346h56h");
        User user4 = new User("Masha", 22, false, "vasya@.kt.ua", "56n56n735n");
        User user5 = new User("Igor", 32, false, "vasya@.kt.ua", "156n56n");

        Dictionary<string, User> mapUser = new Dictionary<string, User>();
        mapUser.Add(user1.Name1, user1);
        mapUser.Add(user2.Name1, user2);
        mapUser.Add(user3.Name1, user3);
        mapUser.Add(user4.Name1, user4);
        mapUser.Add(user5.Name1, user5);

        foreach (var user in mapUser)
        {
           // Console.WriteLine(user.Value.Name1);
        }

        foreach (var user in mapUser )
        {
            if (user.Value.Age1 > 30 && user.Value.HasDriverLicense) ;
            // Console.WriteLine(user.Value.Name1);
        }

        List<User> userList = new List<User> { user1, user2, user3, user4, user5 };
        List<User> newArr = new List<User>();
        List<User> newArr1 = new List<User>();
        
       // find user with drive license and sort by age
        newArr = userList
            .FindAll(user => user.HasDriverLicense)
            .OrderBy(user => user.Age1)
            .ToList();
       
        // reset password for user with drive license
        newArr1 = userList
            .Where(user => user.HasDriverLicense)
            .Select(user => new User {
                Name1 = user.Name1,
                Password1 = "**********",
                Age1 = user.Age1,
                HasDriverLicense = user.HasDriverLicense,
                Email1 = user.Email1
            })
            .OrderBy(user => user.Age1)
            .ToList();
        
        newArr.ForEach(user => Console.WriteLine(user.ToString()));
        Console.WriteLine("\n");
        newArr1.ForEach(user => Console.WriteLine(user.ToString()));
        
       
        
        
    }
}