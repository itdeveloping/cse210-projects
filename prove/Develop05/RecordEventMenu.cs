using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    public class RecordEventMenu : Menu
    {
        public RecordEventMenu(List<string> options) : base(options)
        {


        }
        public override int Show()
        {
            return 1;
        }
    }

}
