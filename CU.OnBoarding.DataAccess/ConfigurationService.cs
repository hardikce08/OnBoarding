using CU.OnBoarding.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using EF = CU.OnBoarding.Model;
namespace CU.OnBoarding.DataAccess
{
    public class ConfigurationService : ConnectionHelper
    {
        EF.OnBoardingEntities db = null;
        public ConfigurationService()
        {
            db = new EF.OnBoardingEntities(EntityConnectionString);
        }
        public ConfigurationService(ObjectContext context)
        {
            db = context as EF.OnBoardingEntities;
        }
        public ObjectContext DbContext
        {
            get
            {
                return db as ObjectContext;
            }
        }

        #region Days Configuration

        public IQueryable<DaysConfiguration> DaysConfigurations
        {
            get
            {
                return from d in db.DaysConfiguration
                       select new DaysConfiguration
                       {
                           Id = d.Id,
                           UserId = d.UserId,
                           Day = d.Day,
                           Value = d.Value,
                           CreatedDate = d.CreatedDate,
                       };
            }
        }

        public List<DaysConfiguration> DaysConfigurationsByUserId(int UserId)
        {

            var lst = from d in db.DaysConfiguration
                      where d.UserId == UserId
                      select new DaysConfiguration
                      {
                          Id = d.Id,
                          UserId = d.UserId,
                          Day = d.Day,
                          Value = d.Value,
                          CreatedDate = d.CreatedDate,
                      };
            return lst.ToList();
        }

        public void DaysConfiguration_InsertOrUpdate(DaysConfiguration d)
        {
            if (d.Id == 0)
            {
                var i = new EF.DaysConfiguration
                {
                    UserId = d.UserId,
                    Day = d.Day,
                    Value = d.Value,
                    CreatedDate = d.CreatedDate,
                };

                db.DaysConfiguration.AddObject(i);
                db.SaveChanges();
                d.Id = i.Id;
            }


            else
            {
                var u = db.DaysConfiguration.Where(p => p.Id == d.Id).Single();
                u.UserId = d.UserId;
                u.Day = d.Day;
                u.Value = d.Value;
                u.CreatedDate = d.CreatedDate;

                db.SaveChanges();
            }
        }
        public void DeleteConfigurationByUserId(int UserId)
        {
            //Code to update Actual houseHoldId
            DataHelper ds = new DataHelper();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@UserId", UserId);
            ds.ExecuteNonQuery("proc_RemoveConfigrationbyUser", param);
        }
        #endregion
        #region List Configuration

        public IQueryable<ListConfiguration> ListConfigurations
        {
            get
            {
                return from l in db.ListConfiguration
                       select new ListConfiguration
                       {
                           Id = l.Id,
                           UserId = l.UserId,
                           ListType = l.ListType,
                           ListFrequency = l.ListFrequency,
                           FrequencyDetail = l.FrequencyDetail,
                           CreatedDate = l.CreatedDate,
                       };
            }
        }
        public List<ListConfiguration> ListConfigurationsByUserId(int UserId)
        {

            var lst = from l in db.ListConfiguration
                      where l.UserId == UserId
                      select new ListConfiguration
                      {
                          Id = l.Id,
                          UserId = l.UserId,
                          ListType = l.ListType,
                          ListFrequency = l.ListFrequency,
                          FrequencyDetail = l.FrequencyDetail,
                          CreatedDate = l.CreatedDate,
                      };
            return lst.ToList();
        }

        public void ListConfiguration_InsertOrUpdate(ListConfiguration l)
        {
            if (l.Id == 0)
            {
                var i = new EF.ListConfiguration
                {
                    UserId = l.UserId,
                    ListType = l.ListType,
                    ListFrequency = l.ListFrequency,
                    FrequencyDetail = l.FrequencyDetail,
                    CreatedDate = l.CreatedDate,
                };

                db.ListConfiguration.AddObject(i);
                db.SaveChanges();
                l.Id = i.Id;
            }


            else
            {
                var u = db.ListConfiguration.Where(p => p.Id == l.Id).Single();
                u.UserId = l.UserId;
                u.ListType = l.ListType;
                u.ListFrequency = l.ListFrequency;
                u.FrequencyDetail = l.FrequencyDetail;
                u.CreatedDate = l.CreatedDate;

                db.SaveChanges();
            }
        }
        #endregion
        #region Other Configuration

        public IQueryable<OtherConfiguration> OtherConfigurations
        {
            get
            {
                return from o in db.OtherConfiguration
                       select new OtherConfiguration
                       {
                           Id = o.Id,
                           UserId = o.UserId,
                           CommunicationEmail = o.CommunicationEmail,
                           CreatedDate = o.CreatedDate,
                       };
            }
        }
        public List<OtherConfiguration> OtherConfigurationsByUserId(int UserId)
        {

            var lst = from o in db.OtherConfiguration
                      where o.UserId == UserId
                      select new OtherConfiguration
                      {
                          Id = o.Id,
                          UserId = o.UserId,
                          CommunicationEmail = o.CommunicationEmail,
                          CreatedDate = o.CreatedDate,
                      };
            return lst.ToList();
        }

        public void OtherConfiguration_InsertOrUpdate(OtherConfiguration o)
        {
            if (o.Id == 0)
            {
                var i = new EF.OtherConfiguration
                {
                    UserId = o.UserId,
                    CommunicationEmail = o.CommunicationEmail,
                    CreatedDate = o.CreatedDate,
                };

                db.OtherConfiguration.AddObject(i);
                db.SaveChanges();
                o.Id = i.Id;
            }


            else
            {
                var u = db.OtherConfiguration.Where(p => p.Id == o.Id).Single();
                u.UserId = o.UserId;
                u.CommunicationEmail = o.CommunicationEmail;
                u.CreatedDate = o.CreatedDate;

                db.SaveChanges();
            }
        }
        #endregion
    }
}
