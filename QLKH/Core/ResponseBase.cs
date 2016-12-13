using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QLKH.Core
{
    public class ResponseBase
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Caption { get; set; }
        public MessageBoxButton MessageButton { get; set; }
        public MessageBoxImage MessageImage { get; set; }

        public ResponseBase()
        {
            Success = false;
        }
    }
}
