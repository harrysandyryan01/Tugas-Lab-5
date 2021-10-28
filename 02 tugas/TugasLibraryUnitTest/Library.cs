using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class Library
    {
        private Library library;

        [SetUp]
        public void Init()
        {
            library = new Library();
        }

        [Test]
        public void DayTest()
        {
            Console.WriteLine("Senin");
            Console.WriteLine("Selasa");
            Console.WriteLine("Rabu");
            Console.WriteLine("Kamis");
            Console.WriteLine("Jumat");
            Console.WriteLine("Sabtu");
            Console.WriteLine("Minggu");
        }

        [Test]
        public void UserTest()
        {
            Console.WriteLine("Password = admin");
        }
    }
}
