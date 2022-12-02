using Models.Model;
using Models.viewmodelDBcontext;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Models
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private readonly ViewmodelDBcontext viewmodelDBcontext;
        public string ConnectionString = ConfigurationManager.ConnectionStrings["endoc"].ConnectionString;

        public Service1(ViewmodelDBcontext viewmodelDBcontext)
        {

        }
        public Service1()
        {

        }
        public List<ViewModel> ViewModels()
        {
          ViewmodelDBcontext obj =new ViewmodelDBcontext(ConnectionString);
            var holiday = (from s in obj.HolidaySetups
                           select new
                           {
                               s.Deleted,
                               s.HolidaySetupID,
                               s.FacilityID,
                               s.HolidayYear,
                               s.ModifiedBy,
                               s.CreatedBy,
                               s.CreatedDate,
                               s.Description,
                           }).AsEnumerable().Select(a => new ViewModel
                           {
                               Deleted = a.Deleted,
                               HolidaySetupID = a.HolidaySetupID,
                               FacilityID = a.FacilityID,
                               HolidayYear =a.HolidayYear,
                               ModifiedBy =a.ModifiedBy,
                               CreatedDate = a.CreatedDate,
                               Description = a.Description,
                               name=a.CreatedBy,
                               nameclass=a.Description,
                               nameDescription =a.Description
                           }).ToList();






            return holiday;
        }

    }
}
