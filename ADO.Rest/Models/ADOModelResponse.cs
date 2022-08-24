using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Rest.Models
{
    public class ADOModelResponse
    {
        public int NonQueryResult { get; set; }

        public object ScalarResult { get; set; }

        public System.Data.DataTable DataTableResult { get; set; }

        public System.Data.DataSet DataSetResult { get; set; }
    }
}
