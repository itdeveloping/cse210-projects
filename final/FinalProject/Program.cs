using FinalProject;
using System;
using System.Collections;
using System.Collections.Generic;

//Instantiate the menu class for different options menus
Menu mainMenu = new("MainMenu.txt", "Main menu options: ");
Menu cubeMenu = new("CubeMenu.txt", " Cube menu options: ");
Menu productMenu = new("ProductMenu.txt", " Product menu options: ");
Menu productKindMenu = new("ProductKindMenu.txt", " Types of product menu options: ");
Menu ownerMenu = new("OwnerMenu.txt", " Owner menu options: ");
Menu customerMenu = new("CustomerMenu.txt", "Customer menu options: ");

//Declare variables
int selectedOption, cubeOption, productOption, productKindOption, ownerOption, customerOption;

//Instantiate Manager class to manage Cube, Product, and Person base classes and class lists
Manager manager = new Manager();

//start with main menu
Console.Clear();
Console.WriteLine("Final Project - Shop manager\n");
mainMenu.DisplayMenu();
Console.Write("\nChoose an option from the list: ");
selectedOption = Int16.Parse(Console.ReadLine());
while (selectedOption != 5) // Main menu option
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
                                    manager.AddProduct("new",0);
                                    
                                    break;
                                case 2: // Register clothes
                                    manager.AddClothes("new",0);
                                   
                                    break;
                                case 3: // Register cosmetics
                                    manager.AddCosmetic("new",0);

                                    break;
                                case 4: // Register  food
                                    manager.AddFood("new",0);

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
                        manager.AddService("new",0);

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
                switch (ownerOption) // Owner selected option
                {
                    case 1:// Register an owner
                        manager.AddOwner();
                        
                        break;
                    case 2: //List owners
                        manager.ListOwners();
                        break;
                    case 3:// update owner's information
                        manager.UpdateOwner();
                        break;
                    case 4: //delete owner's record
                        manager.DeleteOwner();
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
                        break;
                    case 2://List customers
                        manager.ListCustomer();
                        break;
                    case 3://Update customer's information
                        manager.UpdateCustomer();
                        break;
                    case 4://Delete customer's record
                        manager.DeleteCustomer();
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






