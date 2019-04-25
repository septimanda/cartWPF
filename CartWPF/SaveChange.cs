using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartWPF
{
    class SaveChange
    {
        bool status = false;
        MyContext myContext = new MyContext();

        public SaveChange(MyContext context)
        {
            myContext = context;
        }

        public bool saved()
        {
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
                Console.WriteLine("Processed Successfully");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            return status;
        }
    }
}
