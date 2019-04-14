using System;
using System.Collections.Generic;
using System.Text;

namespace xujh.Portal.Model.Entity
{
    public class UserInfoModel
    {
        public int id { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string CreateBy { get; set; }
        public  DateTime CreateDate { get; set; }

    }
}
