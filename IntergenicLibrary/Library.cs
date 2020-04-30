using System;
using System.Collections.Generic;

namespace IntergenicLibrary
{
    public class Library : IDefaulterList
    {

         public Student StudentDetails{get; set;}
         public Book BookDetails{get; set;}
         public string DateIssuedDetails{get; set;}
         public string DateReturnedDetails{get; set;}
         public int dtiDate;
         public int dtrDate;
         public double DaysR;
         public Library(Student studentdetails, Book bookdetails, string dateIssuedDetails, string dateReturnedDetails)
        {
            StudentDetails = studentdetails;
            BookDetails = bookdetails;
            DateIssuedDetails = dateIssuedDetails;
            DateReturnedDetails = dateReturnedDetails;
        }

        public string GetName()
        {
            return $"Student Name:{StudentDetails.Name}";
        }

        public string GetYear()
        {
            return $"Student year:{StudentDetails.YrOfStudy}";
        }

        public string GetBook()
        {
            return $"Book name: {BookDetails.BookName}\nBook ID: {BookDetails.BookID}";
        }
       
        public string GetDateReturn()
        {
            System.DateTime dtiDate = Convert.ToDateTime(DateIssuedDetails);

            System.DateTime dtrDate = dtiDate.AddDays(+14);

            TimeSpan DateDifferent = dtrDate - dtiDate;

            double Days = DateDifferent.TotalDays;

            System.DateTime drDate = Convert.ToDateTime(DateReturnedDetails);

            TimeSpan DateReturnedDifferent = drDate - dtiDate;

            DaysR = DateReturnedDifferent.TotalDays;

            //Console.WriteLine($"The return date difference is {Days} and the day returned difference is {DaysR}");
            return $"The expected return date is: {dtrDate}";

        }
        public string GetDefaulter()
        {
            GetDateReturn();
            if(DaysR > 14)
            {
                return $"{GetName()} is a defaulter,hasn't returned {GetBook()} \n ";
            }
            return $"{GetName()} Is not a defaulter";
           
        }

        public override string ToString()
        {
            return $"{GetDefaulter()}";
        }
    }
}