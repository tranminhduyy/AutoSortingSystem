using AutoSortingSystem.Application.ViewModel;
using AutoSortingSystem.Data;
using AutoSortingSystem.Data.EF;
using AutoSortingSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSortingSystem.Application.Service
{
    public class AuditService
    {
        private static AuditService _ins;
        public static AuditService Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new AuditService();
                return _ins;
            }
            set
            {
                _ins = value;
            }
        }      
        public void Record(string _user, string _event)
        {
            try
            {
                var newRecord = new Audit()
                {
                    EvTime = DateTime.Now,
                    EvUser = _user,
                    EvMessage = _event,
                };
                DataProvider.Ins.DB.Audits.Add(newRecord);
                DataProvider.Ins.DB.SaveChanges();
            }
            catch
            {
                //test
            }
        }

        public IEnumerable<ReportAuditVM> GetReportAudit(DateTime from, DateTime to, string _userkw)
        {
            try
            {
                var res = DataProvider.Ins.DB.Audits
                .Where(x => x.EvTime >= from && x.EvTime <= to && x.EvUser.Contains(_userkw))
                .Select(x => new ReportAuditVM()
                {
                    ID = x.ID,
                    EvTime = x.EvTime,
                    EvUser = x.EvUser,
                    EvMessage = x.EvMessage,
                }).ToList();
                return res;
            }
            catch
            {
                return null;
            }

        }
    }
}
