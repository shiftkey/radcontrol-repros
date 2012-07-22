using System;
using DatePickerBinding.Common;

namespace DatePickerBinding
{
    public class ShellViewModel : BindableBase
    {
        private DateTime _dateTime;
        private DateTime? _nullableDateTime;

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { SetProperty(ref _dateTime, value); }
        }

        public DateTime? NullableDateTime
        {
            get { return _nullableDateTime; }
            set { SetProperty(ref _nullableDateTime, value); }
        }
    }
}