using System;
using DatePickerBinding.Common;

namespace DatePickerBinding
{
    public class ShellViewModel : BindableBase
    {
        public DateTime DateTime { get; set; }

        public DateTime? NullableDateTime { get; set; }
        

    }
}