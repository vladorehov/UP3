using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP3z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("fio", 10000, 1);
            List<Employee> employees = new List<Employee>()
            {
                new Employee ("Дроздов Мечислав Федотович", 17000, 2),
                new Employee ("Яковлев Гарри Антонинович", 23000, 1),
                new Employee ("Тетерин Осип Викторович", 25000, 2),
                new Employee ("Сергеев Тимофей Мэлсович", 58000, 3),
                new Employee ("Смирнов Гордей Евгеньевич", 63000, 4),
                new Employee ("Лукин Панкрат Святославович", 38000, 3),
                new Employee ("Воробьёв Игорь Егорович", 320000, 5),
                new Employee ("Горбачёв Власий Георгиевич", 72000, 4),
                new Employee ("Крюков Август Наумович", 335000, 5),
                new Employee ("Федосеев Феликс Михайлович", 28000, 1)

            };
            int Y = 1;
            while (Y == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Веберите задание, варианты: 1, 21, 22, 23, 24, 25, 31, 32");
                int viborz = Convert.ToInt32(Console.ReadLine());
                if (viborz == 1) Zad1(1.1);
                if (viborz == 21) Zad21();
                if (viborz == 22) Zad22();
                if (viborz == 23) Zad23();
                if (viborz == 24) Zad24(1.1);
                if (viborz == 25) Zad25();
                if (viborz == 31) Zad31();
                if (viborz == 32) Zad32();
            }



            void Zad1(double argument)
            {
                double pov = 0;
                double ar = argument;
                foreach (var emp in employees)
                {
                    pov = emp.Salary * ar;
                    Console.WriteLine("Повышаем зараплату " + emp.Fio + " до " + pov);
                }
            }
            void Zad21()
            {
                Console.WriteLine("Выберите отдел для определения минимальной зарплаты по отделу");
                double vibor = Convert.ToDouble(Console.ReadLine());
                double min = 9999999;
                foreach (var emp in employees)
                {

                    if (emp.Salary < min)
                    {
                        if (emp.Department == vibor)
                        {
                            min = emp.Salary;
                        }

                    }

                }
                Console.WriteLine("Минимальная зарплата по выбранному отделу " + min);
            }
            void Zad22()
            {
                Console.WriteLine("Выберите отдел для определения максимальной зарплаты по отделу");
                double vibor = Convert.ToDouble(Console.ReadLine());
                double max = 0;
                foreach (var emp in employees)
                {

                    if (emp.Salary > max)
                    {
                        if (emp.Department == vibor)
                        {
                            max = emp.Salary;
                        }

                    }

                }
                Console.WriteLine("Максимальная зарплата по выбранному отделу " + max);
            }
            void Zad23()
            {
                Console.WriteLine("Выберите отдел для определения средней зарплаты по отделу");
                int count = 0;
                double summa = 0;
                double vibor = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == vibor)
                    {
                        count++;
                        summa += emp.Salary;
                    }
                }

                Console.WriteLine($"Среднее значение зарплаты по выбранному отделу: {summa / count}");
            }

            void Zad24(double argument)
            {
                Console.WriteLine("Выберите отдел для увеличения зарплаты по отделу");
                double vibor = Convert.ToDouble(Console.ReadLine());
                double pov = 0;
                double ar = argument;
                foreach (var emp in employees)
                {
                    if (emp.Department == vibor)
                    {
                        pov = emp.Salary * ar;
                        Console.WriteLine("Повышаем зараплату по выбранному отделу " + emp.Fio + " до " + pov);
                    }

                }
            }
            void Zad25()
            {
                Console.WriteLine("");
                Console.WriteLine("Выберите сотрудников какого отдела показать ");
                double vibor = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Department == vibor)
                    {

                        Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                    }
                }
            }
            void Zad31()
            {

                Console.WriteLine("Будет выведены зарплаты меньше чем : ");
                double vibor = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Salary < vibor)
                    {

                        Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                    }
                }
            }
            void Zad32()
            {

                Console.WriteLine("Будет выведены зарплаты больше чем : ");
                double vibor = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employees)
                {
                    if (emp.Salary > vibor)
                    {

                        Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
