using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cashalot_Dev
{
    internal class ExportFile
    {
        //Експорт файлу в Json
        public static void ExportToJson(Dictionary<int, Handler> outageSchedules, string filePath)
        {
            try
            {
                var json = JsonConvert.SerializeObject(outageSchedules, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при експорті в формат JSON: {ex.Message}");
            }
        }
    }
}
