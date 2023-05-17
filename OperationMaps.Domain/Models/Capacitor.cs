using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationMaps.Domain.Models
{
    public class Capacitor : DomainObject
    {
        /// <summary>
        /// Наименование ЭРИ.
        /// </summary>
        public string Designation { get; set; }
        /// <summary>
        /// Наименование изделия.
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Постояное напряжение.
        /// </summary>
        public double DcVoltage { get; set; }
        /// <summary>
        /// Переменное напряжение.
        /// </summary>
        public double AcVoltage { get; set; }
        /// <summary>
        /// Импульсное напряжение.
        /// </summary>
        public double ImpulseVoltage { get; set; }
        /// <summary>
        /// Суммарное напряжение.
        /// </summary>
        public double SumVoltage { get; set; }
        /// <summary>
        /// Переменноый ток.
        /// </summary>
        public double AcCurrent { get; set; }
        /// <summary>
        /// Проходной ток.
        /// </summary>
        public double ThroughCurrent { get; set;}
        /// <summary>
        /// Разрядный ток.
        /// </summary>
        public double DischargeCurrent { get; set; }
        /// <summary>
        /// Длительность зарядки.
        /// </summary>
        public string ChargingTime { get; set; }
        /// <summary>
        /// Реактивня мощность.
        /// </summary>
        public double ReactivePower { get; set; }
        /// <summary>
        /// Частота максимальная.
        /// </summary>
        public double Maxfrequency { get; set; }
        /// <summary>
        /// Длительность импульса.
        /// </summary>
        public double ImpulseDuration { get; set; }
        /// <summary>
        /// Температура окружающей среды.
        /// </summary>
        public int AmbientTemperature { get; set;}
        /// <summary>
        /// Температура перегрева.
        /// </summary>
        public double SuperHeatTemperature { get; set; }
        /// <summary>
        /// Примечание.
        /// </summary>
        public string Note { get; set; }

    }
}
