using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Student_marks
{
    internal class Student
    {
        string name;
        int id;
        int T_marks;
        int H_marks;
        int E_marks;
        int M_marks;
        int Sc_marks;
        int S_marks;
        int Total_marks;
        int avg;
        public static void avg_marks(Student[] total)
        {
            for(int i = 0;i<total.Length;i++)
            {
                total[i].avg = total[i].Total_marks / 6;
            }
           
        }
        public static void total_marks(Student[] t)
        {
            for(int i = 0;i<t.Length;i++)
            {
                t[i].Total_marks = t[i].T_marks + t[i].H_marks + t[i].E_marks + t[i].M_marks + t[i].Sc_marks + t[i].S_marks;
                Console.WriteLine("Total marks {0}", t[i].Total_marks);
            }
            
        }
        public void grade(int avg)
        {
            if(avg>90)
            {
                Console.WriteLine("1st class");
            }
            else if(avg>70 && avg<90)
            {
                Console.WriteLine("2nd class");
            }
            else if(avg>40 && avg<70)
            {
                Console.WriteLine("3rd class");
            }
            else 
            {
                Console.WriteLine("failed");
            }
            
        }
        public static void input(Student[] st)
        {
            for (int i = 0; i < st.Length; i++)
            {
                st[i] = new Student();
                Console.WriteLine("Enter name");
                st[i].name = Console.ReadLine();
                Console.WriteLine("Enter id");
                st[i].id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter telugu marks");
                st[i].T_marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter hindi marks");
                st[i].H_marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter english marks");
                st[i].E_marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter maths marks");
                st[i].M_marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter science marks");
                st[i].Sc_marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter social marks");
                st[i].S_marks = Convert.ToInt32(Console.ReadLine());

            }
        }
            public static void display(Student[] d)
            {
                for (int i = 0; i < d.Length; i++)
                {
                Console.WriteLine("Student name{0}\n Student id{1}", d[i].name, d[i].id);
                Console.WriteLine("Telugu {0}\nHindi {1}\nEnglish {2}\nMaths {3}\nScience {4}\nSocial {5}",
                    d[i].T_marks, d[i].H_marks, d[i].E_marks, d[i].M_marks, d[i].Sc_marks, d[i].S_marks);                   
                }

            }
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number of students");
            int n=Convert.ToInt32(Console.ReadLine());
            Student[] s = new Student[n];
            while (true) {
                Console.WriteLine("enter the option number\n1)input  2)display  3)total marks 4)average marks");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Student.input(s);
                        break;
                    case 2: Student.display(s);
                        break;
                    case 3: Student.total_marks(s);
                        break;
                    case 4: Student.avg_marks(s);
                        break;
                    case 5: return;
    
            }
            }
           /* for (int i = 0; i < n; i++) {
                s[i] = new Student();
                Console.WriteLine("Enter name");
                s[i].name = Console.ReadLine();
                Console.WriteLine("Enter id");
                s[i].id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter telugu marks");
                s[i].T_marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter hindi marks");
                s[i].H_marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter english marks");
                s[i].E_marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter maths marks");
                s[i].M_marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter science marks");
                s[i].Sc_marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter social marks");
                s[i].S_marks = Convert.ToInt32(Console.ReadLine());
                s[i].Total_marks = s[i].total_marks(s[i].T_marks, s[i].H_marks, s[i].E_marks, s[i].M_marks,
                                   s[i].Sc_marks, s[i].S_marks);
                Console.WriteLine("Total marks: " + s[i].Total_marks);
                s[i].avg = s[i].avg_marks(s[i].Total_marks);
                Console.WriteLine("Average is: " + s[i].avg);
                s[i].grade(s[i].avg);
            }*/


        }
    }
}
