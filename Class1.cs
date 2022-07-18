using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSVQ
{
    public class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postal { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }

    }
    public class CSV
    {
        List<People> Qresults = new List<People>();
        public bool Read(string file)
        {
            var content = File.ReadLines(file);
            if (content == null) { return false; }
            int lines = 0;
            foreach (string line in content) 
            {
                
                if (lines == 0) { lines++; continue; }
                List<string> row = Decouple(line);
                People people = new People();

                people.Id = lines;
                people.FirstName = row[0];
                people.LastName = row[1];
                people.Company = row[2];
                people.Address = row[3];
                people.City = row[4];
                people.County = row[5];
                people.Postal = row[6];
                people.Phone1 = row[7];
                people.Phone2 = row[8];
                people.Email = row[9];
                people.Web = row[10];

                Qresults.Add(people);
                lines++;
            }
            
            return true;
        }
        public List<string> Decouple(string arg,string delimit=",")
        {
            
            string[] arr = arg.Split(delimit);
            List<string> results=new List<string> { };
            int ConcatStartIdx=-1;
            int flag = -1;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == string.Empty) { flag = 1; continue; }
                if (arr[i].StartsWith("\"")) { flag = 1; ConcatStartIdx = i; }
                if (arr[i].EndsWith("\"") && ConcatStartIdx!=-1)
                {
                    results.Add(Concat(arr[ConcatStartIdx..i]));
                    flag = 1;
                }
                if (flag == -1) { results.Add(arr[i]); }
            }
            if(flag == 1)
            {
                return results;
            }
            results=arr.ToList<string>();
            return results;

        }
        public string Concat(string[] args)
        {
            string str = string.Concat(args);
            str = str.Replace("\"", String.Empty).Trim();
            return str;
        }

        public List<People> Person_has_Esq_in_company()
        {
            List<People> results=Qresults.FindAll(delegate(People pp)
            {
               return pp.Company.Contains("Esq");
            });
            return results;
        }

        public List<People> Person_lives_in_Derbyshire()
        {
            List<People> results = Qresults.FindAll(delegate (People pp)
            {
                return pp.City.ToLower().Contains("derbyshire");
            });
            return results;
        }
        public List<People> Person_house_number_equals_3()
        {
            List<People> results = Qresults.FindAll(delegate (People pp)
            {
                return pp.Address.Split()[0].Length==3;
            });
            return results;
        }

        public List<People> Person_website_longer_than_35()
        {
            List<People> results = Qresults.FindAll(delegate (People pp)
            {
                return pp.Web.Length>35;
            });
            return results;
        }

        public List<People> Person_lives_in_specific_postcode()
        {
            List<People> results = Qresults.FindAll(delegate (People pp)
            {
                string area = pp.Postal.Split()[0];
                return Char.IsLetter(area[area.Length-1]) && !Char.IsLetter(area[area.Length - 2]);
            });
            return results;
        }

        public List<People> Person_phone1_larger_than_phone2()
        {
            List<People> results = Qresults.FindAll(delegate (People pp)
            {
                int phone1 = (int)Convert.ToInt64(pp.Phone1.Replace('-', '0'));
                int phone2 = (int)Convert.ToInt64(pp.Phone2.Replace('-', '0'));
                return phone1>phone2;
            });
            return results;
        }

        public void display(List<People> args)
        {
            args.ForEach(i => Console.WriteLine(
                "{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}",
                args.Id,
                args.FirstName,
                args.LastName,
                args.Company,
                args.Address,
                args.City,
                args.County,
                args.Postal,
                args.Phone1,
                args.Phone2,
                args.Email,
                args.Web));
        }
        public void Main()
        {
            Console.WriteLine("Please insert filter ID:");
            string? n=Console.ReadLine();
            if (n != null)
            {
                switch (n)
                {
                    case "1":

                }

            }
            
        }

    }

    
}
