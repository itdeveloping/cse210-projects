using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Menu
    {
        protected List<string> _option = new List<string>();
        protected string _fileName;
        protected string _description;
        public Menu(string filename, string description)
        {
            _fileName = filename;
            _description = description;
        }
        protected void FillMenu()
        {
            // read all options from a text file to fill _option list
            string[] option = File.ReadAllLines(_fileName);
            _option.Clear();
            foreach (string line in option)
                _option.Add($"{line}");
        }
        public virtual void DisplayMenu()
        {
            
            FillMenu();
            Console.Clear();
            Console.WriteLine($"\n{_description}\n");
            foreach (string option in _option)
            {
                Console.WriteLine(option);
            }

        }

    }
}
