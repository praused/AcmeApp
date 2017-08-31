using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        /// <summary>
        /// Retrieve all the approved vendors.
        /// </summary>
        /// <returns></returns>
        public List<Vendor> Retrieve()
        {
            if (vendors == null)
            {
                vendors = new List<Vendor>();

                vendors.Add(new Vendor() { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" });
                vendors.Add(new Vendor() { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" });
            }
            //Console.WriteLine(vendors[1]);

            for (int i = 0; i < vendors.Count; i++)
            {
                Console.WriteLine(vendors[i]);
            }

            foreach (var vendor in vendors)
            {
                Console.WriteLine(vendor);
            }

            return vendors;
        }

        /// <summary>
        /// Retrieve all the approved vendors.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Vendor> RetrieveWithKeys()
        {
            var vendors = new Dictionary<string, Vendor>()
            {
                { "ABC Corp", new Vendor() { VendorId = 5, CompanyName = "ABC Corp", Email = "abc@abc.com" }},
                { "XYZ Inc", new Vendor() { VendorId = 8, CompanyName = "XYZ Inc", Email = "xyz@xyz.com" }}
            };

            //Console.WriteLine(vendors);

            ////Iteration by Keys
            //foreach (var companyName in vendors.Keys)
            //{
            //    Console.WriteLine(companyName);
            //    Console.WriteLine(vendors[companyName]);
            //}

            ////Iteration by Values
            //foreach (var vendor in vendors.Values)
            //{
            //    Console.WriteLine(vendor);
            //}

            //Iteration by Element (key-value pairs) -- avoid because it is slower than iterating by keys or values
            foreach (var element in vendors)
            {
                var vendor = element.Value;
                var key = element.Key;
                Console.WriteLine($"Key: {key}, Value: {vendor}");
            }

            ////Looks up the vendor twice
            //if (vendors.ContainsKey("XYZ"))
            //{ 
            //    Console.WriteLine(vendors["XYZ"]);
            //}
            ////Looks up the vendor only once
            //Vendor vendor;
            //if(vendors.TryGetValue("XYZ", out vendor))
            //{
            //    Console.WriteLine(vendor);
            //}

            return vendors;
        }

        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            //Call the database to return a value (omitted)
            //If no value is returned, return the default value
            T value = defaultValue;

            return value;
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }
}
