using System.Globalization;
using CSVQ.Filters;
using System.Text;
using CSVQ.Utility;

namespace CSVQ.Model;
/// <summary>
/// Record model for default input.csv file
/// </summary>
/// <param name="first_name">same as column name as in input.csv</param>
/// <param name="last_name">same as column name as in input.csv</param>
/// <param name="company_name">same as column name as in input.csv</param>
/// <param name="address">same as column name as in input.csv</param>
/// <param name="city">same as column name as in input.csv</param>
/// <param name="county">same as column name as in input.csv</param>
/// <param name="postal">same as column name as in input.csv</param>
/// <param name="phone1">same as column name as in input.csv</param>
/// <param name="phone2">same as column name as in input.csv</param>
/// <param name="email">same as column name as in input.csv</param>
/// <param name="web">same as column name as in input.csv</param>
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
    internal int Phone1 = ReFormat.Phone_To_Num(phone1); // convert to int in order to compare numbers 
    internal int Phone2 = ReFormat.Phone_To_Num(phone2); // convert to int in order to compare numbers 
}