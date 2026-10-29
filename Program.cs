
int choice;
do
{
    Console.WriteLine("Enter Your Choice: ");
    Console.WriteLine("1. Users: ");
    Console.WriteLine("2. Send Message: ");
    Console.WriteLine("3. View Messages ");
    Console.WriteLine("4. Login ");
    Console.WriteLine("5. Delete ");
    Console.WriteLine("6. Exit ");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter The Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter The Users_Name: ");
            string users_name = Console.ReadLine();
            Console.WriteLine("Enter The Password: ");
            string password = Console.ReadLine();
            Users u = new Users(name, users_name, password);
            Console.WriteLine(u);
            break;
        case 2:
            Console.WriteLine("Enter The Message From: ");
            string messageFrom = Console.ReadLine();
            Console.WriteLine("Enter The Message To: ");
            string messageTo = Console.ReadLine();
            Console.WriteLine("Enter The Message: ");
            string message = Console.ReadLine();
            Messages m = new Messages(messageFrom, messageTo, message);
            Console.WriteLine(m);
            break;
        case 3:
            Console.WriteLine("Enter The User1: ");
            string user1 = Console.ReadLine();
            Console.WriteLine("Enter The User2: ");
            string user2 = Console.ReadLine();
            Chats c = new Chats(user1, user2);
            Console.WriteLine(c);
            break;
        case 4:
            Console.WriteLine("Enter The Users_Name: ");
            string loginUsersName = Console.ReadLine();
            Console.WriteLine("Enter The Password: ");
            string loginPassword = Console.ReadLine();
            Login l = new Login(loginUsersName, loginPassword);
            Console.WriteLine(l);
            break;
        case 5:
            Console.WriteLine("Enter The Message No: ");
            int messageNo = Convert.ToInt32(Console.ReadLine());
            Delete d = new Delete(messageNo);
            Console.WriteLine(d);
            break;
        case 6:
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid Choice");
            break;
    }
} while (choice != 6);