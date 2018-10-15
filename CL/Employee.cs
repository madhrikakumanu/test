using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CL
{
   public class Employee
    {
       int Employeeid;
       string lastName;    //  should be (20)  chars only
       string firstName;   //	should be (10)	chars only
       string title;       //	should be (30)	chars only
       string address;     //	should be (60)	chars only
       string city;        //	should be (15)	chars only
       string postalCode;  //	should be (10)	chars only
       string country;
       public int Employeeid
       {
           get
           {
               return employeeid;
           }
           set
           {
                employeeid = value;
           }
       }
       public string FirstName
       {
           get
           {
               return firstName;
           }
           set
           {
                firstName = value;
           }
       }
       public string Lastname
       {
           get
           {
               return lastName;
                   
           }
           set
           {
               lastName = value;
           }
       }
       public string Title
       {
           get
           {
               return title;

           }
           set
           {
               title = value;
           }
           

       }
       public string Address
       {
           get
           {
               return address;
           }
           set
           {
               address = value;
           }
       }
       public string City
       {
           get
           {
               return city;
           }
           set
           {
               city = value;
               
           }
       }
       public string PostalCode
       {
           get
           {
               return postalCode;
           }
           set
           {
               postalCode = value;
           }
       }
       public string Country
       {
           get
           {
               return country;
           }
           set
           {
               country = value;
           }
       }
}
}
