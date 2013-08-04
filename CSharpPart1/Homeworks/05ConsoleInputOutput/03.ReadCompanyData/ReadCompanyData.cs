using System;

    class ReadCompanyData
    {
        static void Main()
        {
            string[] companyInfo = {"Name: ", "Address: ", "Phone number: ", "Fax number: ", "Web site: "};
            string[] managerInfo = {"First name: ", "Last name: ", "Age: ", "Phone number: "};
            string dataInput;
            //int charPosition = 0;
            int count =0;

            foreach (string field in companyInfo)
            {
                //charPosition = field.IndexOf(":");
                Console.Write("Please enter company's {0}", field);
                dataInput = Console.ReadLine();
                companyInfo[count] = field + dataInput;
                count++;
            }
            count = 0;
            Console.WriteLine();

            foreach (string field in managerInfo)
            {
                //charPosition = field.IndexOf(":");
                Console.Write("Please enter manager's {0}", field);
                dataInput = Console.ReadLine();
                managerInfo[count] = field + dataInput;
                count++;
            }
            
            Console.WriteLine("\nCompany data: \n");
            foreach (string field in companyInfo)
            {
                Console.WriteLine(field);
            }
            
            Console.WriteLine("\nManager data: \n");
            foreach (string field in managerInfo)
            {
                Console.WriteLine(field);
            }
        }

    } 

