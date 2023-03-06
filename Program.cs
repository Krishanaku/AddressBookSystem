namespace AddressBookSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to AddressBook Program ");

            //AddressBookMain.AddContact("krishna");
            //AddressBookMain.Display();
            //AddressBookMain.EditConatct();
            //AddressBookMain.DeleteContact("krishna");
            //AddressBookMain.AddMultipleConatcts("krihsn");

            List<Person> people = new List<Person>();
            people.Add(new Person { firstName = "Sagar", lastName = "Shahu", city = "Nagpur", state = "Maharashtra", zipcode = "440023", country = "India", phone = "55455665", email = "shahu@gmail.com" });

            Person newEntry1 = new Person { firstName = "Sagar", lastName = "Shahu", city = "Nagpur", state = "Maharashtra", zipcode = "440023", country = "India", phone = "55455665", email = "shahu@gmail.com" };
            if (people.Any(e => e.firstName == newEntry1.firstName))
            {
                Console.WriteLine("Duplicate entry: {0}", newEntry1.firstName);
            }
            else
            {
                people.Add(newEntry1);
            }






        }
    }
}