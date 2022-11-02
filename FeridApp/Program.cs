

Console.WriteLine("\t\t \t \t \t \t Welcome to blank");
while (true)
{
    string username = "nobody";
    string password = "O555";

    int totalAmount = 0;
    int monthCount = 0;
    int percent = 0;
    int payAmount = 0;
    int monthlyPayment = 0;
    Console.WriteLine("Enter username :");
    string usernameConsole = Console.ReadLine();
    Console.WriteLine("Enter password :");
    string passwordConsole = Console.ReadLine();
    int proccesConsole = 0;

    if (usernameConsole == username && passwordConsole == password)
    {

        if (proccesConsole == 0)
        {
            Console.WriteLine("\t\t \t \t \t \t Welcome Nobody");
            Console.WriteLine("\t\t \t \t  ------------------------------------");
            Console.WriteLine("1 : Kredit goturmek");
            Console.WriteLine("2 : Kredit odemek");
            Console.WriteLine("3 : Hesabat");

            Console.WriteLine("Choose process:");
            proccesConsole = int.Parse(Console.ReadLine());
            switch (proccesConsole)
            {
                case 1:
                    Console.WriteLine($"Emeliyyat : {proccesConsole}");
                    Console.Write($"Ay daxiledin:");
                    monthCount = int.Parse(Console.ReadLine());
                    Console.Write("Meblegi daxil edin : ");
                    payAmount = int.Parse(Console.ReadLine());
                    if (monthCount > 12)
                    {
                        percent = payAmount * 18 / 100;
                        totalAmount = payAmount + percent;

                        monthlyPayment = totalAmount / monthCount;

                        Console.WriteLine($"Odenilecek mebleq : {totalAmount}AZN");
                        Console.WriteLine($"Ayliq Odenis : {monthlyPayment}AZN");
                        Console.WriteLine("Razisiniz ?");
                        Console.WriteLine("1 : Beli");
                        Console.WriteLine("2 : Xeyr");
                        int proccesConsole2 = int.Parse(Console.ReadLine());
                        if (proccesConsole2 == 1)
                        {
                            Console.WriteLine("Emeliyyat ugurlu oldu yene gelin :)");
                            Console.WriteLine($"Indiki borcunuz : {totalAmount}");
                        }
                        else
                        {
                            Console.WriteLine("Emeliyyat ugursuz oldu bide gelmeyin! :(");
                        }
                    }
                    else
                    {
                        percent = payAmount * 12 / 100;
                        totalAmount = payAmount + percent;

                        monthlyPayment = totalAmount / monthCount;

                        Console.WriteLine($"Odenilecek mebleq : {totalAmount}AZN");
                        Console.WriteLine($"Ayliq Odenis : {monthlyPayment}AZN");
                        Console.WriteLine("Razisiniz ?");
                        Console.WriteLine("1 : Beli");
                        Console.WriteLine("2 : Xeyr");
                        int proccesConsole2 = int.Parse(Console.ReadLine());
                        if (proccesConsole2 == 1)
                        {
                            Console.WriteLine("Emeliyyat ugurlu oldu yene gelin :)");
                            Console.WriteLine($"Indiki borcunuz : {totalAmount}");
                        }
                        else
                        {
                            Console.WriteLine("Emeliyyat ugursuz oldu bide gelmeyin! :(");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine($"Emeliyyat : {proccesConsole}");
                    Console.WriteLine($"Ayliq odenis {monthlyPayment}AZN");
                    Console.WriteLine("Odenis etmek isteyirsizse 1 basin");
                    int proccesConsole3 = int.Parse(Console.ReadLine());
                    if (proccesConsole3 == 1)
                    {
                        totalAmount = totalAmount - monthlyPayment;
                        monthCount = monthCount - 1;
                        Console.WriteLine("Odenis ugurlu oldu :)");
                        Console.WriteLine($"Qalan Borc : {totalAmount}");
                        Console.WriteLine($"Qalan Ay : {monthCount}");
                    }
                    else
                    {
                        Console.WriteLine("Emeliyyat ugursuz oldu bide gelmeyin! :(");
                    }

                    break;
                case 3:
                    Console.WriteLine($"Emeliyyat : {proccesConsole}");
                    Console.WriteLine($"Qalan Borc : {totalAmount}");
                    Console.WriteLine($"Qalan Ay : {monthCount}");
                    break;
                default:
                    Console.WriteLine($"Bele emeliyyat yoxdu!;");
                    break;
            }
            Console.WriteLine($"Menu getmek ucun 0 basin;");
            proccesConsole = int.Parse(Console.ReadLine());
        }

    }
    else
        Console.WriteLine("username or password is invalid!");
}
