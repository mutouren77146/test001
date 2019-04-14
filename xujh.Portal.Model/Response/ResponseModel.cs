using System;
using System.Collections.Generic;
using System.Text;

namespace xujh.Portal.Model.Response
{
    public class ResponseModel
    {
        public int code { get; set; }
        public string Result { get; set; }
        public dynamic data { get; set; }
    }
}
