using ApiWarframe.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ApiWarframe
{
    public partial class API_Warframe
    {
        public class Get_Fissures : API_Warframe //Список миссий разрыва
        {

            public List<Fissures_Date> Fissures = new List<Fissures_Date>();

            public void UpdateData()
            {
                Fissures = GetJson<List<Fissures_Date>>("fissures");
            }

            public void Sort()
            {
                Comper comper = new Comper();
                Fissures.Sort(comper); 
            }
        }

        private class Comper : IComparer<Fissures_Date>
        {
            public int Compare(Fissures_Date x, Fissures_Date y)
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
