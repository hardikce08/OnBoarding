using CU.OnBoarding.DataAccess;
using CU.OnBoarding.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CU.OnBoarding.Web.Controllers
{
    public class ConfigurationController : BaseController
    {
        // GET: Configuration
        public ActionResult Index()
        {
            ConfigurationService cs = new ConfigurationService();
            ConfigurationVieWModel model = new ConfigurationVieWModel();
            model.lstDaysConfiguration = cs.DaysConfigurationsByUserId(Convert.ToInt32(Session["UserID"].ToString()));
            model.lstListConfiguration = cs.ListConfigurationsByUserId(Convert.ToInt32(Session["UserID"].ToString()));
            if (model.lstListConfiguration.Count > 0)
            {
                ListConfiguration lc = model.lstListConfiguration.Where(p => p.ListType == "Email").FirstOrDefault();
                if (lc != null)
                {
                    model.EmailList = true;
                    ViewBag.EmailFrequency = lc.ListFrequency;
                    ViewBag.EmailFrequencyDetail = lc.FrequencyDetail;
                }
                lc = model.lstListConfiguration.Where(p => p.ListType == "Mail").FirstOrDefault();
                if (lc != null)
                {
                    model.MailList = true;
                    ViewBag.MailFrequency = lc.ListFrequency;
                    ViewBag.MailFrequencyDetail = lc.FrequencyDetail;
                }
                lc = model.lstListConfiguration.Where(p => p.ListType == "Call").FirstOrDefault();
                if (lc != null)
                {
                    model.CallList = true;
                    ViewBag.CallFrequency = lc.ListFrequency;
                    ViewBag.CallFrequencyDetail = lc.FrequencyDetail;
                }
            }
            ViewBag.TotalDays = model.lstDaysConfiguration.Count == 0 ? 1 : model.lstDaysConfiguration.Count;
            var othercfg = cs.OtherConfigurationsByUserId(Convert.ToInt32(Session["UserID"].ToString())).FirstOrDefault();
            model.CommunicationEmail = othercfg != null ? othercfg.CommunicationEmail : "";
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(ConfigurationVieWModel model)
        {
            ConfigurationService cs = new ConfigurationService();
            //ConfigurationVieWModel model = new ConfigurationVieWModel();
            // model.lstDaysConfiguration = cs.DaysConfigurationsByUserId(Convert.ToInt32(Session["UserID"].ToString()));
            //ViewBag.TotalDays = model.lstDaysConfiguration.Count == 0 ? 1 : model.lstDaysConfiguration.Count;
            // Remove Old stored Days configuration 
            cs.DeleteConfigurationByUserId(Convert.ToInt32(Session["UserID"].ToString()));
            for (int i = 1; i < 10; i++)
            {
                if (!string.IsNullOrEmpty(Request.Form["days" + i.ToString()]))
                {
                    //var daysvalue = Request.Form["days" + i.ToString()];
                    DaysConfiguration cfg = new DaysConfiguration();
                    cfg.Day = i;
                    cfg.UserId = Convert.ToInt32(Session["UserID"].ToString());
                    cfg.Value = Request.Form["days" + i.ToString()];
                    cfg.CreatedDate = DateTime.Now;
                    cs.DaysConfiguration_InsertOrUpdate(cfg);
                }
            }

            //Logic to store ListConfiguration
            if (model.EmailList == true)
            {
                ListConfiguration lc = new ListConfiguration();
                lc.CreatedDate = DateTime.Now;
                lc.ListType = "Email";
                lc.ListFrequency = model.EmailListFrequency;
                lc.UserId = Convert.ToInt32(Session["UserID"].ToString());
                if (lc.ListFrequency == "Weekly")
                {
                    lc.FrequencyDetail = Request.Form["EmailListWeekday"];
                }
                else if (lc.ListFrequency == "Monthly")
                {
                    lc.FrequencyDetail = Request.Form["EmailListMonthday"];
                }
                cs.ListConfiguration_InsertOrUpdate(lc);
            }
            if (model.MailList == true)
            {
                ListConfiguration lc = new ListConfiguration();
                lc.CreatedDate = DateTime.Now;
                lc.ListType = "Mail";
                lc.ListFrequency = model.MailListFrequency;
                lc.UserId = Convert.ToInt32(Session["UserID"].ToString());
                if (lc.ListFrequency == "Weekly")
                {
                    lc.FrequencyDetail = Request.Form["MailListWeekday"];
                }
                else if (lc.ListFrequency == "Monthly")
                {
                    lc.FrequencyDetail = Request.Form["MailListMonthday"];
                }
                cs.ListConfiguration_InsertOrUpdate(lc);
            }
            if (model.CallList == true)
            {
                ListConfiguration lc = new ListConfiguration();
                lc.CreatedDate = DateTime.Now;
                lc.ListType = "Call";
                lc.ListFrequency = model.CallListFrequency;
                lc.UserId = Convert.ToInt32(Session["UserID"].ToString());
                if (lc.ListFrequency == "Weekly")
                {
                    lc.FrequencyDetail = Request.Form["CallListWeekday"];
                }
                else if (lc.ListFrequency == "Monthly")
                {
                    lc.FrequencyDetail = Request.Form["CallListMonthday"];
                }
                cs.ListConfiguration_InsertOrUpdate(lc);
            }
            var othercfg = cs.OtherConfigurationsByUserId(Convert.ToInt32(Session["UserID"].ToString())).FirstOrDefault();
            if (othercfg == null)
            {
                othercfg = new OtherConfiguration();
                othercfg.CreatedDate = DateTime.Now;
                othercfg.UserId = Convert.ToInt32(Session["UserID"].ToString());
            }
            othercfg.CommunicationEmail = model.CommunicationEmail;
            cs.OtherConfiguration_InsertOrUpdate(othercfg);
            return RedirectToAction("Index");
        }
    }
}