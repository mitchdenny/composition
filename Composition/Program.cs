using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Composition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);

            var program = new Program();
            container.ComposeParts(program);

            program.Run();
        }

        [Import(typeof(ICustomerRepository))]
        public ICustomerRepository CustomerRepository { get; set; }

        public void Run()
        {
            AddSomeCustomers();
            PrintSomeCustomers();
        }

        private void PrintSomeCustomers()
        {
            foreach (var customer in CustomerRepository.All)
            {
                Console.WriteLine(customer);
            }
        }

        private void AddSomeCustomers()
        {
            CustomerRepository.Add(
                new Customer()
                {
                    ID = Guid.NewGuid(),
                    FirstName = "Homer",
                    LastName = "Simpson"
                }
                );

            CustomerRepository.Add(
                new Customer()
                {
                    ID = Guid.NewGuid(),
                    FirstName = "Marge",
                    LastName = "Simpson"
                }
                );

            CustomerRepository.Add(
                new Customer()
                {
                    ID = Guid.NewGuid(),
                    FirstName = "Bart",
                    LastName = "Simpson"
                }
                );

            CustomerRepository.Add(
                new Customer()
                {
                    ID = Guid.NewGuid(),
                    FirstName = "Lisa",
                    LastName = "Simpson"
                }
                );

            CustomerRepository.Add(
                new Customer()
                {
                    ID = Guid.NewGuid(),
                    FirstName = "Maggie",
                    LastName = "Simpson"
                }
                );
        }
    }
}
