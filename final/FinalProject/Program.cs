using FinalProject;
using System;
using System.Collections;
using System.Collections.Generic;


Menu mainMenu = new("MainMenu.txt", "Main menu options: ");
Menu cubeMenu = new("CubeMenu.txt", " Cube menu options: ");
Menu productMenu = new("ProductMenu.txt", " Product menu options: ");
Menu productKindMenu = new("ProductKindMenu.txt", " Types of product menu options: ");
Menu ownerMenu = new("OwnerMenu.txt", " Owner menu options: ");
Menu customerMenu = new("CustomerMenu.txt", "Customer menu options: ");
int counter, selectedOption, cubeOption, productOption, productKindOption, ownerOption, customerOption, idProductToDelete, idProductToUpdate, idOwner, idOwnerToDelete, idOwnerToUpdate, idCustomer, stock;
string brand, name, description, size, provider, quantity, email, phone;
double price;


List<Product> productList = new List<Product>();
Product productObject;
List<Person> customerList = new List<Person>();
Person customerObject;
List<Person> ownerList = new List<Person>();
Person ownerObject;

Manager manager = new Manager();
//start with main menu
Console.Clear();
Console.WriteLine("Final Project - Shop manager\n");
mainMenu.DisplayMenu();
Console.Write("\nChoose an option from the list: ");
selectedOption = Int16.Parse(Console.ReadLine());
while (selectedOption != 6) // Main menu option
{
    switch (selectedOption) // Main menu selected options
    {
        case 1: // Cube manager option
            cubeMenu.DisplayMenu();
            Console.Write("\nChoose an option from the list: ");
            cubeOption = Int16.Parse(Console.ReadLine());

            while (cubeOption != 8) // Cube Menu
            {

                switch (cubeOption) // CUbe menu selected options
                {
                    case 1: // Cube menu: Add a product cube
                        manager.AddProductCube();
                        break;
                    case 2: // Cube menu: Add a service cube
                        manager.AddServiceCube();
                        break;
                    case 3: // Cube menu: List cubes
                        manager.ListCubes();
                        break;
                    case 4: // Cube menu: Update cube's information 
                        manager.UpdateCube();
                        break;
                    case 5: // Cube menu: Delete cube's information
                        manager.DeleteCube();
                        break;
                    case 6: // Rent a cube
                        manager.RentCube();
                        break;
                    case 7:
                        manager.ReleaseCube();
                        break;
                    default: //not a valid option
                        Console.WriteLine($"\n{cubeOption} is not a valid option! Try again, press <enter> to continue...");
                        break;
                }

                cubeMenu.DisplayMenu();
                Console.Write("\nChoose an option from the list: ");
                cubeOption = Int16.Parse(Console.ReadLine());
            }

            break;
        case 2: // manage product
            productMenu.DisplayMenu();
            Console.Write("\nChoose an option from the list: ");
            productOption = Int16.Parse(Console.ReadLine());
            while (productOption != 7) // Kinds of products menu options
            {
                switch (productOption) // kinds of products selected option
                {
                    case 1: // Add a product/service
                        productKindMenu.DisplayMenu();
                        Console.Write("\nChoose an option from list: ");
                        productKindOption = Int16.Parse(Console.ReadLine());
                        while (productKindOption != 6)
                        {

                            switch (productKindOption)
                            {
                                case 1: //Register a general product
                                    manager.AddProduct("new");
                                    
                                    break;
                                case 2: // Register clothes
                                    manager.AddClothes("new");
                                   
                                    break;
                                case 3: // Register cosmetics
                                    manager.AddCosmetic("new");

                                    break;
                                case 4: // Register  food
                                    manager.AddFood("new");

                                    break;
                                case 5: // list products/services
                                    manager.ListProducts();

                                    break;
                                default://not a valid option
                                    Console.WriteLine($"\n{productKindOption} is not a valid option! Try again, press <enter> to continue...");
                                    break;
                            }
                            productKindMenu.DisplayMenu();
                            Console.Write("\nChoose an option from list: ");
                            productKindOption = Int16.Parse(Console.ReadLine());
                        }
                        break;
                    case 2: // register a service
                        manager.AddService("new");

                        break;
                    case 3: // list products/services
                        manager.ListProducts();

                        break;
                    case 4://update a product/service
                        manager.UpdateProduct();

                        break;
                    case 5://delete a product/service
                        manager.DeleteProduct();
                        break;
                    case 6: // Assign product/service to a cube
                        manager.AssignProduct();
                        break;
                    default: //not a valid option
                        Console.WriteLine($"\n{productOption} is not a valid option! Try again, press <enter> to continue...");
                        break;
                }
                productMenu.DisplayMenu();
                Console.Write("\nChoose an option from the cube menu: ");
                productOption = Int16.Parse(Console.ReadLine());
            }
            break;
        case 3: // manage Owners
            ownerMenu.DisplayMenu();
            Console.Write("\nChoose an option from the list: ");
            ownerOption = Int16.Parse(Console.ReadLine());
            while (ownerOption != 5) // Owner menu options
            {
                switch (ownerOption) // Owner mselected option
                {
                    case 1:// Register an owner
                        /*Console.Clear();
                        Console.WriteLine("Register an owner: \n");
                        Console.Write("What is the owner's name? ");
                        name = Console.ReadLine();
                        Console.Write($"What is the {name}'s email? ");
                        email = Console.ReadLine();
                        Console.Write($"What is the {name}'s phone number? ");
                        phone = Console.ReadLine();
                        Console.Write($"What is the {name}'s id? ");
                        idOwner = Int16.Parse(Console.ReadLine());
                        ownerObject = new Owner(idOwner,name, email, phone );
                        ownerList.Add(ownerObject);
                        Console.Write($"\n{name} has been register as owner. Press <enter> to continue...");
                        Console.ReadLine();*/
                        break;
                    case 2: //List owners
                        Console.Clear();

                        if (ownerList.Count == 0) // check if the owner list is empty 
                        { // mesaage of empty list
                            Console.WriteLine("Your owners list is empty! Add a product/service cube from the Cube Menu.");
                        }
                        else
                        { // list owners
                            Console.WriteLine("List of registered owners: \n");
                            ownerList.Sort(delegate (Person x, Person y)
                            {
                                return x._name.CompareTo(y._name);
                            });
                            counter = 1;
                            foreach (Person item in ownerList)
                            {
                                Console.WriteLine($"{counter}. {item.ToString()}");
                                counter++;
                            }

                        }
                        Console.Write("\nPress <enter> to continue... ");
                        Console.ReadLine();
                        break;
                    case 3:// update owner's information

                        Console.Clear();

                        if (ownerList.Count == 0) // check if the owner list is empty 
                        { // mesaage of empty list
                            Console.WriteLine("Your owners list is empty! Register a new owner from te owner's menu.");
                        }
                        else
                        { // list owners
                            Console.WriteLine("List of registered owners: \n");
                            ownerList.Sort(delegate (Person x, Person y)
                            {
                                return x._name.CompareTo(y._name);
                            });
                            counter = 1;
                            foreach (Person item in ownerList)
                            {
                                Console.WriteLine($"{counter}. {item.ToString()}");
                                counter++;
                            }
                            Console.Write("\nSelect the list number to update the owner's information: ");
                            idOwnerToUpdate = Int16.Parse(Console.ReadLine());
                            if (idOwnerToUpdate > ownerList.Count) // check if input is greater than list count
                            {
                                Console.Write("\nNot a valid input! Try again. ");
                            }
                            else
                            {
                                idOwnerToUpdate--;

                                Console.Write("\nWhat is the new owner's name? ");
                                name = Console.ReadLine();
                                Console.Write($"What is the new {name}'s email? ");
                                email = Console.ReadLine();
                                Console.Write($"What is the new {name}'s phone number? ");
                                phone = Console.ReadLine();
                                Console.Write($"What is the new {name}'s id? ");
                                idOwner = Int16.Parse(Console.ReadLine());

                                ownerList[idOwnerToUpdate]._name = name;
                                ownerList[idOwnerToUpdate]._email = email;
                                ownerList[idOwnerToUpdate]._phone = phone;
                                ownerList[idOwnerToUpdate]._id = idOwner;

                                Console.Write("\nThe owner's information has been updated! ");
                            }

                        }
                        Console.Write("Press <enter> to continue... ");
                        Console.ReadLine();
                        break;
                    case 4: //delete owner's record
                        Console.Clear();

                        if (ownerList.Count == 0) // check if the owner list is empty 
                        { // mesaage of empty list
                            Console.WriteLine("Your owners list is empty! Register a new owner from te owner's menu.");
                        }
                        else
                        { // list owners
                            Console.WriteLine("List of registered owners: \n");
                            ownerList.Sort(delegate (Person x, Person y)
                            {
                                return x._name.CompareTo(y._name);
                            });
                            counter = 1;
                            foreach (Person item in ownerList)
                            {
                                Console.WriteLine($"{counter}. {item.ToString()}");
                                counter++;
                            }
                            Console.Write("\nSelect a number from the list to delete: ");
                            idOwnerToDelete = Int16.Parse(Console.ReadLine());
                            if (idOwnerToDelete > ownerList.Count)  // check if input is greater than list count
                            {
                                Console.Write("\nNot a valid input! Try again. ");
                            }
                            else
                            {
                                idOwnerToDelete--;
                                ownerList.RemoveRange(idOwnerToDelete, 1);
                                Console.Write($"\nThe owner information has been deleted! ");
                            }
                        }
                        Console.Write("Press <enter> to continue... ");
                        Console.ReadLine();
                        break;

                    default://not a valid option
                        Console.WriteLine($"\n{ownerOption} is not a valid option! Try again, press <enter> to continue...");
                        Console.ReadLine();
                        break;
                }
                ownerMenu.DisplayMenu();
                Console.Write("\nChoose an option from the list: ");
                ownerOption = Int16.Parse(Console.ReadLine());
            }
            break;
        case 4:// Manage customer option

            Console.Clear();
            customerMenu.DisplayMenu();
            Console.Write("\nChoose an option from the list: ");
            customerOption = Int16.Parse(Console.ReadLine());

            while (customerOption != 5)// is option 5 is chosen then goes back to main menu
            {
                switch (customerOption)
                {
                    case 1://Register a customer
                        manager.AddCustomer();
                        /*Console.Clear();
                        Console.WriteLine("Register a customer: \n");
                        Console.Write("What is the customer's name? ");
                        name = Console.ReadLine();

                        Console.Write($"What is the {name}'s email? ");
                        email = Console.ReadLine();
                        Console.Write($"What is the {name}'s phone number? ");
                        phone = Console.ReadLine();
                        Console.Write($"What is the id for {name}? ");
                        idCustomer = Int16.Parse(Console.ReadLine());

                        customerObject = new Customer(name, email, phone, idCustomer);
                        customerList.Add(customerObject);
                        Console.Write($"\n{name}-- has been registered as customer. Press <enter> to continue...");
                        Console.ReadLine();*/

                        break;
                    case 2://List customers
                        Console.Clear();

                        if (customerList.Count == 0) // check if the owner list is empty 
                        { // mesaage of empty list
                            Console.WriteLine("Your customers list is empty! Add acustomers from the customers Menu.");
                        }
                        else
                        { // list owners
                            Console.WriteLine("List of registered customers: \n");
                            customerList.Sort(delegate (Person x, Person y)
                            {
                                return x._name.CompareTo(y._name);
                            });
                            counter = 1;
                            foreach (Person item in customerList)
                            {
                                Console.WriteLine($"{counter}. {item.ToString()}");
                                counter++;
                            }

                        }
                        Console.Write("\nPress <enter> to continue... ");
                        Console.ReadLine();
                        break;
                    case 3://Update customer's information
                        Console.Clear();

                        if (customerList.Count == 0) // check if the owner list is empty 
                        { // mesaage of empty list
                            Console.WriteLine("Your customers list is empty! Add acustomers from the customers Menu.");
                        }
                        else
                        { // list owners
                            Console.WriteLine("List of registered customers: \n");
                            customerList.Sort(delegate (Person x, Person y)
                            {
                                return x._name.CompareTo(y._name);
                            });
                            counter = 1;
                            foreach (Person item in customerList)
                            {
                                Console.WriteLine($"{counter}. {item.ToString()}");
                                counter++;
                            }

                        }

                        Console.Write("\nPress <enter> to continue... ");
                        Console.ReadLine();
                        break;
                    case 4://Delete customer's record
                        Console.Clear();

                        if (customerList.Count == 0) // check if the owner list is empty 
                        { // mesaage of empty list
                            Console.WriteLine("Your customers list is empty! Add acustomers from the customers Menu.");
                        }
                        else
                        { // list owners
                            Console.WriteLine("List of registered customers: \n");
                            customerList.Sort(delegate (Person x, Person y)
                            {
                                return x._name.CompareTo(y._name);
                            });
                            counter = 1;
                            foreach (Person item in customerList)
                            {
                                Console.WriteLine($"{counter}. {item.ToString()}");
                                counter++;
                            }

                        }

                        Console.Write("\nPress <enter> to continue... ");
                        Console.ReadLine();
                        break;
                    default://not a valid option
                        Console.WriteLine($"\n{customerOption} is not a valid option! Try again, press <enter> to continue...");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
                customerMenu.DisplayMenu();
                Console.Write("\nChoose an option from the list: ");
                customerOption = Int16.Parse(Console.ReadLine());
            }
            break;
        case 5: // Screen reports
            Console.WriteLine();
            Console.ReadLine();
            break;

        default:
            Console.Write($"{selectedOption} is not a valid option!. Try again, press <enter> to continue... ");
            Console.ReadLine();
            break;

    }
    mainMenu.DisplayMenu();
    Console.Write("\nChoose an option from the list: ");
    selectedOption = Int16.Parse(Console.ReadLine());
}
Console.WriteLine("\nThank you for using our systems. See you soon!");
Console.WriteLine("------------------------------------------------");






