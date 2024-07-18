using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashalot_Dev
{
    internal class Handler
    {
        public int GroupNumber { get; set; }
        public List<(TimeSpan Start, TimeSpan End)> TimeRanges { get; set; } = new List<(TimeSpan Start, TimeSpan End)>();

        public void AddTimeRange(TimeSpan start, TimeSpan end)
        {
            TimeRanges.Add((start, end));
        }
        private Dictionary<int, Handler> outageSchedules = new Dictionary<int, Handler>();

        public void ImportOutageSchedules(string filePath)
        {
            outageSchedules = FileImport.ImportTxtFile(filePath);
        }
        //Метод заповненн таблиці з імпортованого файлу (імпорт графіку відключення)
        public void PopulateDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("GroupNum", "Група");

            // Максимальна кількість переодів
            int maxPeriods = outageSchedules.Values.Max(schedule => schedule.TimeRanges.Count);

            for (int i = 0; i < maxPeriods; i++)
            {
                dataGridView.Columns.Add($"Period{i + 1}", $"Період {i + 1}");
            }

            foreach (var group in outageSchedules)
            {
                // Масив для зберігання часу для кожного періоду
                string[] periodTimes = new string[maxPeriods];

                // Форматуємо час для групи
                for (int i = 0; i < group.Value.TimeRanges.Count; i++)
                {
                    periodTimes[i] = $"{group.Value.TimeRanges[i].Start.ToString(@"hh\:mm")}-{group.Value.TimeRanges[i].End.ToString(@"hh\:mm")}";
                }
                // Додаємо рядок до dataGridView, починаючи з другого стовпця
                // Створення масиву рядків із груповим ключем, за яким слідує periodTimes, починаючи з індексу 0
                List<string> rowValues = new List<string>();
                rowValues.Add(group.Key.ToString()); // Додаємо номер групи як перша колонка

                // Додаємо час періоду, що залишився, починаючи з індексу 0
                for (int i = 0; i < maxPeriods; i++)
                {
                    rowValues.Add(periodTimes[i] ?? ""); // Додаємо відформатований діапазон часу або порожній рядок
                }

                dataGridView.Rows.Add(rowValues.ToArray()); // Додаємо створений рядок до dataGridView
            }
        }
        //Метод заповненн коригуючого файлу (вносимо зміни у вже існуючий графік)
        public void ImportCorrectionFile(string filePath)
        {
            FileImport.ImportTxtCorrectionFile(filePath, outageSchedules);
        }
        //Метод заповненн таблиці з корегуючого файлу (імпорт коригуючого файлу)
        public void UpdateDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("GroupNum", "Група");

            int maxPeriods = outageSchedules.Values.Max(schedule => schedule.TimeRanges.Count);

            // Динамічно додавайте стовпці на основі максимальної кількості знайдених періодів
            for (int i = 0; i < maxPeriods; i++)
            {
                dataGridView.Columns.Add($"Period{i + 1}", $"Період {i + 1}");
            }

            // Додати рядки для кожної групи
            foreach (var group in outageSchedules)
            {
                // Створення масиву для зберігання часу для кожного періоду
                string[] periodTimes = new string[maxPeriods];

                // Заповнити масив відформатованими діапазонами часу для цієї групи
                for (int i = 0; i < group.Value.TimeRanges.Count; i++)
                {
                    periodTimes[i] = $"{group.Value.TimeRanges[i].Start.ToString(@"hh\:mm")}-{group.Value.TimeRanges[i].End.ToString(@"hh\:mm")}";
                }

                // Додайте рядок до dataGridView, починаючи з другого стовпця
                dataGridView.Rows.Add(new[] { group.Key.ToString() }.Concat(periodTimes).ToArray());
            }
        }
        //Метод перегляду відключення світла у вибрані групі
        public string GetGroupStatus(int groupNumber)
        {
            if (!outageSchedules.ContainsKey(groupNumber))
            {
                return $"Такої групи ({groupNumber}) немає в графіку.";
            }

            var now = DateTime.Now.TimeOfDay;
            foreach (var (start, end) in outageSchedules[groupNumber].TimeRanges)
            {
                if ((start <= now && end >= now) ||  // Звичайний випадок
                    (start <= now && end < start) || // Випадок, коли час кінця менше за час початку
                    (end >= now && start > end))     // Випадок, коли час початку більший за час кінця
                {

                    return $"У групі {groupNumber} зараз немає світла.";
                }
            }

            return $"У групі {groupNumber} зараз є світло.";
        }
        //Метод перегляду відключення світла у всіх групах
        public string GetCurrentOutages()
        {
            var now = DateTime.Now.TimeOfDay;
            var currentOutages = outageSchedules
            .Where(g => g.Value.TimeRanges.Any(t =>
                (t.Start <= now && t.End >= now) ||    // Звичайний випадок
                (t.Start <= now && t.End < t.Start) || // Випадок, коли час кінця менше за час початку
                (t.End >= now && t.Start > t.End)))    // Випадок, коли час початку більший за час кінця
                .Select(g => g.Key).ToList();

            if (!currentOutages.Any())
            {
                return "Зараз немає відключень.";
            }
            else
            {
                return "Зараз відключене світло у групах: " + string.Join(", ", currentOutages);
            }
        }
        //Експорт в Json
        public void ExportToJson(string filePath)
        {
            try
            {
                ExportFile.ExportToJson(outageSchedules, filePath);
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при експорті у формат JSON: {ex.Message}");
            }
        }
        // Скидаємо стиль всіх клітинок до стандартного кольору
        public void dataGridBackColor(DataGridView dataGridView, int groupNumber)
        {

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }
        }
        public void dataGridBackColor(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }
        }

        //Метод вилілення червоним кольором всіх поточних відключень
        public void HighlightCurrentOutagesAll(DataGridView dataGridView)
        {
            var now = DateTime.Now.TimeOfDay;

            dataGridBackColor(dataGridView);

            // Перевіряємо кожну клітинку на наявність відключення
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int i = 1; i < row.Cells.Count; i++) // Починаємо з 1, щоб пропустити колонку з номером групи
                {
                    var cell = row.Cells[i];
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        var times = cell.Value.ToString().Split('-');
                        if (times.Length == 2 &&
                            TimeSpan.TryParse(times[0], out TimeSpan start) &&
                            TimeSpan.TryParse(times[1], out TimeSpan end))
                        {
                            bool isOutage = (start <= now && end >= now) ||
                                            (start > end && (now >= start || now <= end));
                            cell.Style.BackColor = isOutage ? Color.Red : Color.White;
                        }
                    }
                }
            }
        }

        //Метод вилілення червоним кольором відключень по групах
        public void HighlightCurrentOutagesGroup(DataGridView dataGridView, int groupNumber)
        {
            var now = DateTime.Now.TimeOfDay;

            dataGridBackColor(dataGridView, groupNumber);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Перевіряємо, чи номер групи відповідає заданому
                if (int.TryParse(row.Cells[0].Value.ToString(), out int number) && number == groupNumber)
                {
                    // Перевіряємо кожну клітинку починаючи з другої
                    for (int i = 1; i < row.Cells.Count; i++)
                    {
                        var cell = row.Cells[i];
                        if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                        {
                            var times = cell.Value.ToString().Split('-');
                            if (times.Length == 2 &&
                                TimeSpan.TryParse(times[0], out TimeSpan start) &&
                                TimeSpan.TryParse(times[1], out TimeSpan end))
                            {
                                bool isOutage = (start <= now && end >= now) ||
                                                (start > end && (now >= start || now <= end));
                                cell.Style.BackColor = isOutage ? Color.Red : Color.White;
                            }
                        }
                    }
                }
            }
        }

    }
}
