using ConsoleApp2;
using System;
using System.Collections;
using System.Collections.Generic;


Menu mainMenu = new("MainMenu.txt", "Main menu options: ");
Menu cubeMenu = new("CubeMenu.txt", " Cube menu options: ");
Menu productMenu = new("ProductMenu.txt", " Product menu options: ");
Menu productKindMenu = new("ProductKindMenu.txt", " Types of product menu options: ");
Menu ownerMenu = new("OwnerMenu.txt", " Owner menu options: ");
Menu customerMenu = new("CustomerMenu.txt", "Customer menu options: ");
int counter, selectedOption, cubeOption, productOption, productKindOption, ownerOption, customerOption, idCube, idCubeToUpdate, idCubeToDelete, idOwner, idOwnerToDelete, idOwnerToUpdate, idCustomer, stock;
string brand, name, description, size, provider, quantity, email, phone, serviceName;
double price;

List<Cube> cubeList = new List<Cube>();
Cube cubeObject;
List<Product> productList = new List<Product>();
Product productObject;
List<Person> customerList = new List<Person>();
Person customerObject;
List<Person> ownerList = new List<Person>();
Person ownerObject;


//add cubes samples
cubeObject = new ProductCube(1, 15.21, true);
cubeList.Add(cubeObject);
cubeObject = new ProductCube(3, 10.19, true);
cubeList.Add(cubeObject);
cubeObject = new ProductCube(2, 9.4, true);
cubeList.Add(cubeObject);
cubeObject = new ServiceCube(2, 9.4, true);
cubeList.Add(cubeObject);

//add owners samples
ownerObject = new Owner("Oscar Rodriguez", "oscar@gmail.com", "8342158421", 3);
ownerList.Add(ownerObject);
ownerObject = new Owner("Mercedes Ramirez", "mercedes@gmail.com", "8342158422", 1);
ownerList.Add(ownerObject);

//add customers samples
customerObject = new Customer("Public", "email@hotmail.com", "65231", 1);
customerList.Add(customerObject);
customerObject = new Customer("John", "john@gmail.com", "965231452", 2);
customerList.Add(customerObject);

