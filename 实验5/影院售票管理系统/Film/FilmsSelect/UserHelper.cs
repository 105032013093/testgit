using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsSelect
{
    /// <summary>
    /// 该类用来存放登陆的用户的类型和用户名，便于窗体的传递
    /// （存储在静态的成员变量里）方便后面的调用
    /// </summary>
    class UserHelper
    {
        public static string loginId = "";
        public static string loginType = "";

        public static int Id = 0;     //存放电影的主键（标识列）(售票员用的)

        public static int ID = 0;//存放电影的主键FID（管理员用的）

 

        public static String type = "";//存储会员类型


        public static String MemberID = "";//存储会员的证件
    }
}
