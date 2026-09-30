using System;
using System.Collections.Generic;

namespace ElectronicJournal.Models
{
    // Класс, что собирает список учащихся на нем студентов
    public class Course
    {
        public string Title { get; }

        private readonly List<Student> _students = new List<Student>();

        public IReadOnlyCollection<Student> Students => _students.AsReadOnly();

        // Проверка
        public Course(string title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        // Запись студента на курс
        public void EnrollStudent(Student student)
        {
            // Защита от передачи пустого объекта
            if (student == null) throw new ArgumentNullException(nameof(student));

            // Проверка и добавление , только если такого студента нету
            if (!_students.Contains(student))
            {
                _students.Add(student);
            }
        }
    }
}
