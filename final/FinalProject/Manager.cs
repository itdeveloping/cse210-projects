using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Manager
    {
        int _counter;
        int _idCube;
        double _price;
        List<Cube> _cubeList = new List<Cube>();
        Cube _cubeObject;

        List<Cube> _rentedCubes = new List<Cube>();


        List<Product> _productList = new List<Product>();
        Product _productObject;
        List<Person> _customerList = new List<Person>();
        Person _customerObject;
        List<Person> _ownerList = new List<Person>();
        Person _ownerObject;
        public Manager()
        {
            //add owners samples
            _ownerObject = new Owner("Oscar Rodriguez", "oscar@gmail.com", "8342158421", 3);
            _ownerList.Add(_ownerObject);
            _ownerObject = new Owner("Mercedes Ramirez", "mercedes@gmail.com", "8342158422", 1);
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
        }

        public void AddProductCube()
        {
            Console.Clear();
            Console.WriteLine("Add a product cube: \n");
            Console.Write("What is the number of the cube? ");
            _idCube = Int16.Parse(Console.ReadLine());
            Console.Write($"What is the price for cube #{_idCube}? ");
            _price = double.Parse(Console.ReadLine());

            _cubeObject = new ProductCube(_idCube, _price, true);
            _cubeList.Add(_cubeObject);
            Console.Write("\nYour --product cube-- has been added. Press <enter> to continue...");
            Console.ReadLine();
        }
        public void AddServiceCube()
        {
            Console.Clear();

            Console.WriteLine("Add a service cube: \n");
            Console.Write("What is the number of the cube? ");
            _idCube = Int16.Parse(Console.ReadLine());
            Console.Write($"What is the price for cube #{_idCube}? ");
            _price = double.Parse(Console.ReadLine());
            _cubeObject = new ServiceCube(_idCube, _price, true);
            _cubeList.Add(_cubeObject);
            Console.Write("\nYour --service cube-- has been added. Press <enter> to continue...");
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
                _cubeList.Sort(delegate (Cube x, Cube y)
                {
                    return x._idCube.CompareTo(y._idCube);
                });
                Console.WriteLine("Update cube's information: \n");
                Console.WriteLine("List of registered cubes: \n");
                _counter = 1;
                foreach (Cube item in _cubeList)
                {
                    Console.WriteLine($"{_counter}. {item.ToString()}");
                    _counter++;
                }
                Console.Write("\nSelect the list number to update: ");
                _idCubeToUpdate = Int16.Parse(Console.ReadLine());
                if (_idCubeToUpdate > _cubeList.Count)  // check if input is greater than list count
                {
                    Console.Write("\nNot a valid input! Try again. ");
                }
                else
                {
                    _idCubeToUpdate--;

                    Console.Write("What is the number of the cube? ");
                    _idCube = Int16.Parse(Console.ReadLine());
                    Console.Write($"What is the price for cube #{_idCube}? ");
                    _price = double.Parse(Console.ReadLine());
                    _cubeList[_idCubeToUpdate]._idCube = _idCube;
                    _cubeList[_idCubeToUpdate]._price = _price;
                    Console.Write("\nYour --service cube-- has been updated! ");
                }

            }
            Console.Write("Press <enter> to continue... ");

            Console.ReadLine();
        }
        public void RentCube()
        {
            int _idOwnerToRent;
            int _idCubeToRent;
            int _cubeIndex;
            int _ownerIndex;
            Console.Clear();
            Console.WriteLine("Rent a cube: \n");
            _cubeList.Sort(delegate (Cube x, Cube y)
            {
                return x._idCube.CompareTo(y._idCube);
            });
            if (_cubeList.Count == 0) // check if the cube list is empty 
            { // mesaage of empty list
                Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");
            }
            else
            { // list cubes
                Console.WriteLine("List of registered cubes: \n");
                //cubeList.Sort(cubeObject._idCube);
                foreach (Cube item in _cubeList)
                {
                    if (item.IsAvailable() == true)
                    {
                        Console.WriteLine($"{item.ToString()}");
                    }
                }
                Console.Write("\nChoose the cube number you want to rent: ");
                _idCubeToRent = Int16.Parse(Console.ReadLine());
                _cubeIndex = _cubeList.FindIndex(a => a._idCube == _idCubeToRent);
                if (_cubeIndex == -1)  // check if input is greater than list count
                {
                    Console.Write("\nNot a valid input! Try again. ");
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
                            return x._name.CompareTo(y._name);
                        });
                        foreach (Person item in _ownerList)
                        {
                            Console.WriteLine($"{item.ToString()}");
                        }
                        Console.Write($"\nChoose the owner's Id who wants to rent cube #{_idCubeToRent}: ");
                        _idOwnerToRent = Int16.Parse(Console.ReadLine());
                        _ownerIndex = _ownerList.FindIndex(a => a._id == _idOwnerToRent);

                        if (_ownerIndex == -1)
                        {
                            Console.Write("\nNot a valid input! Try again. ");

                        }
                        else
                        {
                            Console.WriteLine(_cubeList[_cubeIndex].GetType().ToString());
                            if (_cubeList[_cubeIndex].GetType().ToString()== "ConsoleApp2.ProductCube")
                            {
                                Console.Write("Enter the service name: ");
                                string _serviceName=Console.ReadLine();
                                _cubeList[_cubeIndex].AddService(_serviceName);
                            }

                            _cubeList[_cubeIndex].AddOwner(_ownerList[_ownerIndex]._name);
                            Console.Write($"\nThe cube #{_idCubeToRent} is now rented by {_ownerList[_ownerIndex]._name}. Press <enter> to continue...");

                        }

                    }

                }
            }
            Console.ReadLine();
        }
        public void DeleteCube()
        {
            int _idCubeToDelete;
            Console.Clear();
            _cubeList.Sort(delegate (Cube x, Cube y)
            {
                return x._idCube.CompareTo(y._idCube);
            });
            if (_cubeList.Count == 0) // check if the cube list is empty 
            { // mesaage of empty list
                Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");
            }
            else
            { // list cubes
                Console.WriteLine("Delete cube's information: \n");
                Console.WriteLine("List of registered cubes: \n");
                //cubeList.Sort(cubeObject._idCube);
                _counter = 1;
                foreach (Cube item in _cubeList)
                {
                    Console.WriteLine($"{_counter}. {item.ToString()}");
                    _counter++;
                }
                Console.Write("\nChoose the list number to delete: ");
                _idCubeToDelete = Int16.Parse(Console.ReadLine());
                if (_idCubeToDelete > _cubeList.Count)  // check if input is greater than list count
                {
                    Console.Write("\nNot a valid input! Try again. ");
                }
                else
                {
                    _idCubeToDelete--;
                    _cubeList.RemoveRange(_idCubeToDelete, 1);
                    Console.Write($"\nThe cube information has been deleted! ");
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
                _cubeList.Sort(delegate (Cube x, Cube y)
                {
                    return x._idCube.CompareTo(y._idCube);
                });

                Console.WriteLine("List of registered cubes: \n");
                _counter = 1;
                foreach (Cube item in _cubeList)
                {
                    Console.WriteLine($"{_counter}. {item.ToString()}");
                    _counter++;
                }
            }
            Console.Write("\nPress <enter> to continue...");
            Console.ReadLine();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
