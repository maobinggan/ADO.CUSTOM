using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.CUSTOM
{
    /// <summary>
    /// 用于管理和设置
    /// </summary>
    public class AdoCustomManager : AdoCustom
    {
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="isPrintSQL"></param>
        public static void Setting(bool isPrintSQL)
        {
            ISPRINTFSQL = isPrintSQL;
        }
    }
}
