using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string name;
        public string fam;
        public string group;
        public string age;
     
        public void InfoStud(string name, string fam, string group, string age)
        {
            Console.WriteLine("Информация о студенте\nФамилия: {0}\nИмя: {1}\nГруппа: {2}\nВозраст: {3}\n", name, fam, group, age);
        }
        
        public string LevelUp(string group)
        {
            group = Convert.ToString(Convert.ToInt32(group.Substring(0,1))+1)+group.Substring(1,group.Length-1);
            if (Convert.ToInt32(group.Substring(0, 1)) > 4)
            {
                group = "Закончил обучение!";
            }
            return group;
        }
        public string IsAdult(string age)
        {
            if (Convert.ToByte(age) >= 18)
            {
                age = age + "(Совершеннолетний)";
                return age;
            }
            else
            {
                age = age + "(Несовершеннолетний)";
                return age;
            }
        }
    }


    class TestStudent
    { 
        static void Main()
        {
        try { 

                Student stud1 = new Student();
                Console.WriteLine("Введите данные о студенте");
                Console.Write("Фамилия: ");
                stud1.fam = Console.ReadLine();
                Console.Write("Имя: ");
                stud1.name = Console.ReadLine();
                Console.Write("Группа: ");
                stud1.group = Console.ReadLine();
                Console.Write("Возраст: ");
                stud1.age = Console.ReadLine();

                Console.Clear();
                stud1.age = stud1.IsAdult(stud1.age);
                stud1.group = stud1.LevelUp(stud1.group);
                stud1.InfoStud(stud1.fam, stud1.name, stud1.group, stud1.age);
                Console.WriteLine("Нажмите любую клавишу для завершения...");
                Console.ReadKey();
            }
            catch
            {
                Console.Write("Ошибка ввода данных. Проверьте правильно ли введены данные и повторите попытку.");
                Console.ReadKey();
            }

            }
    }
}

