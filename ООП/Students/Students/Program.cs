using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ИСУ ВУЗ \"ТИСБИ\" v1.0");
            Console.WriteLine("Нажмите \"Enter\" для начала работы");
            //SendKeys.SendWait("{ENTER}");
            Console.ReadKey();
            int exit =0;
            double k1 =0, k2=0, k3=0, mark;
            string fam, name, fath, res;
            Student student1 = new Student();
            Student student2 = new Student();
            Student student3 = new Student();
            while (exit != 1)
            {
                Console.WriteLine();
                Console.WriteLine("Меню группы ПИ-922");
                Console.WriteLine();
                Console.WriteLine("1.Добавить студента");
                Console.WriteLine("2.Добавить оценку студенту");
                Console.WriteLine("3.Изменить оценку студенту");
                Console.WriteLine("4.Запрос оценки студента");
                Console.WriteLine("5.Подсчет среднего балла студента");
                Console.WriteLine("6.Вывод всех данных о студенте");
                Console.WriteLine("7.Завершить работу");
                Console.WriteLine();
                Console.WriteLine("Ваше действие: ");
                int menu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                
                switch (menu)
                {
                    case 1:
                        if (student1.Name1 == null)
                        {
                            Console.WriteLine("Студентов в группе нет. Добавляем информацию о первом студенте");
                            Console.Write("Введите фамилию студента: ");
                            fam = Console.ReadLine();
                            Console.Write("Введите имя студента: ");
                            name = Console.ReadLine();
                            Console.Write("Введите отчество студента: ");
                            fath = Console.ReadLine();
                            Console.WriteLine("Студент записан");
                            student1.addStud(fam, name, fath);
                        } else if (student2.Name1 == null)
                        {
                            Console.WriteLine("В группе есть один студент. Добавляем информацию о втором студенте");
                            Console.Write("Введите фамилию студента: ");
                            fam = Console.ReadLine();
                            Console.Write("Введите имя студента: ");
                            name = Console.ReadLine();
                            Console.Write("Введите отчество студента: ");
                            fath = Console.ReadLine();
                            Console.WriteLine("Студент записан");
                            student2.addStud(fam, name, fath);
                        } else if (student3.Name1 == null)
                        {
                            Console.WriteLine("В группе двое студентов. Добавляем информацию о третьем студенте");
                            Console.Write("Введите фамилию студента: ");
                            fam = Console.ReadLine();
                            Console.Write("Введите имя студента: ");
                            name = Console.ReadLine();
                            Console.Write("Введите отчество студента: ");
                            fath = Console.ReadLine();
                            Console.WriteLine("Студент записан");
                            student3.addStud(fam, name, fath);
                        }
                        else
                        {
                            Console.WriteLine("В группе максимальное кол-во студентов!");
                        }
                        Console.Write("Нажмите Enter для продолжения");
                        Console.ReadKey();
                        Console.Clear(); 
                    break;

                    case 2:
                        Console.Write("Введите фамилию студента:");
                        fam = Console.ReadLine();
                        Console.Write("Введите имя студента:");
                        name = Console.ReadLine();
                        Console.Write("Введите отчество студента:");
                        fath = Console.ReadLine();
                        if (fam == student1.FirstName1 & name == student1.Name1 & fath == student1.FatherName1)
                        {
                            int markMenu;
                            Console.WriteLine();
                            Console.WriteLine("По какому предмету поставить оценку?");
                            Console.WriteLine();
                            Console.WriteLine("1.Программирование");
                            Console.WriteLine("2.Математика");
                            Console.WriteLine("3.Физ.культура");
                            Console.WriteLine();
                            Console.Write("Ваш выбор:");
                            markMenu = Convert.ToInt32(Console.ReadLine());
                            if (markMenu == 1)
                            {
                                if (student1.MarkProgram == 0)
                                {
                                    Console.Write("Введите оценку:");
                                    mark = Convert.ToDouble(Console.ReadLine());
                                    student1.addMark(markMenu, mark);
                                    k1++;
                                }
                                else if (student1.MarkProgram != 0)
                                {
                                    Console.WriteLine("Оценка за этот предмет у студента уже стоит. Попробуйте изменить её в соответсвующем меню");
                                }
                            } else if (markMenu == 2)
                            {
                                if (student1.MarkMath == 0)
                                {
                                    Console.Write("Введите оценку:");
                                    mark = Convert.ToDouble(Console.ReadLine());
                                    student1.addMark(markMenu, mark);
                                    k1++;
                                }
                                else if (student1.MarkMath != 0)
                                {
                                    Console.WriteLine("Оценка за этот предмет у студента уже стоит. Попробуйте изменить её в соответсвующем меню");
                                }
                            } else if (markMenu == 3)
                            {
                                if (student1.MarkSport == 0)
                                {
                                    Console.Write("Введите оценку:");
                                    mark = Convert.ToDouble(Console.ReadLine());
                                    student1.addMark(markMenu, mark);
                                    k1++;
                                }
                                else if (student1.MarkSport != 0)
                                {
                                    Console.WriteLine("Оценка за этот предмет у студента уже стоит. Попробуйте изменить её в соответсвующем меню");
                                }
                            }
                            
                        }
                        else if (fam == student2.FirstName1 & name == student2.Name1 & fath == student2.FatherName1)
                        {
                            int markMenu;
                            Console.WriteLine();
                            Console.WriteLine("По какому предмету поставить оценку?");
                            Console.WriteLine();
                            Console.WriteLine("1.Программирование");
                            Console.WriteLine("2.Математика");
                            Console.WriteLine("3.Физ.культура");
                            Console.WriteLine();
                            Console.Write("Ваш выбор:");
                            markMenu = Convert.ToInt32(Console.ReadLine());
                            if (markMenu == 1)
                            {
                                if (student2.MarkProgram == 0)
                                {
                                    Console.Write("Введите оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student2.addMark(markMenu, mark);
                                    k2++;
                                }
                                else if (student2.MarkProgram != 0)
                                {
                                    Console.WriteLine("Оценка за этот предмет у студента уже стоит. Попробуйте изменить её в соответсвующем меню");
                                }
                            }
                            else if (markMenu == 2)
                            {
                                if (student2.MarkMath == 0)
                                {
                                    Console.Write("Введите оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student2.addMark(markMenu, mark);
                                    k2++;
                                }
                                else if (student2.MarkMath != 0)
                                {
                                    Console.WriteLine("Оценка за этот предмет у студента уже стоит. Попробуйте изменить её в соответсвующем меню");
                                }
                            }
                            else if (markMenu == 3)
                            {
                                if (student2.MarkSport == 0)
                                {
                                    Console.Write("Введите оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student1.addMark(markMenu, mark);
                                    k2++;
                                }
                                else if (student2.MarkSport != 0)
                                {
                                    Console.WriteLine("Оценка за этот предмет у студента уже стоит. Попробуйте изменить её в соответсвующем меню");
                                }
                            }
                        
                        }
                        else if (fam == student3.FirstName1 & name == student3.Name1 & fath == student3.FatherName1)
                        {
                            int markMenu;
                            Console.WriteLine();
                            Console.WriteLine("По какому предмету поставить оценку?");
                            Console.WriteLine();
                            Console.WriteLine("1.Программирование");
                            Console.WriteLine("2.Математика");
                            Console.WriteLine("3.Физ.культура");
                            Console.WriteLine();
                            Console.Write("Ваш выбор:");
                            markMenu = Convert.ToInt32(Console.ReadLine());
                            if (markMenu == 1)
                            {
                                if (student3.MarkProgram == 0)
                                {
                                    Console.Write("Введите оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student3.addMark(markMenu, mark);
                                    k3++;
                                }
                                else if (student3.MarkProgram != 0)
                                {
                                    Console.WriteLine("Оценка за этот предмет у студента уже стоит. Попробуйте изменить её в соответсвующем меню");
                                }
                            }
                            else if (markMenu == 2)
                            {
                                if (student3.MarkMath == 0)
                                {
                                    Console.Write("Введите оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student3.addMark(markMenu, mark);
                                    k3++;
                                }
                                else if (student3.MarkMath != 0)
                                {
                                    Console.WriteLine("Оценка за этот предмет у студента уже стоит. Попробуйте изменить её в соответсвующем меню");
                                }
                            }
                            else if (markMenu == 3)
                            {
                                if (student3.MarkSport == 0)
                                {
                                    Console.Write("Введите оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student3.addMark(markMenu, mark);
                                    k3++;
                                }
                                else if (student3.MarkSport != 0)
                                {
                                    Console.WriteLine("Оценка за этот предмет у студента уже стоит. Попробуйте изменить её в соответсвующем меню");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Студент с такой фамилией не учится в ТИСБИ");
                        }
                        Console.Write("Нажмите Enter для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 3:
                        Console.Write("Введите фамилию студента:");
                        fam = Console.ReadLine();
                        Console.Write("Введите имя студента:");
                        name = Console.ReadLine();
                        Console.Write("Введите отчество студента:");
                        fath = Console.ReadLine();
                        if (fam == student1.FirstName1 & name == student1.Name1 & fath == student1.FatherName1)
                        {
                            int markMenu;
                            Console.WriteLine();
                            Console.WriteLine("По какому предмету изменить оценку?");
                            Console.WriteLine();
                            Console.WriteLine("1.Программирование");
                            Console.WriteLine("2.Математика");
                            Console.WriteLine("3.Физ.Культура");
                            Console.WriteLine();
                            Console.Write("Ваш выбор:");
                            markMenu = Convert.ToInt32(Console.ReadLine());
                            if (markMenu == 1)
                            {
                                if (student1.MarkProgram == 0)
                                {
                                    Console.WriteLine("Невозможно изменить оценку. Оценка за этот предмет не была проставлена \nПоставьте оценку в соответсвующем меню");
                                }
                                else
                                {
                                    Console.Write("Введите новую оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student1.changeMark(markMenu, mark);
                                }
                            }
                            else if (markMenu == 2)
                            {
                                if (student1.MarkMath == 0)
                                {
                                    Console.WriteLine("Невозможно изменить оценку. Оценка за этот предмет не была проставлена \nПоставьте оценку в соответсвующем меню");
                                }
                                else
                                {
                                    Console.Write("Введите новую оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student1.changeMark(markMenu, mark);
                                }
                            }
                            else if (markMenu == 3)
                            {
                                if (student1.MarkSport == 0)
                                {
                                    Console.WriteLine("Невозможно изменить оценку. Оценка за этот предмет не была проставлена \nПоставьте оценку в соответсвующем меню");
                                }
                                else
                                {
                                    Console.Write("Введите новую оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student1.changeMark(markMenu, mark);
                                }
                            }
                        }
                        else if (fam == student2.FirstName1 & name == student2.Name1 & fath == student2.FatherName1)
                        {
                            int markMenu;
                            Console.WriteLine();
                            Console.WriteLine("По какому предмету изменить оценку?");
                            Console.WriteLine();
                            Console.WriteLine("1.Программирование");
                            Console.WriteLine("2.Математика");
                            Console.WriteLine("3.Физ.Культура");
                            Console.WriteLine();
                            Console.Write("Ваш выбор:");
                            markMenu = Convert.ToInt32(Console.ReadLine());
                            if (markMenu == 1)
                            {
                                if (student2.MarkProgram == 0)
                                {
                                    Console.WriteLine("Невозможно изменить оценку. Оценка за этот предмет не была проставлена \nПоставьте оценку в соответсвующем меню");
                                }
                                else
                                {
                                    Console.Write("Введите новую оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student2.changeMark(markMenu, mark);
                                }
                            }
                            else if (markMenu == 2)
                            {
                                if (student2.MarkMath == 0)
                                {
                                    Console.WriteLine("Невозможно изменить оценку. Оценка за этот предмет не была проставлена \nПоставьте оценку в соответсвующем меню");
                                }
                                else
                                {
                                    Console.Write("Введите новую оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student2.changeMark(markMenu, mark);
                                }
                            }
                            else if (markMenu == 3)
                            {
                                if (student2.MarkSport == 0)
                                {
                                    Console.WriteLine("Невозможно изменить оценку. Оценка за этот предмет не была проставлена \nПоставьте оценку в соответсвующем меню");
                                }
                                else
                                {
                                    Console.Write("Введите новую оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student2.changeMark(markMenu, mark);
                                }
                            }
                        }
                        else if (fam == student3.FirstName1 & name == student3.Name1 & fath == student3.FatherName1)
                        {
                            int markMenu;
                            Console.WriteLine();
                            Console.WriteLine("По какому предмету изменить оценку?");
                            Console.WriteLine();
                            Console.WriteLine("1.Программирование");
                            Console.WriteLine("2.Математика");
                            Console.WriteLine("3.Физ.Культура");
                            Console.WriteLine();
                            Console.Write("Ваш выбор:");
                            markMenu = Convert.ToInt32(Console.ReadLine());
                            if (markMenu == 1)
                            {
                                if (student3.MarkProgram == 0)
                                {
                                    Console.WriteLine("Невозможно изменить оценку. Оценка за этот предмет не была проставлена \nПоставьте оценку в соответсвующем меню");
                                }
                                else
                                {
                                    Console.Write("Введите новую оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student3.changeMark(markMenu, mark);
                                }
                            }
                            else if (markMenu == 2)
                            {
                                if (student3.MarkMath == 0)
                                {
                                    Console.WriteLine("Невозможно изменить оценку. Оценка за этот предмет не была проставлена \nПоставьте оценку в соответсвующем меню");
                                }
                                else
                                {
                                    Console.Write("Введите новую оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student3.changeMark(markMenu, mark);
                                }
                            }
                            else if (markMenu == 3)
                            {
                                if (student3.MarkSport == 0)
                                {
                                    Console.WriteLine("Невозможно изменить оценку. Оценка за этот предмет не была проставлена \nПоставьте оценку в соответсвующем меню");
                                }
                                else
                                {
                                    Console.Write("Введите новую оценку:");
                                    mark = Convert.ToInt32(Console.ReadLine());
                                    student3.changeMark(markMenu, mark);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Студент с такой фамилией не учится в ТИСБИ");
                        }
                        Console.Write("Нажмите Enter для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 4:
                        Console.Write("Введите фамилию студента:");
                        fam = Console.ReadLine();
                        Console.Write("Введите имя студента:");
                        name = Console.ReadLine();
                        Console.Write("Введите отчество студента:");
                        fath = Console.ReadLine();
                        if (fam == student1.FirstName1 & name == student1.Name1 & fath == student1.FatherName1)
                        {
                            int reqMarkMenu;
                            Console.WriteLine();
                            Console.WriteLine("По какому предмету вы хотите узнать оценку?");
                            Console.WriteLine();
                            Console.WriteLine("1.Программирование");
                            Console.WriteLine("2.Математика");
                            Console.WriteLine("3.Физ.Культура");
                            Console.WriteLine();
                            Console.Write("Ваш выбор:");
                            reqMarkMenu = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Оценка:");
                            res = Convert.ToString(student1.requestMark(reqMarkMenu));
                            Console.WriteLine(res);
                        }
                        else if (fam == student2.FirstName1 & name == student2.Name1 & fath == student2.FatherName1)
                        {
                            int reqMarkMenu;
                            Console.WriteLine();
                            Console.WriteLine("По какому предмету вы хотите узнать оценку?");
                            Console.WriteLine();
                            Console.WriteLine("1.Программирование");
                            Console.WriteLine("2.Математика");
                            Console.WriteLine("3.Физ.Культура");
                            Console.WriteLine();
                            Console.Write("Ваш выбор:");
                            reqMarkMenu = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Оценка:");
                            res = Convert.ToString(student2.requestMark(reqMarkMenu));
                            Console.WriteLine(res);
                        }
                        else if (fam == student3.FirstName1 & name == student3.Name1 & fath == student3.FatherName1)
                        {
                            int reqMarkMenu;
                            Console.WriteLine();
                            Console.WriteLine("По какому предмету вы хотите узнать оценку?");
                            Console.WriteLine();
                            Console.WriteLine("1.Программирование");
                            Console.WriteLine("2.Математика");
                            Console.WriteLine("3.Физ.Культура");
                            Console.WriteLine();
                            Console.Write("Ваш выбор:");
                            reqMarkMenu = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Оценка:");
                            res = Convert.ToString(student3.requestMark(reqMarkMenu));
                            Console.WriteLine(res);
                        }
                        else
                        {
                            Console.WriteLine("Студент с такой фамилией не учится в ТИСБИ");
                        }
                        Console.Write("Нажмите Enter для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 5:
                        Console.Write("Введите фамилию студента:");
                        fam = Console.ReadLine();
                        Console.Write("Введите имя студента:");
                        name = Console.ReadLine();
                        Console.Write("Введите отчество студента:");
                        fath = Console.ReadLine();
                        if (fam == student1.FirstName1 & name == student1.Name1 & fath == student1.FatherName1)
                        {
                            if (student1.MarkMath == 0 & student1.MarkProgram == 0 & student1.MarkSport == 0)
                            {
                                Console.WriteLine("У студента нет оценок");
                            }
                            else
                            {
                                Console.Write("Средний бал студента: ");
                                res = Convert.ToString(student1.averageMark(k1));
                                Console.WriteLine(res);
                            }
                        }
                        else if (fam == student2.FirstName1 & name == student2.Name1 & fath == student2.FatherName1)
                        {
                            if (student2.MarkMath == 0 & student2.MarkProgram == 0 & student2.MarkSport == 0)
                            {
                                Console.WriteLine("У студента нет оценок");
                            }
                            else
                            {
                                Console.Write("Средний бал студента: ");
                                res = Convert.ToString(student1.averageMark(k1));
                                Console.WriteLine(res);
                            }
                        }
                        else if (fam == student3.FirstName1 & name == student3.Name1 & fath == student3.FatherName1)
                        {
                            if (student3.MarkMath == 0 & student3.MarkProgram == 0 & student3.MarkSport == 0)
                            {
                                Console.WriteLine("У студента нет оценок");
                            }
                            else
                            {
                                Console.Write("Средний бал студента: ");
                                res = Convert.ToString(student1.averageMark(k1));
                                Console.WriteLine(res);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Студент с такой фамилией не учится в ТИСБИ");
                        }
                        Console.Write("Нажмите Enter для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 6:
                        Console.Write("Введите фамилию студента:");
                        fam = Console.ReadLine();
                        Console.Write("Введите имя студента:");
                        name = Console.ReadLine();
                        Console.Write("Введите отчество студента:");
                        fath = Console.ReadLine();
                        if (fam == student1.FirstName1 & name == student1.Name1 & fath == student1.FatherName1)
                        {
                            res = student1.infoStudent(k1);
                            Console.WriteLine(res);
                        }
                        else if (fam == student2.FirstName1 & name == student2.Name1 & fath == student2.FatherName1)
                        {
                            res = student2.infoStudent(k2);
                            Console.WriteLine(res);
                        }
                        else if (fam == student3.FirstName1 & name == student3.Name1 & fath == student3.FatherName1)
                        {
                            res = student3.infoStudent(k3);
                            Console.WriteLine(res);
                        }
                        else
                        {
                            Console.WriteLine("Студент с такой фамилией не учится в ТИСБИ");
                        }
                        Console.Write("Нажмите Enter для продолжения");
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case 7:
                        exit = 1;
                    break;
                }
            }
        }
    }
}
