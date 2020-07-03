using System;
using System.Collections.Generic;
using System.Text;

namespace ApiWarframe.Models
{
    public class Fissures_Date
    {

        public int tierNum { get; set; }
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime expiry { get; set; }

        /// <summary>
        /// Активность
        /// </summary>
        public Boolean active { get; set; }

        /// <summary>
        /// Узел миссии
        /// </summary>
        public string node { get; set; }

        /// <summary>
        /// Тип миссии
        /// </summary>
        public string missionType { get; set; }

        /// <summary>
        /// Враг
        /// </summary>
        public string enemy { get; set; }

        /// <summary>
        /// Эра
        /// </summary>
        public string tier { get; set; }

        /// <summary>
        /// Является ли оконченой
        /// </summary>
        public Boolean expired { get; set; }

        /// <summary>
        /// Сколько осталось до завершения
        /// </summary>
        public string eta { get; set; }


        public Fissures_Date()
        { }

        public Fissures_Date Clone()
        {
            Fissures_Date result = new Fissures_Date();
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
