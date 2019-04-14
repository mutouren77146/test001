using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xujh.Portal.DAL.SqlConnetion;
using xujh.Portal.Model.Entity;
using xujh.Portal.Model.Request;
using xujh.Portal.Model.Response;

namespace xujh.Portal.DAL.UserInfoDAL
{
    public class UserInfoDAL
    {
        private  sqlConnection _SqlConnetion;
        public  UserInfoDAL(sqlConnection connection)
        {
            this._SqlConnetion = connection;
        }
        public ResponseModel AddUser(AddUserInfo Adduser)
        {
            var user = new UserInfoModel { UserCode = Adduser.UserCode, UserName = Adduser.UserName, CreateBy = Adduser.CreateBy, CreateDate = DateTime.Now };
            _SqlConnetion.Add(user);
            int i = _SqlConnetion.SaveChanges();
            if (i > 0)
                return new ResponseModel { code = 200, Result = "Successfully" };
            return new ResponseModel { code = 0, Result = "Failed" };
        }
        public  ResponseModel GetUserInfoList()
        {
            var user = _SqlConnetion.UserInfo.ToList().OrderByDescending(b=>b.CreateDate);

            var response = new ResponseModel();
            response.code = 200;
            response.Result = "";
            response.data = new List<UserInfoModel>();
            foreach (var item in user)
            {
                response.data.Add(new UserInfoModel {
                    id = item.id,
                    UserCode = item.UserCode,
                    UserName = item.UserName,
                    CreateBy = item.CreateBy
                });
            }
            return response;
        }
    }
}
