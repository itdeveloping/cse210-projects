using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    public class FileManager
    {
        protected List<Goal> _goalList;
        public FileManager()
        {
        }
        public void WriteFile(List<Goal> goalList, int score, string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {

                outputFile.WriteLine(score);

                foreach (Goal myGoal in goalList)
                {
                    outputFile.WriteLine($"{myGoal.StringToFile()}");
                }
            }

        }
    }

}
