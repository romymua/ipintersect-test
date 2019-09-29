/**
 * Romy Mua Tuuau
 * September 29 2019
 * Test Intersect Values from List
 * Ver. 1
 * Simple List and array intersect
 */


using System;
using System.Collections.Generic;
using System.Linq;

namespace IpAddressIntersectTest
{
    class Program
    {
        static void Main()
        {
            
            string[] array1 = { "192.168.1.1", "192.168.1.2", "192.168.1.3", "192.168.1.4" };
            string[] array2 = { "192.168.1.1", "192.168.1.3", "192.168.1.4", "192.168.1.5" };

            // Intersects IP addresses common to both lists
            var intersect = array1.Intersect(array2);

            // Create a list to hold list of intersected IPs
            List<string> ipBoth = new List<string>();

            foreach (string ip in intersect)
            {
                ipBoth.Add(ip);
            }

            
            // Join the strings to have an output of IPs in list format
            var result = String.Join(", ", ipBoth.ToArray());

            Console.WriteLine(result);


        }
    }
}
