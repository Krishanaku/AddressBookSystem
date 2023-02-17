namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Program ");

            AddressBookMain c1 = new AddressBookMain();
            String[] names = { "Sagar", "Krishna", "Pankaj", "Dharani" };
            c1.change(names);

        }
    }
}