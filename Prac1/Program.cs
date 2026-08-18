using System;

namespace CollegeAdmission
{
    class StudentAdmission
    {
        private string name;
        private string qualification;
        private int marks;
        private int age;

        public string SelectedProgram { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string RegistrationNumber { get; set; }
        public string ERNumber { get; set; }


        public StudentAdmission(string studentName, string qualificationType, int obtainedMarks, int studentAge)
        {
            name = studentName;
            qualification = qualificationType;
            marks = obtainedMarks;
            age = studentAge;
        }


        public void PrintDetails()
        {
            Console.WriteLine("\n===== Admission Details =====");
            Console.WriteLine("Registration No.   : " + RegistrationNumber);
            Console.WriteLine("ER Number           : " + ERNumber);
            Console.WriteLine("Student Name        : " + name);
            Console.WriteLine("Age                 : " + age);
            Console.WriteLine("Qualification       : " + qualification);
            Console.WriteLine("Marks Obtained      : " + marks);
            Console.WriteLine("Selected Program    : " + SelectedProgram);
            Console.WriteLine("Phone Number        : " + PhoneNumber);
            Console.WriteLine("Email               : " + Email);
        }
    }


    class AdmissionProcess
    {
        private string collegeName = "ABC Engineering College";


        public void ShowPrograms()
        {
            Console.WriteLine("\nAvailable Programs:");
            Console.WriteLine("1. Computer Science");
            Console.WriteLine("2. Electronics Engineering");
            Console.WriteLine("3. Artificial Intelligence");
            Console.WriteLine("4. Data Science");
        }


        public string GenerateRegistrationNumber()
        {
            Random random = new Random();
            return "REG" + random.Next(1000, 9999);
        }


        public string GenerateERNumber()
        {
            Random random = new Random();
            return "ER" + random.Next(10000, 99999);
        }


        public bool CheckEligibility(int marks)
        {
            return marks >= 50;
        }


        public void ProcessAdmission(StudentAdmission student)
        {
            student.RegistrationNumber = GenerateRegistrationNumber();
            student.ERNumber = GenerateERNumber();

            Console.WriteLine("\nCollege Name: " + collegeName);
            Console.WriteLine("Admission Application Submitted Successfully!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AdmissionProcess admission = new AdmissionProcess();

            Console.WriteLine("***** Student Admission Management System *****");


            admission.ShowPrograms();


            Console.Write("\nEnter Student Name: ");
            string studentName = Console.ReadLine();


            Console.Write("Enter Age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Please enter a valid age: ");
            }


            Console.Write("Enter Qualification: ");
            string qualification = Console.ReadLine();


            Console.Write("Enter Marks: ");
            int marks;
            while (!int.TryParse(Console.ReadLine(), out marks))
            {
                Console.Write("Please enter valid marks: ");
            }


            Console.Write("Enter Selected Program: ");
            string program = Console.ReadLine();


            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();


            Console.Write("Enter Email Address: ");
            string email = Console.ReadLine();



            StudentAdmission student = new StudentAdmission(
                studentName,
                qualification,
                marks,
                age
            );


            student.SelectedProgram = program;
            student.PhoneNumber = phone;
            student.Email = email;


            if (admission.CheckEligibility(marks))
            {
                admission.ProcessAdmission(student);
                student.PrintDetails();
            }
            else
            {
                Console.WriteLine("\nAdmission Failed: Minimum 50% marks required.");
            }


            Console.WriteLine("\nThank you for using Admission Portal.");
            Console.ReadKey();
        }
    }
}