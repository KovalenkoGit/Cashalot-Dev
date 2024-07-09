using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Cashalot_Dev
{
    internal class FileImport
    {
        //Імпорт файлу в txt форматі: 1. 00:00-03:00; 12:00-14:00 (1. номер групи, 00:00-03:00 години відсутності світла)
        public static Dictionary<int, Handler> ImportTxtFile(string filePath)
        {
            var outageSchedules = new Dictionary<int, Handler>();
            var rows = File.ReadAllLines(filePath);

            foreach (var row in rows)
            {
                var parts = row.Split(new[] { '.' }, 2);
                if (parts.Length != 2 || !int.TryParse(parts[0].Trim(), out int groupNumber))
                {
                    throw new FormatException("Невірний формат тексту.");
                }

                var timeRanges = parts[1].Split(';').Select(range => range.Trim());
                var outageSchedule = new Handler { GroupNumber = groupNumber };

                foreach (var range in timeRanges)
                {
                    var times = range.Split('-');
                    if (times.Length != 2 ||
                        !TimeSpan.TryParseExact(times[0].Trim(), "hh\\:mm", CultureInfo.InvariantCulture, out TimeSpan startTime) ||
                        !TimeSpan.TryParseExact(times[1].Trim(), "hh\\:mm", CultureInfo.InvariantCulture, out TimeSpan endTime))
                    {
                        throw new FormatException("Невірний формат тексту.");
                    }

                    outageSchedule.AddTimeRange(startTime, endTime);
                }

                outageSchedules[groupNumber] = outageSchedule;
            }

            return outageSchedules;
        }
        //Імпорт корегуючого файлу в txt форматі: 1. 00:00-03:00; 12:00-14:00 (1. номер групи, 00:00-03:00 години відсутності світла)
        public static void ImportTxtCorrectionFile(string filePath, Dictionary<int, Handler> outageSchedules)
        {
            var rows = File.ReadAllLines(filePath);
            var correctionsMade = false;

            foreach (var row in rows)
            {
                var parts = row.Split(new[] { '.' }, 2);
                if (parts.Length != 2 || !int.TryParse(parts[0].Trim(), out int groupNumber))
                {
                    throw new FormatException("Невірний формат тексту.");
                }

                if (outageSchedules.ContainsKey(groupNumber))
                {
                    var timeRanges = parts[1].Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    var groupSchedule = new List<(TimeSpan start, TimeSpan end)>();

                    foreach (var timeRange in timeRanges)
                    {
                        var times = timeRange.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                        if (times.Length != 2 ||
                            !TimeSpan.TryParseExact(times[0].Trim(), "hh\\:mm", CultureInfo.InvariantCulture, out TimeSpan startTime) ||
                            !TimeSpan.TryParseExact(times[1].Trim(), "hh\\:mm", CultureInfo.InvariantCulture, out TimeSpan endTime))
                        {
                            throw new FormatException("Невірний формат часу.");
                        }
                        groupSchedule.Add((startTime, endTime));
                    }

                    // Заміна існуючого розкладу
                    outageSchedules[groupNumber].TimeRanges = groupSchedule;
                    correctionsMade = true;
                }
                else
                {
                    throw new KeyNotFoundException($"Група {groupNumber} не існує. Коригування не виконано.");
                }
            }

            if (!correctionsMade)
            {
                throw new Exception("Жодного коригування не виконано.");
            }
        }

    }
}
