using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Notebook> notes = new List<Notebook>();
            string procherk = "-----------------------------------------------------------";
            Console.WriteLine(procherk);
            Console.WriteLine("Приветствую в своей записной книжке!");
            //string log = "Логи отсутствуют!";
            // Console.WriteLine(log);
            //int it = 0;
            while (true)
            {

                Console.WriteLine(procherk);
                //Console.WriteLine();
                Console.WriteLine("Выберите, что вы хотите сделать (Введите цифру):");
                //Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("1 - New");
                Console.WriteLine("2 - Edit");
                Console.WriteLine("3 - Delete");
                Console.WriteLine("4 - View");
                Console.WriteLine("5 - View All");
                Console.WriteLine("6 - Change color");
                // Console.WriteLine("6 - Quit in programm");
                Console.WriteLine("-----------------------------------------------------------");

                Console.Write("Номер действия: ");
                string s = Console.ReadLine();
                //do

                // {
               

                if (s == "1")
                {
                    // it++;
                    Console.Clear();
                    Console.WriteLine(procherk);
                    Console.WriteLine("СОЗДАНИЕ НОВОЙ ЗАПИСИ");
                    Console.WriteLine(procherk);

                    string Surname;
                    string Name;
                    int Phone=0;
                    do
                    {
                        Console.Write("ФАМИЛИЯ (обязательно): ");
                        Surname = Console.ReadLine();
                    }
                    while (Surname == null||Surname=="");
                    /*if (Surname == null)
                    {
                        Surname = "Отсyтствует";
                    }*/
                    //Console.WriteLine();
                    do {
                        Console.Write("ИМЯ (обязательно): ");
                         Name = Console.ReadLine();
                    }
                    while (Name == null || Name == "");
                    //Console.WriteLine();
                    Console.Write("ОТЧЕСТВО: ");
                    string Lastname = Console.ReadLine();
                    // Console.WriteLine();
                    //do
                    // {
                    do
                    {
                        Console.Write("НОМЕР ТЕЛЕФОНА (обязательно, только цифры): ");//не забудь переделать под только цифры
                        try
                        {
                           Phone = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                          //  Console.WriteLine(procherk);
                            Console.WriteLine("-----------------ТОЛЬКО ЦИФРЫ!--------------------------");
                           // Console.WriteLine(procherk);
                        }
                    }
                    while (Phone == 0);
                    //}
                   // while (Phone == 0);
                    // Console.WriteLine();
                    Console.Write("СТРАНА: ");
                    string Country = Console.ReadLine();
                    //Console.WriteLine();
                    Console.Write("ДАТА РОЖДЕНИЯ: ");
                    string Birthday = Console.ReadLine();
                    // Console.WriteLine();
                    Console.Write("ОРГАНИЗАЦИЯ: ");
                    string Organization = Console.ReadLine();
                    // Console.WriteLine();
                    Console.Write("ДОЛЖНОСТЬ: ");
                    string Post = Console.ReadLine();
                    // Console.WriteLine();
                    Console.Write("ПРОЧЕЕ: ");
                    string Notes = Console.ReadLine();
                    Notebook NoteN = new Notebook(Surname, Name, Lastname, Phone, Country, Birthday, Organization, Post, Notes);
                    Console.Clear();
                    notes.Add(NoteN);
                    Console.WriteLine(procherk);
                    Console.WriteLine("Запись успешно создана!");
                   // Console.WriteLine("-----------------------------------------------------------");
                   // Console.WriteLine();
                





                // Console.WriteLine(n1);
            }
               else if (s == "2")
                {
                    Console.WriteLine(procherk);
                    Console.Write("Выберите номер записи для редактирования: ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    
                    if (i > notes.Count || i <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine(procherk);
                        Console.WriteLine("Такой записи не существует!");
                    }
                    else
                    {
                       
                        Console.Clear();
                        Console.WriteLine(procherk);
                        Console.WriteLine($"Запись номер {i}");
                        Console.WriteLine(procherk);
                        Console.WriteLine(notes[i - 1]);
                        Console.WriteLine(procherk);

                        // Console.WriteLine("-----------------------------------------------------------");

                        Console.WriteLine("Выберите пункт для редактирования (цифру):");
                        Console.WriteLine(procherk);
                        // Console.WriteLine();
                        Console.WriteLine("1 - Фамилия");
                        Console.WriteLine("2 - Имя");
                        Console.WriteLine("3 - Отчество");
                        Console.WriteLine("4 - Номер телефона");//не забудь переделать под только цифры
                        Console.WriteLine("5 - Страна");
                        Console.WriteLine("6 - Дата рождения");
                        Console.WriteLine("7 - Организация");
                        Console.WriteLine("8 - Должность");
                        Console.WriteLine("9 - Прочее");
                        Console.WriteLine(procherk);
                        Console.Write("Пункт номер: ");
                        string n = Console.ReadLine();
                        Console.WriteLine(procherk);
                        switch (n)
                        {
                            case "1":
                                notes[i - 1].Surname = Console.ReadLine();
                                break;
                            case "2":
                                notes[i - 1].Name = Console.ReadLine();
                                break;
                            case "3":
                                notes[i - 1].Lastname = Console.ReadLine();
                                break;
                            case "4":
                                notes[i - 1].Phone = Convert.ToInt32(Console.ReadLine());
                                break;
                            case "5":
                                notes[i - 1].Country = Console.ReadLine();
                                break;
                            case "6":
                                notes[i - 1].Birthday = Console.ReadLine();
                                break;
                            case "7":
                                notes[i - 1].Organization = Console.ReadLine();
                                break;
                            case "8":
                                notes[i - 1].Post = Console.ReadLine();
                                break;
                            case "9":
                                notes[i - 1].Notes = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Несуществующая запись!");
                                break;


                        }
                        Console.Clear();
                        Console.WriteLine(procherk);
                        Console.WriteLine("Запись успешно отредактирована!");
                    }
                }
               else if (s == "5")
                {
                    Console.Clear();
                   
                    for (int i= 0; i < notes.Count; i++)
                    {
                        // Console.WriteLine();
                        Console.WriteLine(procherk);
                        Console.WriteLine($"Запись номер: {i + 1}");
                        Console.WriteLine(procherk);
                        Console.WriteLine("Фамилия: "+notes[i].Surname);
                        Console.WriteLine("Имя: "+notes[i].Name);
                        Console.WriteLine("Телефон: "+notes[i].Phone);
                        Console.WriteLine(procherk);
                        Console.WriteLine();

                    }
                    //Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("Для выхода ОБРАТНО В МЕНЮ нажмите любую клавишу");
                   // Console.WriteLine("-----------------------------------------------------------");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (s == "3")
                {

                    Console.Write("Введите номер записи для удаления: ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    if (i > notes.Count|| i<=0)
                    {
                        Console.Clear();
                        Console.WriteLine(procherk);
                        Console.WriteLine("Такой записи не существует!");
                        //Console.WriteLine("-----------------------------------------------------------");
                    }
                    else
                    {
                        notes.RemoveAt(i - 1);
                        Console.Clear();
                        Console.WriteLine(procherk);
                        Console.WriteLine("Запись успешно удалена!");
                        //Console.WriteLine("-----------------------------------------------------------");
                   
                    }


                }
               else if (s == "4")
                {
                        Console.Write("Введите номер записи: ");
                        int i = Convert.ToInt32(Console.ReadLine());
                    if ((i > notes.Count)||(i<=0))
                    {
                        Console.Clear();
                        Console.WriteLine(procherk);
                        Console.WriteLine("Такой записи не существует!");
                      //  Console.WriteLine("-----------------------------------------------------------");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(procherk);
                        Console.WriteLine($"Запись номер: {i}");
                        Console.WriteLine(procherk);

                        Console.WriteLine(notes[i - 1]);

                        Console.WriteLine(procherk);
                        Console.WriteLine("Для выхода ОБРАТНО В МЕНЮ нажмите любую клавишу");
                        // Console.WriteLine("-----------------------------------------------------------");
                        Console.ReadLine();
                       
                        Console.Clear();
                    }
                    
                }
                else if (s == "6")
                {
                    Console.WriteLine("Выберите новый цвет (цифру):");
                    Console.WriteLine("1 - Red");
                    Console.WriteLine("2 - Green");
                    Console.WriteLine("3 - Blue");
                    Console.WriteLine("4 - Yellow");
                    Console.WriteLine("5 - Pink");
                    Console.WriteLine("6 - Gray");
                    Console.WriteLine("0 - Default");
                    Console.WriteLine(procherk);
                    Console.Write("Цвет: ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine(procherk);
                            Console.WriteLine("Цвет успешно изменён!");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Console.WriteLine(procherk);
                            Console.WriteLine("Цвет успешно изменён!");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Clear();
                            Console.WriteLine(procherk);
                            Console.WriteLine("Цвет успешно изменён!");
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            Console.WriteLine(procherk);
                            Console.WriteLine("Цвет успешно изменён!");
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Clear();
                            Console.WriteLine(procherk);
                            Console.WriteLine("Цвет успешно изменён!");
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Clear();
                            Console.WriteLine(procherk);
                            Console.WriteLine("Цвет успешно изменён!");
                            break;
                        case 0:
                            Console.ResetColor();
                            Console.Clear();
                            Console.WriteLine(procherk);
                            Console.WriteLine("Цвет успешно изменён!");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine(procherk);
                            Console.WriteLine("Цвет не был изменён (неверно указан номер)!");
                            break;
                    }
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(procherk);
                    Console.WriteLine("Введите корректное действие!");
                    //Console.WriteLine("-----------------------------------------------------------");
                }
            }
           // }
           // while (s != "6");
                /* switch (n)
                 {
                     case "1":
                         n1.Surname = Console.ReadLine();
                         break;

                 }
             }
             else { }
             Notebook n1 = new Notebook(Surname, Name, Lastname, Phone, Country, Birthday, Organization, Post, Notes);*/







        }
        public class Notebook
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Lastname { get; set; }
            public int Phone { get; set; }
            public string Country { get; set; }
            public string Birthday { get; set; }
            public string Organization { get; set; }
            public string Post { get; set; }
            public string Notes { get; set; }
            //int i;
            
            public Notebook(string S, string N,
                string L, int Ph, string C, string B, string O, string P, string No)
            {
                this.Surname = S;
                this.Name = N;
                this.Lastname = L;
                this.Phone = Ph;
                this.Country = C;
                this.Birthday = B;
                this.Organization = O;
                this.Post = P;
                this.Notes = No;
                //i=Program.it;
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Запись успешно создана!");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine();
            }

            public override string ToString()
            {
                return $"   Фамилия: {Surname} \n   Имя: {Name}\n   Отчество: {Lastname}\n   Телефон:{Phone}\n   Страна:{Country}\n   Дeнь рождения:{Birthday}\n   Организация:{Organization}\n   Почта:{Post}\n   Прочее:{Notes}";
            }
        }
       /* public enum Info :int
        {
            1 = "Фамилия",
            2 = "ma"
        }*/
            
    }
}

