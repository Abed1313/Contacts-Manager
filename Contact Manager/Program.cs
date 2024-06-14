using System.Linq;

namespace Contact_Manager
{
    public class Program
    {
        private static List<string> contacts = new List<string>();

        static void Main(string[] args)
        {
            ContactsManager();

        }

        public static void ContactsManager()
        {
            try
            {
                AddContact("Abood");
                AddContact("Jana");
                Console.WriteLine("Contacts after adding:");
                foreach (var contact in ViewAllContacts())
                {
                    Console.WriteLine(contact);
                }

                RemoveContact("Abood");
                Console.WriteLine("Contacts after removing:");
                foreach (var contact in ViewAllContacts())
                {
                    Console.WriteLine(contact);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static List<string> AddContact(string contact)
        {
            if (string.IsNullOrEmpty(contact))
            {
                throw new ArgumentException("Contact cannot be empty.");
            }

            if (contacts.Contains(contact))
            {
                throw new ArgumentException("Contact already exists.");
            }
            contacts.Add(contact);
            return new List<string>(contacts);
        }

        public static List<string> RemoveContact(string contact)
        {
            if (string.IsNullOrEmpty(contact))
            {
                throw new ArgumentException("Contact cannot be empty.");
            }
            if (!contacts.Contains(contact))
            {
                throw new ArgumentException("Contact does not exist.");
            }
            contacts.Remove(contact);
            return new List<string>(contacts);
        }

        public static List<string> ViewAllContacts()
        {
            return new List<string>(contacts);
        }
    }
}
