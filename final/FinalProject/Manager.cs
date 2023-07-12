using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Manager
    {
        private int _counter, _idCube, _cubeIndex, _stock, _idCustomer, _idOwner, _ownerIndex;
        private string _name, _description, _brand, _size, _quantity, _provider, _email, _phone;
        private double _price;
        private DateTime _bestBy = new();

        private List<Cube> _cubeList = new List<Cube>();
        private Cube _cubeObject;

        private List<Cube> _rentedCubes = new List<Cube>();

        private List<Product> _productList = new List<Product>();
        private Product _productObject;

        private List<Person> _customerList = new List<Person>();
        private Person _customerObject;

        private List<Person> _ownerList = new List<Person>();
        private Person _ownerObject;


        public Manager()
        {
            //add owners samples
            _ownerObject = new Owner(1, "Oscar Rodriguez", "oscar@gmail.com", "8342158421");
            _ownerList.Add(_ownerObject);
            _ownerObject = new Owner(2, "Mercedes Ramirez", "mercedes@gmail.com", "8342158422");
            _ownerList.Add(_ownerObject);

            //add cubes samples
            _cubeObject = new ProductCube(1, 15.21, true);
            _cubeList.Add(_cubeObject);
            _cubeObject = new ProductCube(3, 10.19, true);
            _cubeList.Add(_cubeObject);
            _cubeObject = new ProductCube(2, 9.4, true);
            _cubeList.Add(_cubeObject);
            _cubeObject = new ServiceCube(4, 9.4, true);
            _cubeList.Add(_cubeObject);


            // add product samples
            _productObject = new Product("Pen+Gear", "Wood Pencils", "No. 2 Wood Pencils, 12 Count", 0.47, 20);
            _productList.Add(_productObject);
            DateTime DateTime = new DateTime(2023, 12, 31);
            _productObject = new Food("Lay's", "Potato Chips", " Classic Potato Chips, 8 oz Bag", 2.76, 50, DateTime);
            _productList.Add(_productObject);
            _productObject = new Clothes("IRON Clothing", "Short", "Men's Yukon Stretch Twill Flat Front Short", 9.99, 15, "M");
            _productList.Add(_productObject);
            _productObject = new Cosmetic("Justice", "Body Fragrance Mist", "Wild Wave Rider Ocean Splash", 5.98, 15, "8.4 fl oz");
            _productList.Add(_productObject);
            _productObject = new Service("Vehicle Insurance", "The Insurance Savings You Expect", 130, "GEICO");
            _productList.Add(_productObject);

            //add customers samples
            _customerObject = new Customer(1, "Public", "email@hotmail.com", "65231");
            _customerList.Add(_customerObject);
            _customerObject = new Customer(2, "John", "john@gmail.com", "965231452");
            _customerList.Add(_customerObject);


        }

        public string GetOwnerName(int idOwner)
        {
            int _ownerIndex = _ownerList.FindIndex(a => a.GetId() == idOwner);

            return $"{_ownerList[_ownerIndex].GetName()}";
        }

        public void AddProductCube()
        {
            Console.Clear();
            Console.WriteLine("Add a product cube: \n");
            Console.Write("What is the number of the cube? ");
            _idCube = Int16.Parse(Console.ReadLine());
            _cubeIndex = _cubeList.FindIndex(a => a.GetIdCube() == _idCube); //find index
            if (_cubeIndex != -1) // _idCube found
            {
                Console.WriteLine($"\nThe cube #{_idCube} is already registered! \n");
                Console.WriteLine($"Registered information: {_cubeList[_cubeIndex].ToString()}\n");
                Console.Write("Please try again! ");
            }
            else
            {
                Console.Write($"What is the price for cube #{_idCube}? ");
                _price = double.Parse(Console.ReadLine());

                _cubeObject = new ProductCube(_idCube, _price, true);
                _cubeList.Add(_cubeObject);
                Console.Write("\nYour --product cube-- has been added. ");
            }

            Console.Write("Press <enter> to continue...");
            Console.ReadLine();
        }
        public void AddServiceCube()
        {
            Console.Clear();

            Console.WriteLine("Add a service cube: \n");
            Console.Write("What is the number of the cube? ");
            _idCube = Int16.Parse(Console.ReadLine());
            _cubeIndex = _cubeList.FindIndex(a => a.GetIdCube() == _idCube); //find index
            if (_cubeIndex != -1) // _idCube found
            {
                Console.WriteLine($"\nThe cube #{_idCube} is already registered! \n");
                Console.WriteLine($"Registered information: {_cubeList[_cubeIndex].ToString()}\n");
                Console.Write("Please try again! ");
            }
            else
            {
                Console.Write($"What is the price for cube #{_idCube} (Service cube will increase 8.25% tax)? ");
                _price = double.Parse(Console.ReadLine());
                _cubeObject = new ServiceCube(_idCube, _price, true);
                _cubeList.Add(_cubeObject);
                Console.Write("\nYour --service cube-- has been added. ");
            }

            Console.Write("Press <enter> to continue...");

            Console.ReadLine();
        }
        public void UpdateCube()
        {
            int _idCubeToUpdate;
            Console.Clear();
            if (_cubeList.Count == 0) // check if the cube list is empty 
            { // mesaage of empty list
                Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");
            }
            else
            { // list cubes
                _cubeObject.List(_cubeList);
                Console.WriteLine("Update cube's information: \n");
                Console.WriteLine("List of registered cubes: \n");
                foreach (Cube item in _cubeList)
                {
                    Console.WriteLine($"{item.ToString()}");
                }
                Console.Write("\nSelect the cube number to update: ");
                _idCubeToUpdate = Int16.Parse(Console.ReadLine());
                _cubeIndex = _cubeList.FindIndex(a => a.GetIdCube() == _idCubeToUpdate); //find index

                if (_cubeIndex == -1)  // check if input is greater than list count
                {
                    Console.Write("\nNot a valid input! Try again. ");
                }
                else
                {
                    //Console.WriteLine(_cubeList[_cubeIndex].GetType());
                    if (_cubeList[_cubeIndex].GetType().ToString() == "FinalProject.ProductCube")
                    {
                        Console.Write($"What is the price for cube #{_cubeList[_cubeIndex].GetIdCube()}? ");
                    }
                    else
                    {
                        Console.Write($"What is the price for cube #{_cubeList[_cubeIndex].GetIdCube()} (Service cube will increase 8.25% tax)? ");
                    }

                    _price = double.Parse(Console.ReadLine());
                    _cubeList[_cubeIndex].SetPrice(_price);
                    Console.Write($"\nThe cube #{_cubeIndex} has been updated! ");
                }

            }
            Console.Write("Press <enter> to continue... ");

            Console.ReadLine();
        }
        public void RentCube()
        {
            int _idOwnerToRent;
            int _idCubeToRent;
            int _ownerIndex;
            Console.Clear();
            Console.WriteLine("Rent a cube: \n");
            _cubeObject.List(_cubeList);
            if (_cubeList.Count == 0) // check if the cube list is empty 
            { // mesaage of empty list
                Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");
            }
            else
            { // list cubes
                Console.WriteLine("List of available cubes: \n");
                //cubeList.Sort(cubeObject._idCube);
                foreach (Cube item in _cubeList)
                {
                    if (item.IsAvailable() == true)
                    {
                        Console.WriteLine($"{item.ToString()}");
                    }
                }
                Console.Write("\nChoose the cube's number you want to rent: ");
                _idCubeToRent = Int16.Parse(Console.ReadLine());
                _cubeIndex = _cubeList.FindIndex(a => a.GetIdCube() == _idCubeToRent);

                if (_cubeIndex == -1)  // check if input is greater than list count
                {
                    Console.Write("\nNot a valid input! Try again. ");
                }
                else
                {
                    if (_cubeList[_cubeIndex].IsAvailable() == false)
                    {
                        Console.Write($"\nThe cube #{_idCubeToRent} is not available! Actually is rented by {_cubeList[_cubeIndex].GetIdOwner()} Choose another one. Press <enter> to continue...");

                    }
                    else
                    {
                        if (_ownerList.Count == 0) // check if the owner list is empty 
                        { // mesaage of empty list
                            Console.WriteLine("Your owners list is empty! Add a product/service cube from the Cube Menu.");
                        }
                        else
                        { // list owners
                            Console.WriteLine("\nList of registered owners: \n");
                            _ownerList.Sort(delegate (Person x, Person y)
                            {
                                return x.GetId().CompareTo(y.GetId()); // sort by Id
                            });
                            foreach (Person item in _ownerList)
                            {
                                Console.WriteLine($"{item.ToString()}");
                            }
                            Console.Write($"\nChoose the owner's Id who wants to rent cube #{_idCubeToRent}: ");
                            _idOwnerToRent = Int16.Parse(Console.ReadLine());
                            _ownerIndex = _ownerList.FindIndex(a => a.GetId() == _idOwnerToRent);

                            if (_ownerIndex == -1)
                            {
                                Console.Write("\nNot a valid input! Try again. ");

                            }
                            else
                            {
                                //Console.WriteLine(_cubeList[_cubeIndex].GetType().ToString());
                                if (_cubeList[_cubeIndex].GetType().ToString() == "FinalProject.ServiceCube")
                                {
                                    Console.Write($"\nEnter the service name for cube #{_idCubeToRent}: ");
                                    string _serviceName = Console.ReadLine();
                                    _cubeList[_cubeIndex].AddService(_serviceName);
                                }

                                _cubeList[_cubeIndex].AddOwner(_ownerList[_ownerIndex].GetId());
                                Console.Write($"\nThe cube #{_idCubeToRent} is now rented by {_ownerList[_ownerIndex].GetName()}. Press <enter> to continue...");

                            }

                        }
                    }



                }
            }
            Console.ReadLine();
        }
        public void ReleaseCube()
        {
            int _idCubeToRelease;
            Console.Clear();
            Console.WriteLine("Release a cube: \n");
            //_cubeObject.List(_cubeList);

            if (_cubeList.Count == 0) // check if the cube list is empty 
                Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");// mesaage of empty list
            else
            { // list cubes
                Console.WriteLine("List of available cubes: \n");
                int _cubesToRelease=0;
                foreach (Cube item in _cubeList)
                {
                    if (item.IsAvailable() == false)
                    {
                        Console.WriteLine($"{item.ToString()}");
                        _cubesToRelease++;
                    }
                }
                if (_cubesToRelease == 0)
                    Console.Write("\nThere are no cubes to realease!");
                else
                {
                    Console.Write("\nChoose the cube's id you want to release: ");
                    _idCubeToRelease = Int16.Parse(Console.ReadLine());
                    _cubeIndex = _cubeList.FindIndex(a => a.GetIdCube() == _idCubeToRelease);
                    if (_cubeIndex == -1)  // check if input is greater than list count
                        Console.Write("\nNot a valid input! Try again. ");
                    else
                    {
                        if (_cubeList[_cubeIndex].IsAvailable() == true)
                            Console.Write($"\nCube #{_idCubeToRelease} is aready available! No need to release. ");
                        else
                        {
                            _cubeList[_cubeIndex].Release();
                            Console.Write($"The cube #{_idCubeToRelease} is now available!.");
                        }
                    }
                }
            }
            Console.Write(" Press <enter> to continue...");
            Console.ReadLine();

        }
        public void DeleteCube()
        {
            int _idCubeToDelete;
            Console.Clear();
            _cubeObject.List(_cubeList);

            if (_cubeList.Count == 0) // check if the cube list is empty 
                Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");// mesaage of empty list
            else
            { // list cubes
                Console.WriteLine("Delete cube's information: \n");
                Console.WriteLine("List of registered cubes: \n");
                //cubeList.Sort(cubeObject._idCube);
                foreach (Cube item in _cubeList)
                {
                    if (item.IsAvailable() == true)
                        Console.WriteLine($"{item.ToString()}");
                }
                Console.Write("\nChoose the cube's number to delete: ");
                _idCubeToDelete = Int16.Parse(Console.ReadLine());
                _cubeIndex = _cubeList.FindIndex(a => a.GetIdCube() == _idCubeToDelete); //find index

                if (_cubeIndex == -1)  // check if input is greater than list count
                    Console.Write("\nNot a valid input! Try again. ");
                else
                {
                    if (_cubeList[_cubeIndex].IsAvailable() == false)
                    {
                        Console.WriteLine($"\nThe cube #{_idCubeToDelete} can not be deleted! Cube must be available before deleting.");
                        Console.WriteLine($"{_cubeList[_cubeIndex].ToString()} \n");
                    }
                    else
                    {
                        _cubeList.RemoveRange(_cubeIndex, 1);
                        Console.Write($"\nThe cube information has been deleted! ");
                    }

                }
            }
            Console.Write("Press <enter> to continue... ");
            Console.ReadLine();
        }
        public void ListCubes()
        {
            Console.Clear();
            if (_cubeList.Count == 0) // check if the cube list is empty 
            { // mesaage of empty list
                Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");
            }
            else
            { // list cubes
                _cubeObject.List(_cubeList);
                Console.WriteLine("List of registered cubes: \n");
                foreach (Cube item in _cubeList)
                {
                    Console.WriteLine($"{item.ToString()}");
                }
            }
            Console.Write("\nPress <enter> to continue...");
            Console.ReadLine();
        }
        public void AddProduct(string option)
        {
            if (option == "new")
            {
                Console.Clear();
                Console.WriteLine("Register a general product.\n");
            }
            else
            {
                Console.WriteLine("\nType the new information for this product.\n");

            }

            Console.Write("What is the brand of the product: ");
            _brand = Console.ReadLine();
            Console.Write("What is the name of the product: ");
            _name = Console.ReadLine();
            Console.Write($"Type a brief description for {_brand} {_name}: ");
            _description = Console.ReadLine();
            Console.Write($"What is the price for {_brand} {_name}: ");
            _price = double.Parse(Console.ReadLine());
            Console.Write($"What is the stock for {_brand} {_name}: ");
            _stock = Int16.Parse(Console.ReadLine());
            _productObject = new Product(_brand, _name, _description, _price, _stock);
            _productList.Add(_productObject);
            if (option == "new")
            {
                Console.Write($"\nYour -- {_brand} {_name} -- has been registered!. Press <enter> to continue...");
                Console.ReadLine();
            }

        }
        public void AddService(string option)
        {
            if (option == "new")
            {
                Console.Clear();
                Console.WriteLine("Register a service.\n");
            }
            else
            {
                Console.WriteLine("\nType the new information for this service.\n");

            }
            Console.Write("What is the service's name: ");
            _name = Console.ReadLine();
            Console.Write($"Type a brief description for {_name}: ");
            _description = Console.ReadLine();
            Console.Write($"What is the provider's name for {_name}: ");
            _provider = Console.ReadLine();
            Console.Write($"What is the price for {_name}: ");
            _price = double.Parse(Console.ReadLine());
            _productObject = new Service(_name, _description, _price, _provider);
            _productList.Add(_productObject);
            if (option == "new")
            {
                Console.Write($"\nYour -- {_name} -- service has been registered!. Press <enter> to continue...");
                Console.ReadLine();
            }
        }
        public void AddClothes(string option)
        {
            if (option == "new")
            {
                Console.Clear();
                Console.WriteLine("Register new clothes.\n");
            }
            else
            {
                Console.WriteLine("\nType the new information for this clothes.\n");

            }
            Console.Write("What is the brand of the clothes: ");
            _brand = Console.ReadLine();
            Console.Write("What is the clothes' name: ");
            _name = Console.ReadLine();
            Console.Write($"Type a brief description for {_brand} {_name}: ");
            _description = Console.ReadLine();
            Console.Write($"What is the size for {_brand} {_name} (xs|s|m|l|xl|xxl): ");
            _size = Console.ReadLine().ToUpper();
            Console.Write($"What is the price for {_brand} {_name}: ");
            _price = double.Parse(Console.ReadLine());
            Console.Write($"What is the stock for {_brand} {_name}: ");
            _stock = Int16.Parse(Console.ReadLine());
            _productObject = new Clothes(_name, _description, _brand, _price, _stock, _size);
            _productList.Add(_productObject);
            if (option == "new")
            {
                Console.Write($"\nYour -- {_brand} {_name} -- has been registered!. Press <enter> to continue...");
                Console.ReadLine();
            }
        }
        public void AddCosmetic(string option)
        {
            if (option == "new")
            {
                Console.Clear();
                Console.WriteLine("Register new cosmetic.\n");
            }
            else
            {
                Console.WriteLine("\nType the new information for this cosmetic.\n");

            }
            Console.Write("What is the brand of the cosmetic: ");
            _brand = Console.ReadLine();
            Console.Write("What is the cosmetic's name: ");
            _name = Console.ReadLine();
            Console.Write($"Type a brief description for {_brand} {_name}: ");
            _description = Console.ReadLine();
            Console.Write($"What is the quantity(ex. 100 ml) for {_brand} {_name}: ");
            _quantity = Console.ReadLine();
            Console.Write($"What is the price for {_brand} {_name}: ");
            _price = double.Parse(Console.ReadLine());
            Console.Write($"What is the stock for {_brand} {_name}: ");
            _stock = Int16.Parse(Console.ReadLine());
            _productObject = new Cosmetic(_name, _description, _brand, _price, _stock, _quantity);
            _productList.Add(_productObject);
            if (option == "new")
            {
                Console.Write($"\nYour -- {_brand} {_name} -- cosmetic has been registered!. Press <enter> to continue...");
                Console.ReadLine();
            }
        }
        public void AddFood(string option)
        {
            if (option == "new")
            {
                Console.Clear();
                Console.WriteLine("Register new food.\n");
            }
            else
            {
                Console.WriteLine("\nType the new information for this food.\n");

            }
            Console.Write("What is the brand of the food: ");
            _brand = Console.ReadLine();
            Console.Write("What is the food's name: ");
            _name = Console.ReadLine();
            Console.Write($"Type a brief description for {_brand} {_name}: ");
            _description = Console.ReadLine();
            Console.Write($"What is the due date(ex. Jan 1, 2009) for {_brand} {_name}: ");
            _bestBy = DateTime.Parse(Console.ReadLine());
            Console.Write($"What is the price for {_brand} {_name}: ");
            _price = double.Parse(Console.ReadLine());
            Console.Write($"What is the stock for {_brand} {_name}: ");
            _stock = Int16.Parse(Console.ReadLine());
            _productObject = new Food(_name, _description, _brand, _price, _stock, _bestBy);
            _productList.Add(_productObject);
            if (option == "new")
            {
                Console.Write($"\nYour -- {_brand} {_name} -- food has been registered!. Press <enter> to continue...");
                Console.ReadLine();
            }
        }
        public void ListProducts()
        {
            Console.Clear();

            if (_productList.Count == 0)
            {
                Console.Write("\nThe are no registered products! ");
            }
            else
            {
                _productList.Sort(delegate (Product x, Product y)
            {
                return x.GetName().CompareTo(y.GetName());
            });

                Console.WriteLine("Products & services list:\n");
                foreach (Product item in _productList)
                {
                    Console.WriteLine($"{item.ToString()}");
                }
            }

            Console.Write("\nPress <enter> to continue... ");
            Console.ReadLine();
        }
        public void DeleteProduct()
        {
            Console.Clear();

            Console.WriteLine("Delete a product/service. Products list:\n");
            if (_productList.Count == 0)
            {
                Console.Write("\nThe are no registered products!");
            }
            else
            {
                _productList.Sort(delegate (Product x, Product y)
                {
                    return x.GetName().CompareTo(y.GetName());
                });
                int _counter = 1;
                foreach (Product item in _productList)
                {
                    Console.WriteLine($"{_counter}. {item.ToString()}");
                    _counter++;
                }
                Console.Write("\nChoose the list number to delete: ");
                int _idProductToDelete = Int16.Parse(Console.ReadLine());
                if (_idProductToDelete > _productList.Count)  // check if input is greater than list count
                {
                    Console.Write("\nNot a valid input! Try again. ");
                }
                else
                {
                    _idProductToDelete--;
                    _productList.RemoveRange(_idProductToDelete, 1);
                    Console.Write($"\nThe product/service information has been deleted! ");
                }
            }


            Console.Write("Press <enter> to continue... ");
            Console.ReadLine();
        }
        public void UpdateProduct()
        {
            Console.Clear();
            _productList.Sort(delegate (Product x, Product y)
            {
                return x.GetName().CompareTo(y.GetName());
            });
            Console.WriteLine("\nUpdate product/service information. Products list:\n");
            if (_productList.Count == 0)
            {
                Console.Write("\nThe are no registered products! ");
            }
            else
            {
                int _counter = 1;
                foreach (Product item in _productList)
                {
                    Console.WriteLine($"{_counter}. {item.ToString()}");
                    _counter++;
                }
                Console.Write("\nSelect the list number to update: ");
                int _idProductToUpdate = Int16.Parse(Console.ReadLine());
                if (_idProductToUpdate > _productList.Count)  // check if input is greater than list count
                {
                    Console.Write("\nNot a valid input! Try again. ");
                }
                else
                {
                    _idProductToUpdate--;
                    switch (_productList[_idProductToUpdate].GetType().ToString())
                    {
                        case "FinalProject.Product":
                            Console.WriteLine($"\nOriginal information ---{_productList[_idProductToUpdate].ToString()}---");
                            _productList.RemoveRange(_idProductToUpdate, 1);
                            AddProduct("update");
                            break;
                        case "FinalProject.Clothes":
                            Console.WriteLine($"\nOriginal information ---{_productList[_idProductToUpdate].ToString()}---");
                            _productList.RemoveRange(_idProductToUpdate, 1);
                            AddClothes("update");
                            break;
                        case "FinalProject.Food":
                            Console.WriteLine($"\nOriginal information ---{_productList[_idProductToUpdate].ToString()}---");
                            _productList.RemoveRange(_idProductToUpdate, 1);
                            AddFood("update");
                            break;
                        case "FinalProject.Cosmetic":
                            Console.WriteLine($"\nOriginal information ---{_productList[_idProductToUpdate].ToString()}---");
                            _productList.RemoveRange(_idProductToUpdate, 1);
                            AddCosmetic("update");
                            break;
                        case "FinalProject.Service":
                            Console.WriteLine($"\nOriginal information ---{_productList[_idProductToUpdate].ToString()}---");
                            _productList.RemoveRange(_idProductToUpdate, 1);
                            AddService("update");
                            break;
                        default:
                            break;
                    }

                    Console.Write("\nThe information has been updated! ");
                }
            }

            Console.Write("Press <enter> to continue... ");
            Console.ReadLine();
        }
        public void AssignProduct()
        {
            int _idCubeToAssign;
            int _cubeIndex;
            Console.Clear();
            Console.WriteLine("Assign a product/service to a cube:");
            if (_cubeList.Count == 0) // check if the cube list is empty 
            { // mesaage of empty list
                Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");
            }
            else
            { // list cubes
                _cubeObject.List(_cubeList);
                Console.WriteLine("\nList of registered cubes: \n");
                int counter = 0;
                foreach (Cube item in _cubeList)
                {
                    if (item.IsAvailable() == false)
                    {
                        Console.WriteLine($"{item.ToString()}");
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    Console.Write("Sorry! Cubes must be rented by an owner before add a product! ");
                }
                else
                {
                    Console.Write("\nChoose the cube's number you want to assign: ");
                    _idCubeToAssign = Int16.Parse(Console.ReadLine());
                    _cubeIndex = _cubeList.FindIndex(a => a.GetIdCube() == _idCubeToAssign);
                    if (_cubeIndex == -1)
                    {
                        Console.Write("\nNot a valid input!. Try again. ");
                    }
                    else
                    {
                        if (_productList.Count == 0)
                        {
                            Console.Write("\nThe are no registered products! ");
                        }
                        else
                        {
                            if (_cubeList[_cubeIndex].IsAvailable() == true)
                            {
                                Console.Write($"Sorry! Cube #{_idCubeToAssign} must be rented by an owner before add a product! ");

                            }
                            else
                            {
                                _productList.Sort(delegate (Product x, Product y)
                                                            {
                                                                return x.GetName().CompareTo(y.GetName());
                                                            });

                                Console.WriteLine("Products & services list:\n");
                                int _counter = 1;
                                foreach (Product item in _productList)
                                {
                                    Console.WriteLine($"{_counter}. {item.ToString()}");
                                    _counter++;
                                }
                                Console.Write($"\nSelect the product number you want to assign to cube #{_idCubeToAssign}: ");
                                int _idProductToAssign = Int16.Parse(Console.ReadLine());
                                if (_idProductToAssign > _productList.Count || _idProductToAssign < 1)
                                {
                                    Console.Write("\nThe product number is not valid! Try again. ");
                                }
                                else
                                {
                                    _productList[_idProductToAssign].AssignCube(_idCubeToAssign);
                                    Console.Write($"\nThe product number {_idProductToAssign} has been assigned to the cube #{_idCubeToAssign}. ");

                                }
                            }

                        }
                    }
                }

            }
            Console.Write("Press <enter> to continue...");
            Console.ReadLine();

        }
        public void AddCustomer()
        {
            Console.Clear();
            Console.WriteLine("Register a customer: \n");
            Console.Write($"What is the id for {_name}? ");
            _idCustomer = Int16.Parse(Console.ReadLine());
            Console.Write("What is the customer's name? ");
            _name = Console.ReadLine();

            Console.Write($"What is the {_name}'s email? ");
            _email = Console.ReadLine();
            Console.Write($"What is the {_name}'s phone number? ");
            _phone = Console.ReadLine();


            _customerObject = new Customer(_idCustomer, _name, _email, _phone);
            _customerList.Add(_customerObject);
            Console.Write($"\n{_name}-- has been registered as customer. Press <enter> to continue...");
            Console.ReadLine();
        }
        public void ListCustomer()
        {
            Console.Clear();

            if (_customerList.Count == 0) // check if the owner list is empty 
            { // mesaage of empty list
                Console.WriteLine("Your customers list is empty! Add acustomers from the customers Menu.");
            }
            else
            { // list owners
                Console.WriteLine("List of registered customers: \n");
                _customerList.Sort(delegate (Person x, Person y)
                {
                    return x.GetName().CompareTo(y.GetName());
                });
                _counter = 1;
                foreach (Person item in _customerList)
                {
                    Console.WriteLine($"{_counter}. {item.ToString()}");
                    _counter++;
                }

            }
            Console.Write("\nPress <enter> to continue... ");
            Console.ReadLine();
        }
        public void UpdateCustomer()
        {
            Console.Clear();

            if (_customerList.Count == 0) // check if the owner list is empty 
            { // mesaage of empty list
                Console.WriteLine("Your customers list is empty! Add acustomers from the customers Menu.");
            }
            else
            { // list owners
                Console.WriteLine("List of registered customers: \n");
                _customerList.Sort(delegate (Person x, Person y)
                {
                    return x.GetName().CompareTo(y.GetName());
                });
                _counter = 1;
                foreach (Person item in _customerList)
                {
                    Console.WriteLine($"{_counter}. {item.ToString()}");
                    _counter++;
                }

            }

            Console.Write("\nPress <enter> to continue... ");
            Console.ReadLine();
        }
        public void DeleteCustomer()
        {
            Console.Clear();

            if (_customerList.Count == 0) // check if the owner list is empty 
            { // mesaage of empty list
                Console.WriteLine("Your customers list is empty! Add acustomers from the customers Menu.");
            }
            else
            { // list owners
                Console.WriteLine("List of registered customers: \n");
                _customerList.Sort(delegate (Person x, Person y)
                {
                    return x.GetName().CompareTo(y.GetName());
                });
                _counter = 1;
                foreach (Person item in _customerList)
                {
                    Console.WriteLine($"{_counter}. {item.ToString()}");
                    _counter++;
                }

            }

            Console.Write("\nPress <enter> to continue... ");
            Console.ReadLine();
        }
        public void AddOwner()
        {
            Console.Clear();
            Console.WriteLine("Register an owner: \n");
            Console.Write($"What is the Id for this owner? ");
            _idOwner = Int16.Parse(Console.ReadLine());
            _ownerIndex = _ownerList.FindIndex(a => a.GetId() == _idOwner); //find index
            if (_ownerIndex != -1)
            {
                Console.Write($"\nThe Id({_idOwner}) is already in use by {_ownerList[_ownerIndex].GetName()}! Please choose another Id. ");
                Console.Write("Press <enter> to continue...");
                Console.ReadLine();
                AddOwner();
            }
            else
            {
                Console.Write("What is the owner's name? ");
                _name = Console.ReadLine();
                Console.Write($"What is the {_name}'s email? ");
                _email = Console.ReadLine();
                Console.Write($"What is the {_name}'s phone number? ");
                _phone = Console.ReadLine();
                _ownerObject = new Owner(_idOwner, _name, _email, _phone);
                _ownerList.Add(_ownerObject);
                Console.Write($"\n{_name} has been registered as owner and is able to rent a cube. Press <enter> to continue...");
                Console.ReadLine();
            }

        }
        public void ListOwners()
        {
            Console.Clear();

            if (_ownerList.Count == 0) // check if the owner list is empty 
            { // mesaage of empty list
                Console.WriteLine("Your owners list is empty! Register a new owner from te owner's menu.");
            }
            else
            { // list owners
                Console.WriteLine("List of registered owners: \n");
                _ownerList.Sort(delegate (Person x, Person y)
                {
                    return x.GetId().CompareTo(y.GetId());
                });
                foreach (Person item in _ownerList)
                {
                    Console.WriteLine($"{item.ToString()}");
                }

            }
            Console.Write("\nPress <enter> to continue... ");
            Console.ReadLine();
        }
        public void UpdateOwner()
        {
            int _idOwnerToUpdate;
            Console.Clear();

            if (_ownerList.Count == 0) // check if the owner list is empty 
                Console.WriteLine("Your owners list is empty! Register a new owner from te owner's menu.");// mesaage of empty list
            else
            { // list owners
                Console.WriteLine("List of registered owners: \n");
                _ownerList.Sort(delegate (Person x, Person y)
                {
                    return x.GetId().CompareTo(y.GetId());
                });
                foreach (Person item in _ownerList)
                {
                    Console.WriteLine($"{item.ToString()}");
                }
                Console.Write("\nSelect the owner's Id to update: ");
                _idOwnerToUpdate = Int16.Parse(Console.ReadLine());
                _ownerIndex = _ownerList.FindIndex(a => a.GetId() == _idOwnerToUpdate);
                if (_ownerIndex == -1) // check if Id was found
                    Console.Write("\nNot a valid input! Try again. ");
                else
                {
                    Console.Write("\nWhat is the new owner's name? ");
                    _name = Console.ReadLine();
                    Console.Write($"What is the new {_name}'s email? ");
                    _email = Console.ReadLine();
                    Console.Write($"What is the new {_name}'s phone number? ");
                    _phone = Console.ReadLine();
                    _ownerList[_ownerIndex].SetData(_name, _email, _phone);
                    Console.Write("\nThe owner's information has been updated! ");
                }

            }
            Console.Write("Press <enter> to continue... ");
            Console.ReadLine();
        }
        public void DeleteOwner()
        {
            int _idOwnerToDelete;
            Console.Clear();

            if (_ownerList.Count == 0) // check if the owner list is empty 
                Console.WriteLine("Your owners list is empty! Register a new owner from te owner's menu.");// mesaage of empty list
            else
            { // list owners
                Console.WriteLine("List of registered owners: \n");
                _ownerList.Sort(delegate (Person x, Person y)
                {
                    return x.GetId().CompareTo(y.GetId());
                });
                foreach (Person item in _ownerList)
                {
                    Console.WriteLine($"{item.ToString()}");
                }
                Console.Write("\nSelect the owner's Id to delete: ");
                _idOwnerToDelete = Int16.Parse(Console.ReadLine());
                _ownerIndex = _ownerList.FindIndex(a => a.GetId() == _idOwnerToDelete);
                if (_ownerIndex == -1)  // check if input is greater than list count
                    Console.Write("\nNot a valid input! Try again. ");
                else
                {
                    _cubeIndex = _cubeList.FindIndex(a => a.GetIdOwner() == _idOwnerToDelete);
                    if (_cubeIndex == -1)
                    {
                        _ownerList.RemoveRange(_ownerIndex, 1);
                        Console.Write($"\nThe owner information has been deleted! ");
                    }
                    else
                        Console.Write($"\nThis owner can not be deleted because one o more cubes are rented by him/her! ");
                }
            }
            Console.Write("Press <enter> to continue... ");
            Console.ReadLine();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
