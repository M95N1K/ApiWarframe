using ApiWarframe.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        /// <summary>
        /// Класс для получения списка миссий разрыва бездны
        /// </summary>
        public class Get_Fissures : API_Warframe //Список миссий разрыва
        {
            /// <summary>
            /// Возврощает список миссий разрыва бездны
            /// </summary>
            public List<MFissures_Date> Fissures { get; private set; }

            /// <summary>
            /// Конструктор ЛЕГО
            /// </summary>
            public Get_Fissures() => suburl = "fissures";

            /// <summary>
            /// Обновляет данные
            /// </summary>
            public void UpdateData()
            {
                Fissures = GetDate<List<MFissures_Date>>(suburl);
                Sort();
            }

            private void Sort()
            {
                Comper comper = new Comper();
                Fissures.Sort(comper); 
            }
            
        }

        private class Comper : IComparer<MFissures_Date>
        {
            public int Compare(MFissures_Date x, MFissures_Date y)
            {
                if (x == null)
                {
                    if (y == null)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if (y == null)
                        return 1;
                    else
                    {
                        if (x.tierNum > y.tierNum)
                            return 1;
                        else if (x.tierNum < y.tierNum)
                            return -1;
                    }
                }

                return 0;
            }
        }
    }
}
