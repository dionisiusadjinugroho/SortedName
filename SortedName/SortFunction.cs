using System;
using System.Collections.Generic;
using System.Text;

namespace SortedName
{
    public class SortFunction
    {
        /// <summary>
        /// Function to Sort Names By Putting the Last Name to be the First.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string Sorter(string name)
        {
            string sortedName = "";
            string[] arrName = name.Split(' ');
            if(arrName.Length > 1)
            {
                sortedName += arrName[arrName.Length - 1];
                for(int i = 0; i < arrName.Length - 1; i++)
                {
                    sortedName += string.Format(" {0}",arrName[i]);
                }
            }
            else
            {
                sortedName = name;
            }
            return sortedName;
        }
    }
}
