using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for FoodService
    /// </summary>
    [WebService(Namespace = "http://Food.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FoodService : System.Web.Services.WebService
    {
        [WebMethod]
        public List<vw_Report> GetAll()
        {
            List<vw_Report> foods = new FoodDAO().SelectAll();
            return foods;
        }

        [WebMethod]
        public List<vw_Report> GetView()
        {
            List<vw_Report> vfoods = new FoodDAO().SelectView();
            return vfoods;
        }

        [WebMethod]
        public vw_Report GetDetails(int ID)
        {
            vw_Report food = new FoodDAO().SelectByCode(ID);
            return food;
        }

        [WebMethod]
        public List<vw_Report> Search(string keyword)
        {
            List<vw_Report> foods = new FoodDAO().SelectByKeyword(keyword);
            return foods;
        }

        [WebMethod]
        public bool AddNew(vw_Report newvw_Report)
        {
            bool result = new FoodDAO().Insert(newvw_Report);
            return result;
        }

        [WebMethod]
        public bool Update(vw_Report newvw_Report)
        {
            bool result = new FoodDAO().Update(newvw_Report);
            return result;
        }

        [WebMethod]
        public bool Delete(int ID)
        {
            bool result = new FoodDAO().Delete(ID);
            return result;
        }

    }
}
