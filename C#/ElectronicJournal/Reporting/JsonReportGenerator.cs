using System.Collections.Generic;
using ElectronicJournal.Models;

namespace ElectronicJournal.Reporting
{
    // JSON
    public class JsonReportGenerator : IReportGenerator
    {
        public string Generate(Course course)
        {
            var items = new List<string>();
            foreach (var student in course.Students)
            {
                // Оценки конкретных студентов
                var gradesList = new List<int>();
                foreach (var g in student.Grades) gradesList.Add(g.Value);
                string gradesStr = string.Join(", ", gradesList);

                // JSON для одного студента
                items.Add($"{{\"{student.Name}\": [{gradesStr}]}}");
            }

            // Сор в общий JSON
            return $"{{\"{course.Title}\": [{string.Join(", ", items)}]}}";
        }
    }
}
