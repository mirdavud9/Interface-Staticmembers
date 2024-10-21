using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface__Static_members
{
    internal class Group
    {
            public static int GroupCount = 0;
            public int GroupId { get; set; }
            public string GroupName { get; set; }
            public Student[] Students = new Student[0];

            public Group(string groupName)
            {
                GroupCount++;
                GroupId = GroupCount;
                GroupName = groupName;
            }

            public void AddStudent(Student student)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }

            public void ShowStudents()
            {
                foreach (var student in Students)
                {
                    student.GetInfo();
                }
            }
        }

    }
