using System;

namespace PR2CH4
{
    internal static class task28
    {
        public enum UserRole
        {
            Guest,
            User,
            Moderator,
            Admin
        }

        public static void Run()
        {
            Console.WriteLine("Выберите роль (0 — Гость, 1 — Пользователь, 2 — Модератор, 3 — Администратор):");
            if (int.TryParse(Console.ReadLine(), out int choice) && Enum.IsDefined(typeof(UserRole), choice))
            {
                UserRole role = (UserRole)choice;

                Console.WriteLine($"Описание: {GetRoleDescription(role)}");
                Console.WriteLine($"Может удалять посты: {(CanDeletePost(role) ? "Да" : "Нет")}");
            }
            else
            {
                Console.WriteLine("Некорректная роль.");
            }
        }

        private static bool CanDeletePost(UserRole role)
        {
            return role switch
            {
                UserRole.Moderator or UserRole.Admin => true,
                _ => false
            };
        }

        private static string GetRoleDescription(UserRole role)
        {
            return role switch
            {
                UserRole.Guest => "Гость с правами только для чтения контента.",
                UserRole.User => "Обычный пользователь с возможностью создавать публикации.",
                UserRole.Moderator => "Модератор, следящий за порядком и удаляющий нарушения.",
                UserRole.Admin => "Администратор с полным доступом к управлению системой.",
                _ => "Неизвестная роль."
            };
        }
    }
}
