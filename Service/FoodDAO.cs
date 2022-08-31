using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Service
{
    public class FoodDAO
    {
        MyDBDataContext db = new MyDBDataContext(ConfigurationManager.ConnectionStrings["strFood"].ConnectionString);

        public List<vw_Report> SelectAll()
        {
            db.ObjectTrackingEnabled = false;
            List<vw_Report> foods = db.vw_Reports.ToList();
            return foods;
        }

        public List<vw_Report> SelectView()
        {
            db.ObjectTrackingEnabled = false;
            List<vw_Report> vfoods = db.vw_Reports.ToList();
            return vfoods;
        }

        public vw_Report SelectByCode(int ID)
        {
            db.ObjectTrackingEnabled = false;
            vw_Report food = db.vw_Reports.SingleOrDefault(b => b.ID_order == ID);
            return food;
        }

        public List<vw_Report> SelectByKeyword(String keyword)
        {
            db.ObjectTrackingEnabled = false;
            List<vw_Report> foods = db.vw_Reports.Where(b => b.Name_.Contains(keyword)).ToList();
            return foods;
        }

        public bool Insert(vw_Report newvw_Report)
        {

            try
            {
                db.vw_Reports.InsertOnSubmit(newvw_Report);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }

        }

        public bool Update(vw_Report newvw_Report)
        {
            vw_Report dbvw_Report = db.vw_Reports.SingleOrDefault(b => b.ID_order == newvw_Report.ID_order);
            if (dbvw_Report != null)
            {
                try
                {
                    dbvw_Report.ID_order = newvw_Report.ID_order;
                    dbvw_Report.Emp_Name = newvw_Report.Emp_Name;
                    dbvw_Report.Emp_Phone = newvw_Report.Emp_Phone;
                    dbvw_Report.ID_user = newvw_Report.ID_user;
                    dbvw_Report.user_Name = newvw_Report.user_Name;               
                    dbvw_Report.Address = newvw_Report.Address;
                    dbvw_Report.ID_foods = newvw_Report.ID_foods;
                    dbvw_Report.Name_ = newvw_Report.Name_;
                    dbvw_Report.Price = newvw_Report.Price;
                    dbvw_Report.Quantity = newvw_Report.Quantity;
                    dbvw_Report.Discount = newvw_Report.Discount;
                    dbvw_Report.Status = newvw_Report.Status;                                    
                    dbvw_Report.Date = newvw_Report.Date;                                    
                    db.SubmitChanges();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }

        public bool Delete(int ID)
        {
            vw_Report dbvw_Report = db.vw_Reports.SingleOrDefault(b => b.ID_order == ID);
            if (dbvw_Report != null)
            {
                try
                {
                    db.vw_Reports.DeleteOnSubmit(dbvw_Report);
                    db.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}