// add product samples
productObject = new Product("Wood Pencils", "No. 2 Wood Pencils, 12 Count", "Pen+Gear", 0.47, 20);
productList.Add(productObject);
DateOnly dateOnly = new DateOnly(2023, 12, 31);
productObject = new Food("Potato Chips", " Classic Potato Chips, 8 oz Bag", "Lay's", 2.76, 50, dateOnly);
productList.Add(productObject);
productObject = new Clothe("Short", "Men's Yukon Stretch Twill Flat Front Short", "IRON Clothing", 9.99, 15, "M");
productList.Add(productObject);
productObject = new Cosmetic("Body Fragrance Mist", "Wild Wave Rider Ocean Splash", "Justice", 5.98, 15, "8.4 fl oz");
productList.Add(productObject);

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

            while (cubeOption != 6) // Cube Menu
            {

                switch (cubeOption) // CUbe menu selected options
                {
                    case 1: // Cube menu: Add a product cube
                        Console.Clear();
                        Console.WriteLine("Add a product cube: \n");
                        Console.Write("What is the number of the cube? ");
                        idCube = Int16.Parse(Console.ReadLine());
                        Console.Write($"What is the price for cube #{idCube}? ");
                        price = double.Parse(Console.ReadLine());

                        cubeObject = new ProductCube(idCube, price, true);
                        cubeList.Add(cubeObject);
                        Console.Write("\nYour --product cube-- has been added. Press <enter> to continue...");
                        Console.ReadLine();

                        break;
                    case 2: // Cube menu: Add a service cube
                        Console.Clear();

                        Console.WriteLine("Add a service cube: \n");
                        Console.Write("What is the number of the cube? ");
                        idCube = Int16.Parse(Console.ReadLine());
                        Console.Write($"What is the price for cube #{idCube}? ");
                        price = double.Parse(Console.ReadLine());
                        cubeObject = new ServiceCube(idCube, price, true);
                        cubeList.Add(cubeObject);
                        Console.Write("\nYour --service cube-- has been added. Press <enter> to continue...");
                        Console.ReadLine();
                        break;
                    case 3: // Cube menu: List cubes
                        Console.Clear();
                        if (cubeList.Count == 0) // check if the cube list is empty 
                        { // mesaage of empty list
                            Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");
                        }
                        else
                        { // list cubes
                            cubeList.Sort(delegate (Cube x, Cube y)
                            {
                                return x._idCube.CompareTo(y._idCube);
                            });

                            Console.WriteLine("List of registered cubes: \n");
                            counter = 1;
                            foreach (Cube item in cubeList)
                            {
                                Console.WriteLine($"{counter}. {item.ToString()}");
                                counter++;
                            }
                        }
                        Console.Write("\nPress <enter> to continue...");
                        Console.ReadLine();
                        break;
                    case 4: // Cube menu: Update cube's information 
                        Console.Clear();
                        if (cubeList.Count == 0) // check if the cube list is empty 
                        { // mesaage of empty list
                            Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");
                        }
                        else
                        { // list cubes
                            cubeList.Sort(delegate (Cube x, Cube y)
                            {
                                return x._idCube.CompareTo(y._idCube);
                            });
                            Console.WriteLine("Update cube's information: \n");
                            Console.WriteLine("List of registered cubes: \n");
                            counter = 1;
                            foreach (Cube item in cubeList)
                            {
                                Console.WriteLine($"{counter}. {item.ToString()}");
                                counter++;
                            }
                            Console.Write("\nSelect the list number to update the cube's information: ");
                            idCubeToUpdate = Int16.Parse(Console.ReadLine());
                            if (idCubeToUpdate > cubeList.Count)  // check if input is greater than list count
                            {
                                Console.Write("\nNot a valid input! Try again. ");
                            }
                            else
                            {
                                idCubeToUpdate--;

                                Console.Write("What is the number of the cube? ");
                                idCube = Int16.Parse(Console.ReadLine());
                                Console.Write($"What is the price for cube #{idCube}? ");
                                price = double.Parse(Console.ReadLine());
                                cubeList[idCubeToUpdate]._idCube = idCube;
                                cubeList[idCubeToUpdate]._price = price;
                                Console.Write("\nYour --service cube-- has been updated! ");
                            }

                        }
                        Console.Write("Press <enter> to continue... ");

                        Console.ReadLine();

                        break;
                    case 5: // Cube menu: Delete cube's information
                        Console.Clear();
                        cubeList.Sort(delegate (Cube x, Cube y)
                        {
                            return x._idCube.CompareTo(y._idCube);
                        });
                        if (cubeList.Count == 0) // check if the cube list is empty 
                        { // mesaage of empty list
                            Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");
                        }
                        else
                        { // list cubes
                            Console.WriteLine("Delete cube's information: \n");
                            Console.WriteLine("List of registered cubes: \n");
                            //cubeList.Sort(cubeObject._idCube);
                            counter = 1;
                            foreach (Cube item in cubeList)
                            {
                                Console.WriteLine($"{counter}. {item.ToString()}");
                                counter++;
                            }
                            Console.Write("\nChoose the list number to delete: ");
                            idCubeToDelete = Int16.Parse(Console.ReadLine());
                            if (idCubeToDelete > cubeList.Count)  // check if input is greater than list count
                            {
                                Console.Write("\nNot a valid input! Try again. ");
                            }
                            else
                            {
                                idCubeToDelete--;
                                cubeList.RemoveRange(idCubeToDelete, 1);
                                Console.Write($"\nThe cube information has been deleted! ");
                            }
                        }
                        Console.Write("Press <enter> to continue... ");
                        Console.ReadLine();
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
            while (productOption != 6) // Kinds of products menu options
            {
                switch (productOption) // kinds of products selected option
                {
                    case 1: // create a product/service
                        productKindMenu.DisplayMenu();
                        Console.Write("\nChoose an option from list: ");
                        productKindOption = Int16.Parse(Console.ReadLine());
                        while (productKindOption != 5)
                        {

                            switch (productKindOption)
                            {
                                case 1: //register a general product
                                    Console.Clear();
                                    Console.WriteLine("Register a general product.\n");
                                    Console.Write("What is the brand of the product: ");
                                    brand = Console.ReadLine();
                                    Console.Write("What is the name of the product: ");
                                    name = Console.ReadLine();
                                    Console.Write($"Type a brief description for {brand} {name}: ");
                                    description = Console.ReadLine();
                                    Console.Write($"What is the price for {brand} {name}: ");
                                    price = double.Parse(Console.ReadLine());
                                    Console.Write($"What is the stock for {brand} {name}: ");
                                    stock = Int16.Parse(Console.ReadLine());
                                    productObject = new Product(name, description, brand, price, stock);
                                    productList.Add(productObject);
                                    Console.Write($"\nYour -- {brand} {name} -- has been registered!. Press <enter> to continue...");
                                    Console.ReadLine();
                                    break;
                                case 2: // register clothes
                                    Console.Clear();
                                    Console.WriteLine("Register clothes.\n");
                                    Console.Write("What is the brand of the clothes: ");
                                    brand = Console.ReadLine();
                                    Console.Write("What is the clothes' name: ");
                                    name = Console.ReadLine();
                                    Console.Write($"Type a brief description for {brand} {name}: ");
                                    description = Console.ReadLine();
                                    Console.Write($"What is the size for {brand} {name} (xs|s|m|l|xl|xxl): ");
                                    size = Console.ReadLine().ToUpper();
                                    Console.Write($"What is the price for {brand} {name}: ");
                                    price = double.Parse(Console.ReadLine());
                                    Console.Write($"What is the stock for {brand} {name}: ");
                                    stock = Int16.Parse(Console.ReadLine());
                                    productObject = new Clothe(name, description, brand, price, stock, size);
                                    productList.Add(productObject);
                                    Console.Write($"\nYour -- {brand} {name} -- has been registered!. Press <enter> to continue...");
                                    Console.ReadLine();
                                    break;
                                case 3: // register cosmetics
                                    Console.Clear();
                                    Console.WriteLine("Register cosmetic.\n");
                                    Console.Write("What is the brand of the cosmetic: ");
                                    brand = Console.ReadLine();
                                    Console.Write("What is the cosmetic's: ");
                                    name = Console.ReadLine();
                                    Console.Write($"Type a brief description for {brand} {name}: ");
                                    description = Console.ReadLine();
                                    Console.Write($"What is the quantity(ex. 100 ml) for {brand} {name}: ");
                                    quantity = Console.ReadLine();
                                    Console.Write($"What is the price for {brand} {name}: ");
                                    price = double.Parse(Console.ReadLine());
                                    Console.Write($"What is the stock for {brand} {name}: ");
                                    stock = Int16.Parse(Console.ReadLine());
                                    productObject = new Clothe(name, description, brand, price, stock, quantity);
                                    productList.Add(productObject);
                                    Console.Write($"\nYour -- {brand} {name} -- cosmetic has been registered!. Press <enter> to continue...");
                                    Console.ReadLine();
                                    break;
                                case 4: // list products/services

                                    productList.Sort(delegate (Product x, Product y)
                                    {
                                        return x._name.CompareTo(y._name);
                                    });

                                    Console.Clear();
                                    Console.WriteLine("Products list:\n");
                                    counter = 1;
                                    foreach (Product item in productList)
                                    {
                                        Console.WriteLine($"{counter}. {item.ToString()}");
                                        counter++;
                                    }
                                    Console.Write("\nPress <enter> to continue... ");
                                    Console.ReadLine();
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
                        Console.Clear();
                        Console.WriteLine("Register a service.\n");
                        Console.Write("What is the service's name: ");
                        name = Console.ReadLine();
                        Console.Write($"Type a brief description for {name}: ");
                        description = Console.ReadLine();
                        Console.Write($"What is the provider's name for {name}: ");
                        provider = Console.ReadLine();
                        productObject = new Service(name, description, provider);
                        productList.Add(productObject);
                        Console.Write($"\nYour -- {name} -- service has been registered!. Press <enter> to continue...");
                        Console.ReadLine();
                        break;
                    case 3: // list products/services
                        Console.Clear();
                        productList.Sort(delegate (Product x, Product y)
                        {
                            return x._name.CompareTo(y._name);
                        });
                        Console.WriteLine("Products list:\n");
                        counter = 1;
                        foreach (Product item in productList)
                        {
                            Console.WriteLine($"{counter}. {item.ToString()}");
                            counter++;
                        }
                        Console.Write("\nPress <enter> to continue... ");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("4");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("5");
                        Console.ReadLine();
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
                        Console.Clear();
                        Console.WriteLine("Register an owner: \n");
                        Console.Write("What is the owner's name? ");
                        name = Console.ReadLine();
                        Console.Write($"What is the {name}'s email? ");
                        email = Console.ReadLine();
                        Console.Write($"What is the {name}'s phone number? ");
                        phone = Console.ReadLine();
                        Console.Write($"What is the {name}'s id? ");
                        idOwner = Int16.Parse(Console.ReadLine());
                        ownerObject = new Owner(name, email, phone, idOwner);
                        ownerList.Add(ownerObject);
                        Console.Write($"\n{name} has been register as owner. Press <enter> to continue...");
                        Console.ReadLine();
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
                        Console.Clear();
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
                        Console.ReadLine();

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
        case 5: // create a shopping list
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






