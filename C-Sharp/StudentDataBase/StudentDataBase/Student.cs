using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace StudentDataBase
{
    public class Student
    {
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public byte[]  Photo { get; set; }
    public decimal Height { get; set; }
    public float Weight { get; set; }
        
    public Grade Grade { get; set; }
    }
}
