using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWorkerService.Contacts;

namespace MyWorkerService.Services
{
    public class MyService : IMyService
    {
        private readonly IConfiguration _configuration;

        public MyService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void PrintSecret()
        {
            Console.WriteLine($"Message : Hello World! This is Md Hasan Monsur");
        }
    }
}
