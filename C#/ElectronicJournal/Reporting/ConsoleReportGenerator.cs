using System.Collections.Generic;
using System.Text;
using ElectronicJournal.Models;

namespace ElectronicJournal.Reporting
{
    // Консольный вывод
    public class ConsoleReportGenerator : IReportGenerator
    {
        public string Generate(Course course)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Курс: {course.Title}");

            foreach (var student in course.Students)
            {
                // Только числовые выводы
                var gradesList = new List<int>();
                foreach (var g in student.Grades) gradesList.Add(g.Value);

                // Сбор оценок
                string gradesStr = gradesList.Count > 0 ? string.Join(", ", gradesList) : "нет оценок";
                sb.AppendLine($"  {student.Name}: {gradesStr}");
            }
            return sb.ToString();
        }
    }
}
