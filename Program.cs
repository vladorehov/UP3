using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("fio", 10000, 1);
            List<Employee> employees = new List<Employee>()
            {
                new Employee ("Дроздов Мечислав Федотович", 17000, 2),
                new Employee ("Яковлев Гарри Антонинович", 2300, 1),
                new Employee ("Тетерин Осип Викторович", 25000, 2),
                new Employee ("Сергеев Тимофей Мэлсович", 38000, 3),
                new Employee ("Смирнов Гордей Евгеньевич", 63000, 4),
                new Employee ("Лукин Панкрат Святославович", 58000, 3),
                new Employee ("Воробьёв Игорь Егорович", 320000, 5),
                new Employee ("Горбачёв Власий Георгиевич", 32000, 4),
                new Employee ("Крюков Август Наумович", 335000, 5),
                new Employee ("Федосеев Феликс Михайлович", 28000, 1)
                
            };

            void TaskA()
            {
                Console.WriteLine("Task A");
                foreach (var emp in employees)
                {

                    Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Department}");
                }
            }

            void TaskB()
            {
                Console.WriteLine("Task B");
                double summa = 0;
                foreach (var emp in employees)
                {
                    summa += emp.Salary;
                }
                Console.WriteLine($"Сумма затрат на зарплату в месяц: {summa}");
            }

            void TaskC()
            {
                Console.WriteLine("Task C");
                double min = 99999999999;
                foreach (var emp in employees)
                {
                    if (emp.Salary < min)
                    {
                        min = emp.Salary;
                    }
                }
                Console.WriteLine("Минимальная зарплата " + min);
            }

            void TaskD()
            {
                Console.WriteLine("Task D");
                double max = 0;
                foreach (var emp in employees)
                {
                    if (emp.Salary > max)
                    {
                        max = emp.Salary;
                    }
                }
                Console.WriteLine("Максимальная зарплата " + max);
            }

            void TaskE()
            {
                Console.WriteLine("Task E");
                int count = 0;
                double summa = 0;
                foreach (var emp in employees)
                {
                    count++;
                    summa += emp.Salary;
                }

                Console.WriteLine($"Среднее значение зарплаты: {summa / count}");
            }

            void TaskF()
            {
                Console.WriteLine("Task F");
                foreach (var emp in employees)
                {
                    Console.WriteLine("ФИО " + emp.Fio);
                }
                Console.ReadKey();
            }

            TaskA();
            Console.WriteLine();
            TaskB();
            Console.WriteLine();
            TaskC();
            Console.WriteLine();
            TaskD();
            Console.WriteLine();
            TaskE();
            Console.WriteLine();
            TaskF();
        }
    }
}
