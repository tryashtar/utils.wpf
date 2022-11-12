using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryashtarUtils.WPF;

public class TypeGetter : OneWayConverter<object, Type>
{
    public override Type Convert(object value)
    {
        return value.GetType();
    }
}
