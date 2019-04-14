using System;
using System.Collections.Generic;
using System.Text;

namespace xujh.Portal.Model.Request
{
    public class AddUserInfo
    {
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string CreateBy { get; set; }
    }
}
