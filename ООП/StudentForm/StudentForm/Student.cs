using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        private string FirstName;
        private string Name;
        private string FatherName;

        private double markProgram = 0;
        private double markMath = 0;
        private double markSport = 0;

        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string FatherName1 { get => FatherName; set => FatherName = value; }
        public double MarkProgram { get => markProgram; set => markProgram = value; }
        public double MarkMath { get => markMath; set => markMath = value; }
        public double MarkSport { get => markSport; set => markSport = value; }

        public void addStud(string fam, string name, string fath)
        {
            FirstName1 = fam;
            Name1 = name;
            FatherName1 = fath;
        }


        public void addMark(int menu, double mark)
        {
            if (menu == 1)
            {
                MarkProgram = mark;
            } else if (menu == 2)
            {
                MarkMath = mark;
            } else if (menu == 3)
            {
                MarkSport = mark;
            }
        }

        public void changeMark(int menu, double mark)
        {
            if (menu == 1)
            {
                MarkProgram = mark;
            }
            else if (menu == 2)
            {
                MarkMath = mark;
            }
            else if (menu == 3)
            {
                MarkSport = mark;
            }
        }

        public double requestMark(int menu)
        {
            double mrk;
            if (menu == 1)
            {
                mrk = MarkProgram;
                return mrk;
            } else if (menu == 2)
            {
                mrk = MarkMath;
                return mrk;
            } else if (menu == 3)
            {
                mrk = MarkSport;
                return mrk;
            } else
            {
                mrk = 0;
                return mrk;
            }
        }

        public double averageMark(double k)
        {
            double mrk = (MarkProgram + MarkMath + MarkSport) / k;
            return mrk;
        }

        public string infoStudent(double k)
        {
            string info = "\n\nINFO\nСтудент группы ПИ-922 \n\nФИО: " + FirstName1 + " " + Name1 + " " + FatherName1 + "\n\nОценки\nПрограммирование: " + MarkProgram + "\nМатематика: " + MarkMath + "\nФиз.Культура: " + MarkSport + "\n\nСредний балл: " + averageMark(k);
            return info;
        }

    }
}
