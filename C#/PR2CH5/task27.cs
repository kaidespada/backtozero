using System;

namespace PR2CH4
{
    internal static class task27
    {
        public enum OrderStatus
        {
            New,
            Paid,
            Shipped,
            Delivered,
            Cancelled
        }

        public static void Run()
        {
            Console.WriteLine("Выберите статус заказа (0 — Новый, 1 — Оплачен, 2 — Отправлен, 3 — Доставлен, 4 — Отменен):");
            if (int.TryParse(Console.ReadLine(), out int choice) && Enum.IsDefined(typeof(OrderStatus), choice))
            {
                OrderStatus status = (OrderStatus)choice;
                Console.WriteLine(GetStatusMessage(status));
            }
            else
            {
                Console.WriteLine("Некорректный статус заказа.");
            }
        }

        private static string GetStatusMessage(OrderStatus status)
        {
            return status switch
            {
                OrderStatus.New => "Заказ успешно создан и ожидает обработки.",
                OrderStatus.Paid => "Заказ оплачен. Мы готовим его к отправке.",
                OrderStatus.Shipped => "Заказ передан в службу доставки.",
                OrderStatus.Delivered => "Заказ успешно доставлен покупателю.",
                OrderStatus.Cancelled => "Заказ был отменен.",
                _ => "Неизвестный статус заказа."
            };
        }
    }
}
