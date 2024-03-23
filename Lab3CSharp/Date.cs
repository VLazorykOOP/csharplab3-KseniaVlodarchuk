
namespace Lab3CSharp
{
    internal class Date
    {
        protected int day;
        protected int month;
        protected int year;

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int Day
        {
            get { return day; }
            set
            {
                if (value >= 1 && value <= 31)
                    day = value;
                else
                    throw new ArgumentException("Некоректне значення дня.");
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
                else
                    throw new ArgumentException("Некоректне значення місяця.");
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1)
                    year = value;
                else
                    throw new ArgumentException("Некоректне значення року.");
            }
        }

        public int Century
        {
            get { return (year - 1) / 100 + 1; }
        }

        public bool IsValidDate()
        {
            if (day < 1 || day > 31)
                return false;

            if (month < 1 || month > 12)
                return false;

            if (year < 1)
                return false;

            if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
                return false;

            if (month == 2)
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    if (day > 29)
                        return false;
                }
                else
                {
                    if (day > 28)
                        return false;
                }
            }

            return true;
        }

        // Метод для отримання кількості днів між двома датами
        public int DaysBetween(Date otherDate)
        {
            DateTime firstDate = new DateTime(year, month, day);
            DateTime secondDate = new DateTime(otherDate.Year, otherDate.Month, otherDate.Day);
            TimeSpan span = secondDate.Subtract(firstDate);
            return Math.Abs(span.Days);
        }

        // Метод для друку за шаблоном “5 січня 2022 року”
        public void PrintLongFormat()
        {
            Console.WriteLine($"{day} {GetMonthName(month)} {year} року");
        }

        // Метод для друку за шаблоном “05.01.2022”
        public void PrintShortFormat()
        {
            Console.WriteLine($"{day:D2}.{month:D2}.{year}");
        }

        // Приватний метод для отримання назви місяця за його номером
        private string GetMonthName(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1: return "січня";
                case 2: return "лютого";
                case 3: return "березня";
                case 4: return "квітня";
                case 5: return "травня";
                case 6: return "червня";
                case 7: return "липня";
                case 8: return "серпня";
                case 9: return "вересня";
                case 10: return "жовтня";
                case 11: return "листопада";
                case 12: return "грудня";
                default: return "";
            }
        }
    }
}
