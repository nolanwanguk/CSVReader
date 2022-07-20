using System.Globalization;
using CSVQ.Filters;
using System.Text;
using CSVQ.Utility;

namespace CSVQ.Model;

public record Person(string first_name, string last_name, string company_name, string address, string city,
    string county, string postal, string phone1, string phone2, string email, string web)
{
    internal string FirstName = first_name;
    internal string LastName = last_name;
    internal string Company = company_name;
    internal string Address = address;
    internal string City = city;
    internal string County = county;
    internal string Postal = postal;
    internal string Email = email;
    internal string Web = web;
    internal int Phone1 = ReFormat.Phone_To_Num(phone1);
    internal int Phone2 = ReFormat.Phone_To_Num(phone2);
}