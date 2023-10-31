using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Student
    {
       
            public string Name { get; set; }
            public int Age { get; set; }

            public Student(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                runApp();
            }

            static void runApp()
            {
                Student[] students = {
            new Student("Balu", 20),
            new Student("Nani", 18),
            new Student("Charlie777", 22),
            new Student("Dolly", 19),
            new Student("Eve", 21)
        };
            Console.WriteLine("\tBubble Sort:");
            Console.WriteLine("\t");
                Console.WriteLine("Unsorted Students:");
                PrintStudents(students);

                BubbleSort(students);


                Console.WriteLine("\nSorted Students:");
                PrintStudents(students);
            Console.ReadLine(); 
            }

            static void BubbleSort(Student[] students)
            {
                int n = students.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (students[j].Age > students[j + 1].Age)
                        {
                            // Swap the students
                            Student temp = students[j];
                            students[j] = students[j + 1];
                            students[j + 1] = temp;
                        }
                    }
                }
            }

            static void PrintStudents(Student[] students)
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.Name}, Age: {student.Age}");
                }
            }
        }

    }

