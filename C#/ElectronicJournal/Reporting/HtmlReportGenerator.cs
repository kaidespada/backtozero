using System.Collections.Generic;
using System.Text;
using ElectronicJournal.Models;

namespace ElectronicJournal.Reporting
{
    // Генератор отчета в HTML
    public class HtmlReportGenerator : IReportGenerator
    {
        public string Generate(Course course)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"<h2>Курс: {course.Title}</h2>");
            sb.AppendLine("<ul>"); // тег маркированного списка

            foreach (var student in course.Students)
            {
                // Сбор всех оценок в одие список
                var gradesList = new List<int>();
                foreach (var g in student.Grades) gradesList.Add(g.Value);
                string gradesStr = gradesList.Count > 0 ? string.Join(", ", gradesList) : "нет оценок";

                // Форм строчки для каждого студента
                sb.AppendLine($"  <li>{student.Name}: {gradesStr}</li>");
            }

            sb.AppendLine("</ul>"); // Закрытие
            return sb.ToString();
        }
    }
}
