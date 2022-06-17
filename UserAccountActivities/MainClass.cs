using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountActivities
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // Instantiate objects of all 4 classes
            AddUser obj1 = new AddUser();
            UpdateUser obj2 = new UpdateUser();
            GetUser obj3 = new GetUser();
            ChangeUserPassword obj4 = new ChangeUserPassword();

            // prompt the user to pick an option 
            Console.WriteLine("Please select an number from the list below: ");
            Console.WriteLine("API list: \n" +
                    "1 - Add a User \n" +
                    "2 - Update a User \n" +
                    "3 - Get user Info \n" +
                    "4 - Change user password \n" +
                    ": ");
            int userChoice = Convert.ToInt32(Console.ReadLine());


            try
            {
                

                switch (userChoice)
                {
                    case 1:
                        // Adding a user ...
                        obj1.addUser();
                        break;
                    case 2:
                        // Updating a user ...
                        obj2.editUser();
                        break;
                    case 3:
                        // Getting a user's info ...
                        obj3.getUser();
                        break;
                    case 4:
                        // Updating a user's password
                        obj4.changeUserPassword();
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong., {e} is not a valid");
            }


        }
    }
}
