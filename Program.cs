// See https://aka.ms/new-console-template for more information
using Microsoft.IdentityModel.Tokens;
using System.Runtime.Intrinsics.Arm;
using testquery2fri;

Console.WriteLine("Hello, World!");



using (var context = new Entity())
{
    var query = context.Doctors.Select(d=>d.Name).ToList();



   // var query2 = context.Departments.Where(de => de.doctors.Average(de => de.YoxEeperience) > 10);
   foreach(var item in query)
    {
          Console.WriteLine(query);
    }



































}
    
   
         





























