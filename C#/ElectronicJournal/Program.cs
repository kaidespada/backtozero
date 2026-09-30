using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace ElectronicJournal
{
    // Класс для валидации оценки (только от 1 до 5)
    public class Grade
    {
        public int Value { get; }

        public Grade(int val)
        {
            Value = (val >= 1 && val <= 5) ? val : throw new ArgumentException("Оценка от 1 до 5.");
        }
    }

    // Класс студента со списком его оценок
    public class Student
    {
        public string Name { get; }
        private readonly List<Grade> _grades = new();

        // Закрыытие списка от изменений снаружи через AsReadOnly
        public IReadOnlyCollection<Grade> Grades => _grades.AsReadOnly();

        public Student(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));

        public void AddGrade(Grade grade)
        {
            _grades.Add(grade ?? throw new ArgumentNullException(nameof(grade)));
        }
    }

    // Класс курса
    public class Course
    {
        public string Title { get; }
        private readonly List<Student> _students = new();

        public IReadOnlyCollection<Student> Students => _students.AsReadOnly();

        public Course(string title) => Title = title ?? throw new ArgumentNullException(nameof(title));

        // Метод для добавления студента на курс (без повторов)
        public void EnrollStudent(Student st)
        {
            if (st != null && !_students.Contains(st))
            {
                _students.Add(st);
            }
        }
    }

    // Интерфейс для генераторов отчетов
    public interface IReportGenerator
    {
        string Generate(Course course);
        string Extension { get; }
    }

    // Вывод в консоль
    public class ConsoleReportGenerator : IReportGenerator
    {
        public string Extension => "txt";

        public string Generate(Course c)
        {
            var lines = c.Students.Select(s =>
            {
                var grades = s.Grades.Select(g => g.Value);
                string info = s.Grades.Any() ? string.Join(", ", grades) : "нет оценок";
                return $"  {s.Name}: {info}";
            });

            return $"Курс: {c.Title}\n" + string.Join("\n", lines);
        }
    }

    // JSON формат
    public class JsonReportGenerator : IReportGenerator
    {
        public string Extension => "json";

        public string Generate(Course c)
        {
            var data = new
            {
                Course = c.Title,
                Students = c.Students.Select(s => new { s.Name, Grades = s.Grades.Select(g => g.Value) })
            };

            // Чтобы JSON не ломался
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            return JsonSerializer.Serialize(data, options);
        }
    }

    // HTML в виде оценки
    public class HtmlReportGenerator : IReportGenerator
    {
        public string Extension => "html";

        public string Generate(Course c)
        {
            string style = "<style>body{font-family:Arial;margin:30px;} table{border-collapse:collapse;width:100%;} th,td{border:1px solid #ddd;padding:8px;} th{{background:#f2f2f2;}}</style>";

            var rows = c.Students.Select(s =>
            {
                string grades = string.Join(", ", s.Grades.Select(g => g.Value));
                return $"<tr><td><b>{s.Name}</b></td><td>{grades}</td></tr>";
            });

            return $"<!DOCTYPE html><html><head><meta charset='utf-8'><title>{c.Title}</title>{style}</head>" +
                   $"<body><h1>Курс: {c.Title}</h1><table><tr><th>Студент</th><th>Оценки</th></tr>" +
                   string.Join("", rows) +
                   $"</table></body></html>";
        }
    }

    // Вывод или сохранка класса
    public class ReportPrinter
    {
        private readonly IReportGenerator _gen;
        public ReportPrinter(IReportGenerator gen) => _gen = gen;

        public void Print(Course c) => Console.WriteLine(_gen.Generate(c));

        public void Save(Course c, string name) => File.WriteAllText($"{name}.{_gen.Extension}", _gen.Generate(c));
    }

    class Program
    {
        static void Main()
        {
            Course course = new Course("Программирование на C#");

            Student st1 = new Student("Билл Клинтон");
            st1.AddGrade(new Grade(5));
            st1.AddGrade(new Grade(4));
            st1.AddGrade(new Grade(5));

            Student st2 = new Student("Честер Стоун");
            st2.AddGrade(new Grade(3));

            Student st3 = new Student("Уважатель Пчелок");
            st3.AddGrade(new Grade(5));
            st3.AddGrade(new Grade(5));

            Student st4 = new Student("Сатар Аребич");
            st4.AddGrade(new Grade(4));
            st4.AddGrade(new Grade(3));
            st4.AddGrade(new Grade(5));
            st4.AddGrade(new Grade(2));
            
            // Проверка на пустые строки
            Student st5 = new Student("Канье Уэст");

            course.EnrollStudent(st1);
            course.EnrollStudent(st2);
            course.EnrollStudent(st3);
            course.EnrollStudent(st4);
            course.EnrollStudent(st5);

            // Генерация и вывод отчетов во всех форматах
            var consolePrinter = new ReportPrinter(new ConsoleReportGenerator());
            consolePrinter.Print(course);

            var jsonPrinter = new ReportPrinter(new JsonReportGenerator());
            jsonPrinter.Save(course, "report");

            var htmlPrinter = new ReportPrinter(new HtmlReportGenerator());
            htmlPrinter.Save(course, "report");

            Console.ReadLine();
        }
    }

}
