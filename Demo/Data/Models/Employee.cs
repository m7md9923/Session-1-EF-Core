using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Data.Models;

// Entity / Poco Class Model / Domain Model ==> pain old Clr / C# obj 
// Entity ==> DB [Table]

[Table("EmployeesTable")]
internal class Employee
{
    // PK ==> public numeric prop ==> Id, EmployeeId ==> PK Identity Constraint [1 : 1] 
    [Key]
    public int EmployeeId { get; set; }
    
    // is mapped to string ==> nVarChar(max)
    // nullable ==> allow null ==> col optional
    
    [Required]  // can not make it Null
    [MaxLength(50 , ErrorMessage = "Name is too long")]
    [MinLength(10)] // --> not mapped to DB [server side validation] 
    
    // [StringLength(50, MinimumLength = 10)]
    public string? Name { get; set; }
    // Value type ==> decimal ==> required ==> not allow null 
    // decimal ==> map to decimal (18,2)
    
    [DataType(DataType.Currency)] // to display the currency format
    public decimal Salary { get; set; }
    // Value type ==> int ==> required ==> Not allow Null 
    // int ==> map to int
    // [AllowedValues(10, 20, 30, 40, 50)]
    // [Range(10, 50)]
    // [DeniedValues(1, 2, 3)]
    [DataType(DataType.PhoneNumber)] // to display the phone num in the phone format
    public int Age { get; set; }
    

    
    // class Helper, 
    // {
    //     
    // }
    
}