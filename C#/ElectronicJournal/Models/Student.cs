using System;
using System.Collections.Generic;

namespace ElectronicJournal.Models
{
    // Класс студента с его оценками
    public class Student
    {
        public string Name { get; }

        // Список оценок, закрытый от изменений 
        private readonly List<Grade> _grades = new List<Grade>();
        public IReadOnlyCollection<Grade> Grades => _grades.AsReadOnly();

        // Конструктор с проверкой (С Null)
        public Student(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        // Добавление новой оценки в список
        public void AddGrade(Grade grade)
        {
            _grades.Add(grade);
        }
    }
}
