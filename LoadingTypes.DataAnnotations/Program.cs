using System.Diagnostics.Metrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadingTypes.DataAnnotations.Data;

namespace Bob
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dataContext = new DataContext();

            dataContext.SaveChanges();
        }
    }
}