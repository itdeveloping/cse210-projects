using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Manager
    {
        int _idCube;
        double _price;
        int _cubeIndex;
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
                Console.Write("\nChoose the cube number you want to rent: ");
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
                        Console.Write($"\nThe cube #{_idCubeToRent} is not available! Actually is rented by {_cubeList[_cubeIndex].GetOwnerName()} Choose another one. Press <enter> to continue...");

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
                                //Console.WriteLine(_cubeList[_cubeIndex].GetType().ToString());
                                if (_cubeList[_cubeIndex].GetType().ToString() == "FinalProject.ServiceCube")
                                {
                                    Console.Write($"\nEnter the service name for cube #{_idCubeToRent}: ");
                                    string _serviceName = Console.ReadLine();
                                    _cubeList[_cubeIndex].AddService(_serviceName);
                                }

                                _cubeList[_cubeIndex].AddOwner(_ownerList[_ownerIndex]._name);
                                Console.Write($"\nThe cube #{_idCubeToRent} is now rented by {_ownerList[_ownerIndex]._name}. Press <enter> to continue...");

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
            _cubeObject.List(_cubeList);

            if (_cubeList.Count == 0) // check if the cube list is empty 
            { // mesaage of empty list
                Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");
            }
            else
            { // list cubes
                Console.WriteLine("List of available cubes: \n");
                //cubeList.Sort(cubeObject._idCube);
                int _cubesToRelease = 0;
                foreach (Cube item in _cubeList)
                {
                    if (item.IsAvailable() == false)
                    {
                        Console.WriteLine($"{item.ToString()}");
                        _cubesToRelease++;
                    }
                }
                if (_cubesToRelease == 0)
                {
                    Console.Write("There are no cubes to realease!");
                }
                else
                {
                    Console.Write("\nChoose the cube's number you want to release: ");
                    _idCubeToRelease = Int16.Parse(Console.ReadLine());
                    _cubeIndex = _cubeList.FindIndex(a => a.GetIdCube() == _idCubeToRelease);
                    if (_cubeIndex == -1)  // check if input is greater than list count
                    {
                        Console.Write("\nNot a valid input! Try again. ");
                    }
                    else
                    {
                        _cubeList[_cubeIndex].Release();
                        Console.Write($"The cube #{_idCubeToRelease} is now available!.");
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
            { // mesaage of empty list
                Console.WriteLine("Your cube list is empty! Add a product/service cube from the Cube Menu.");
            }
            else
            { // list cubes
                Console.WriteLine("Delete cube's information: \n");
                Console.WriteLine("List of registered cubes: \n");
                //cubeList.Sort(cubeObject._idCube);
                foreach (Cube item in _cubeList)
                {
                    Console.WriteLine($"{item.ToString()}");
                }
                Console.Write("\nChoose the cube's number to delete: ");
                _idCubeToDelete = Int16.Parse(Console.ReadLine());
                _cubeIndex = _cubeList.FindIndex(a => a.GetIdCube() == _idCubeToDelete); //find index

                if (_cubeIndex == -1)  // check if input is greater than list count
                {
                    Console.Write("\nNot a valid input! Try again. ");
                }
                else
                {
                    _cubeList.RemoveRange(_cubeIndex, 1);
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
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
