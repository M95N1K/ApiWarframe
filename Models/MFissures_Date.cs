using System;
using System.Collections.Generic;
using System.Text;

namespace ApiWarframe.Models
{
    public class MFissures_Date
    {
        /// <summary>Номер Эры миссии</summary>
        public int tierNum { get; set; }

        /// <summary>ID миссии</summary>
        public string id { get; set; }

        /// <summary>Дата начала миссии</summary>
        public DateTime activation { get; set; }

        /// <summary>Строковое значение времени начала</summary>
        public string startString { get; set; }

        /// <summary>Дата окончания</summary>
        public DateTime expiry { get; set; }

        /// <summary>Активность</summary>
        public Boolean active { get; set; }

        /// <summary>Узел миссии</summary>
        public string node { get; set; }

        /// <summary>Тип миссии</summary>
        public string missionType { get; set; }

        /// <summary>Враг</summary>
        public string enemy { get; set; }

        /// <summary>Эра</summary>
        public string tier { get; set; }

        /// <summary>Является ли оконченой</summary>
        public Boolean expired { get; set; }

        /// <summary>Сколько осталось до завершения</summary>
        public string eta { get; set; }

        /// <summary>Конструктор</summary>
        public MFissures_Date()
        { }

        /// <summary>Клонирование значения</summary>
        public MFissures_Date Clone()
        {
            MFissures_Date result = new MFissures_Date();
            result.activation = activation;
            result.tierNum = tierNum;
            result.tier = tier;
            result.id = id;
            result.startString = startString;
            result.expiry = expiry;
            result.active = active;
            result.node = node;
            result.missionType = missionType;
            result.enemy = enemy;
            result.expired = expired;
            result.eta = eta;

            return result;
        }
    }
}
