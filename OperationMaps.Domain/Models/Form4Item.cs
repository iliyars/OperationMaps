using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationMaps.Domain.Models
{
    public class Form4Item : DomainObject
    {
        /// <summary>
        /// Наименование ЭРИ.
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Обозначение.
        /// </summary>
        public string Designation { get; set; }
        /// <summary>
        /// Наличие в перечнях при утверждении ТТЗ.
        /// </summary>
        public string InListTTZ { get; set; }
        /// <summary>
        /// Наличие в перечнях последних редакций.
        /// </summary>
        public string LastEditions { get; set; }
        /// <summary>
        /// Показатель ресурса, ч.
        /// </summary>
        public int ResourceHours { get; set; }
        /// <summary>
        /// Показатель срока службы, лет.
        /// </summary>
        public int LifeTimeYears { get; set; }
        /// <summary>
        /// показатель сохраняемости, лет.
        /// </summary>
        public int PreservationYears { get;}
        /// <summary>
        /// Диапазон частот, Гц
        /// </summary>
        public string FrequencyRange { get; set; }
        /// <summary>
        /// Уровень звукового давлени, дБ.
        /// </summary>
        public int SoundPressure { get; set; }
        /// <summary>
        /// Линейное ускорение, М.С.Е-2(G).
        /// </summary>
        public string LineAcceleration { get; set; }
        /// <summary>
        /// Давление окр.среды пониженное.
        /// </summary>
        public string LowPressure { get; set; }
        /// <summary>
        /// Давление окр.среды повышенное.
        /// </summary>
        public string HighPressure { get; set; }
        /// <summary>
        /// Предельная температура пониженная.
        /// </summary>
        public string LowTemperature { get; set; }
        /// <summary>
        /// Предельная температура повышенная.
        /// </summary>
        public string HighTemperature { get; set; }
        /// <summary>
        /// Относительня влажность, %.
        /// </summary>
        public int HumidityPercent { get; set; }
        /// <summary>
        /// Относительня влажность, С.
        /// </summary>
        public string HumidityCelcius { get; set; }
        /// <summary>
        /// Роса, иней.
        /// </summary>
        public string Dew { get; set; }
        /// <summary>
        /// Стойкость к ВССФ.
        /// </summary>
        public string SpecialFactors { get; set;}
        /// <summary>
        /// Примечание.
        /// </summary>
        public string Note { get; set; }

    }
}
