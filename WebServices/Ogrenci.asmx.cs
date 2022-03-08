using DAL_Example;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for Ogrenci
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Ogrenci : System.Web.Services.WebService
    {
        [WebMethod]
        public DataTable r_Ogrenci()
        {
            DataTable dtResult = new DataTable();

            Execute _execute = new Execute();
            string _hataMesaji = "";
            dtResult = _execute.executeDT("select * from OGRENCI", null, false, ref _hataMesaji);
            dtResult.TableName = "dtTable";

            return dtResult;
        }

        [WebMethod]
        public bool c_Ogrenci(string ad, string soyad)
        {
            bool result = true;

            Execute _execute = new Execute();
            string _hataMesaji = "";

            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@ad", ad));
            _params.Add(new SqlParameter("@soyad", soyad));

            result = _execute.execute("insert into OGRENCI (ad, soyad) values (@ad, @soyad)", _params.ToArray(), false, ref _hataMesaji);

            return result;
        }

        [WebMethod]
        public bool u_Ogrenci(int id, string ad, string soyad)
        {
            bool result = true;

            Execute _execute = new Execute();
            string _hataMesaji = "";

            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@id", id));
            _params.Add(new SqlParameter("@ad", ad));
            _params.Add(new SqlParameter("@soyad", soyad));

            result = _execute.execute("update OGRENCI set ad=@ad, soyad=@soyad where id=@id", _params.ToArray(), false, ref _hataMesaji);

            return result;
        }

        [WebMethod]
        public bool d_Ogrenci(int id)
        {
            bool result = true;

            Execute _execute = new Execute();
            string _hataMesaji = "";

            List<SqlParameter> _params = new List<SqlParameter>();
            _params.Add(new SqlParameter("@id", id));

            result = _execute.execute("delete from OGRENCI where id=@id", _params.ToArray(), false, ref _hataMesaji);

            return result;
        }
    }
}
