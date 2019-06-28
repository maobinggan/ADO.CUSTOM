using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ADO.CUSTOM
{
    /// <summary>
    /// 基类
    /// </summary>
    public class AdoCustom
    {
        /// <summary>
        /// 是否在控制台打印SQL语句
        /// </summary>
        protected static bool ISPRINTFSQL = false;

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        protected static String connStr = null;

        /// <summary>
        /// 静态构造函数
        /// 1.一个类只能有一个静态构造器
        /// 2.静态构造器可与实例化构造器共存
        /// 3.在创建第一个实例或者任何静态成员被引用时，静态构造器被调用，最多运行一次
        /// 4.经测试：若子类所传入的泛型不同，则各子类不会共享父类的静态变量，每当各子类第一次引用静态成员时，都会执行一次父类(BaseDAL)的静态构造器。例如UserDAL<User>和AcountDAL<Acount>都继承BaseDAL,则第一次使用两个子类时都会执行一次BaseDAL的静态构造。
        /// </summary>
        static AdoCustom()
        {
            try {
                //从app.config文件中读取连接字符串
                connStr = ConfigurationManager.ConnectionStrings["connStr"].ToString();
            }
            catch {
                string exStr = "【异常】请检查app.config中的数据库连接字符串是否已正确配置";
                Console.WriteLine(exStr);
                MessageBox.Show(exStr);
                throw new Exception(exStr);
            }

        }

    }
}
