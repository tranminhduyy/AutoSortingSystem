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
    public class SqlService
    {
        private static SqlService _ins;
        public static SqlService Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new SqlService();
                return _ins;
            }
            set
            {
                _ins = value;
            }
        }      
        public bool CheckSqlConnection()
        {
            try
            {
                var res = DataProvider.Ins.DB.Database.Exists();
                return res;
            }
            catch
            {
                return false;
            }
        }
    }
}
