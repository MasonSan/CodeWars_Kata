using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace The_Supermarket_Queue
{
    [TestFixture]
    public class Kata
    {
        [Test]
        public void QueueTime_ExampleTest1()
        {
            long expected = 0;
            long actual = Kata.QueueTime(new int[] { }, 1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void QueueTime_ExampleTest2()
        {
            long expected = 10;
            long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4 }, 1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void QueueTime_ExampleTest3()
        {
            long expected = 9;
            long actual = Kata.QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void QueueTime_ExampleTest4()
        {
            long expected = 5;
            long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4, 5 }, 100);
            Assert.AreEqual(expected, actual);
        }

        public static long QueueTime(int[] customers, int n)
        {
            //var tillArray = new int[n];

            //for (var index = 0; index < customers.Length; index++)
            //{
            //    Array.Sort(tillArray);
            //    tillArray[0] += customers[index];
            //}

            //return tillArray.Max();

            var registers = new List<int>(Enumerable.Repeat(0, n));

            foreach (int cust in customers)
            {
                registers[registers.IndexOf(registers.Min())] += cust;
            }
            return registers.Max();
        }
    }
}