using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TryashtarUtils.WPF;

public class EqualityConverter : OneWayMultiConverter
{
    public override object Convert(object[] values)
    {
        if (values.Length == 0)
            return false;
        for (int i = 1; i < values.Length; i++)
        {
            if (values[0] != values[i])
                return false;
        }
        return true;
    }
}
