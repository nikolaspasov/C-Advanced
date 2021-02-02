using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
       private List<Student> students;

        public int Capacity { get; set; }
        public int Count { get { return students.Count; } }

        //private Classroom()
        //{
        //    students = new List<Student>();
        //}
        public Classroom(int capacity)
            
        {
            Capacity = capacity;
            students = new List<Student>();
        }

        public string RegisterStudent(Student student)
        {
            if(students.Count<Capacity)
            {
                students.Add(student);
                return
                    $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return $"No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            Student studentToRemove = students.FirstOrDefault(
                x => x.FirstName == firstName
                && x.LastName == lastName);
            if(studentToRemove!=null)
            {
                students.Remove(studentToRemove);
                return $"Dismissed student {firstName} {lastName}";
            }
            return "Student not found";
        }
        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:");
            foreach (var student in students)
            {
                if(student.Subject==subject)
                {
                    sb.AppendLine(student.FirstName + " " + student.LastName);
                    count++;
                }
            }
            if(count==0)
            {
                return "No students enrolled for the subject";
            }
            return sb.ToString().Trim();
        }
        public int GetStudentsCount()
        {
            return students.Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(
                x => x.FirstName == firstName
                && x.LastName == lastName);
            return student;
        }

    }
}
