using CSVQ.Utility;

namespace CSVQ.Model;

public record Person(int Id, string FirstName, string LastName, string Company, string Address, string City,
    string County, string Postal, string Phone1, string Phone2, string Email, string Web)
{
    public int[] PhoneNumbers { get; init; } =
        new int[2] { ReFormat.Phone_To_Num(Phone1), ReFormat.Phone_To_Num(Phone2) };
}