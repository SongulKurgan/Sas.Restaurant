using Sas.Restaurant.Core.Functions;
using Sas.Restaurant.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using TableDependency.SqlClient.Where;

namespace Sas.Reustrant.Core.Monitors
{
   public class SqlMonitor<T>: IDisposable where T: class,IEntity,new()
    {
        private readonly SqlTableDependency<T> tableDependency;  //readonly=>dışarıdan müdahaleye biraz daha kapalı
        public RecordChangedEventArgs<T> ChangedRecord;
        public ErrorEventArgs DependencyError;
        public Action OnChange;
        public SqlMonitor(string tableName,Expression<Func<T,bool>> filter=null,DmlTriggerType monitorType=DmlTriggerType.All)
        {
            tableDependency = new SqlTableDependency<T>(ConnectionStringInfo.Get(),tableName,filter:new SqlTableDependencyFilter<T>(filter),notifyOn:monitorType);
            tableDependency.Stop();tableDependency.OnChanged += Changed;
            tableDependency.OnError += Error;
            tableDependency.Start();

        }

        private void Error(object sender, ErrorEventArgs e)
        {
            DependencyError = e;
            tableDependency.Stop();
            tableDependency.OnChanged -= Changed;
            tableDependency.OnChanged += Changed;
            tableDependency.Start();
        }

        private void Changed(object sender, RecordChangedEventArgs<T> e)
        {
            ChangedRecord = e;
            OnChange();
        }

        public void Dispose()
        {
            tableDependency.Stop();
            tableDependency?.Dispose();
        }
    }
}
