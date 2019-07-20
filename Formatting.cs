using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ERP
{
    class Formatting
    {
        public float converting(string str)
        {
            str = Regex.Replace(str, @"[^\d.\d]", "");
            // 如果是数字，则转换为decimal类型
            if (Regex.IsMatch(str, @"^[+-]?\d*[.]?\d*$"))
            {
                try
                {
                    float result = float.Parse(str);
                    return result;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            else { return 0; }
        }
    }
}
