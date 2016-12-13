using QLKH.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH.DTO
{
    public class LoginDTO : ResponseBase
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int Code { get; set; }
    }
}
