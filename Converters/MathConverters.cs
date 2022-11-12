using NAudio.Wave;
using QuickMusic3.MVVM.Model;
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

public class AddConverter : ParameterConverter<double, double, double>
{
    public static readonly MultiplyConverter Instance = new();
    public override double Convert(double value, double parameter)
    {
        return value + parameter;
    }
}

public class MultiplyConverter : ParameterConverter<double, double, double>
{
    public static readonly MultiplyConverter Instance = new();
    public override double Convert(double value, double parameter)
    {
        return value * parameter;
    }
}

public class GreaterThanConverter : ParameterConverter<int, bool, int>
{
    public static readonly GreaterThanConverter Instance = new();
    public override bool Convert(int value, int parameter)
    {
        return value > parameter;
    }
}

public class LessThanConverter : ParameterConverter<int, bool, int>
{
    public static readonly LessThanConverter Instance = new();
    public override bool Convert(int value, int parameter)
    {
        return value < parameter;
    }
}

public class SumConverter : OneWayMultiConverter
{
    public override object Convert(object[] values)
    {
        return values.Cast<double>().Sum();
    }
}
