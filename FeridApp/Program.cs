

Console.WriteLine("\t\t \t \t \t \t Welcome to blank");

string username = "nobody";
string password = "O555";

int totalAmount = 0;
int amount = 0;
int totalMonth = 0;
int monthCount = 0;
int percent = 0;
int payAmount = 0;
int monthlyPayment = 0;
int proccesConsole = 0;
int authorize = 0;
string usernameConsole = "";
string passwordConsole = "";
while (true)
{
    if (authorize == 0)
    {
        Console.WriteLine("Enter username :");
        usernameConsole = Console.ReadLine();
        Console.WriteLine("Enter password :");
        passwordConsole = Console.ReadLine();
    }

    if (usernameConsole == username && passwordConsole == password)
    {
        authorize = 1;
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
                    if (monthCount>0)
                    {
                        Console.Write("Meblegi daxil edin : ");
                        payAmount = int.Parse(Console.ReadLine());
                        if (payAmount>0)
                        {
                            if (monthCount > 12)
                            {
                                percent = payAmount * 18 / 100;
                                amount = payAmount + percent;

                                monthlyPayment = amount / monthCount;

                                Console.WriteLine($"Odenilecek mebleq : {amount}AZN");
                                Console.WriteLine($"Ayliq Odenis : {monthlyPayment}AZN");
                                Console.WriteLine("Razisiniz ?");
                                Console.WriteLine("1 : Beli");
                                Console.WriteLine("2 : Xeyr");
                                int proccesConsole2 = int.Parse(Console.ReadLine());
                                if (proccesConsole2 == 1)
                                {
                                    totalAmount = totalAmount+amount;
                                    totalMonth=totalMonth+monthCount;
                                    Console.WriteLine("Emeliyyat ugurlu oldu yene gelin :)");
                                    Console.WriteLine($"Indiki borcunuz : {totalAmount}");
                                }
                                else
                                {
                                    percent = 0;
                                    amount = 0;
                                    monthlyPayment = 0;
                                    Console.WriteLine("Emeliyyat ugursuz oldu bide gelmeyin! :(");
                                }
                            }
                            else
                            {
                                percent = payAmount * 12 / 100;
                                amount = payAmount + percent;

                                monthlyPayment = amount / monthCount;

                                Console.WriteLine($"Odenilecek mebleq : {amount}AZN");
                                Console.WriteLine($"Ayliq Odenis : {monthlyPayment}AZN");
                                Console.WriteLine("Razisiniz ?");
                                Console.WriteLine("1 : Beli");
                                Console.WriteLine("2 : Xeyr");
                                int proccesConsole2 = int.Parse(Console.ReadLine());
                                if (proccesConsole2 == 1)
                                {
                                    totalAmount = totalAmount + amount;
                                    totalMonth = totalMonth + monthCount;
                                    Console.WriteLine("Emeliyyat ugurlu oldu yene gelin :)");
                                    Console.WriteLine($"Indiki borcunuz : {totalAmount}");
                                }
                                else
                                {
                                    percent = 0;
                                    amount = 0;
                                    monthlyPayment = 0;
                                    Console.WriteLine("Emeliyyat ugursuz oldu bide gelmeyin! :(");
                                }
                            }
                        }
                        else Console.WriteLine("Mebleq 0 dan boyuk olmalidi!");
                    }
                    else
                    {
                        Console.WriteLine("Ay 0 dan boyuk olmalidi!");
                    }
                    break;
                case 2:
                    if (totalAmount!=0)
                    {
                        Console.WriteLine($"Emeliyyat : {proccesConsole}");
                        Console.WriteLine($"Ayliq odenis {monthlyPayment}AZN");
                        Console.WriteLine("Odenis etmek isteyirsizse 1 basin");
                        int proccesConsole3 = int.Parse(Console.ReadLine());
                        if (proccesConsole3 == 1)
                        {
                            monthlyPayment = totalAmount / totalMonth;
                            totalAmount = totalAmount - monthlyPayment;
                            totalMonth = totalMonth - 1;
                            Console.WriteLine("Odenis ugurlu oldu :)");
                            Console.WriteLine($"Qalan Borc : {totalAmount}");
                            Console.WriteLine($"Qalan Ay : {totalMonth}");
                        }
                        else
                        {
                            monthlyPayment = 0;
                            Console.WriteLine("Emeliyyat ugursuz oldu bide gelmeyin! :(");
                        }
                    }
                    else
                    {

                        Console.WriteLine("Borcunuz yoxdu");
                    }

                    break;
                case 3:
                    Console.WriteLine($"Emeliyyat : {proccesConsole}");
                    Console.WriteLine($"Qalan Borc : {totalAmount}");
                    Console.WriteLine($"Qalan Ay : {totalMonth}");
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