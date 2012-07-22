using System;
using System.Collections.Generic;

namespace DatePickerBinding
{
    public sealed partial class ShellPage
    {
        public ShellPage()
        {
            InitializeComponent();
        }

        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            DataContext = new ShellViewModel();
        }
    }
}
