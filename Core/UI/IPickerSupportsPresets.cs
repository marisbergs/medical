using System;
using System.Collections.Generic;
using System.Text;

namespace Core.UI
{
    public interface IPickerSupportsPresets
    {
        Queue<KeyValuePair<String, Object>> PickerPresets { get; set; }
    }
}
