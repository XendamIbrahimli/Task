namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("0.Add and ShowInfo   1.Exit");
                string input=Console.ReadLine();


                switch (input)
                {
                    case "0":
                        Console.WriteLine("Add fullname:");
                        string fullname=Console.ReadLine();

                        Console.WriteLine("Add Email:");
                        string email=Console.ReadLine();

                        bool check=false;
                        do
                        {
                            Console.WriteLine("Enter password:");
                            string password=Console.ReadLine();

                            User user=new User(fullname, email, password);

                            if (user.PasswordChecker(password))
                            {
                                check = true;
                                Console.WriteLine("Valid password");
                                user.ShowInfo();
                            }
                            else
                            {
                                check=false;
                                Console.WriteLine("Invalid password");
                            }


                        }while (!check);


                        

                        break;

                   


                    case "1":
                        return;

                } 

            }while (true);









        }
    }
}





