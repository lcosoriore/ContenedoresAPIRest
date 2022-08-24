using ADO.Rest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Rest.Interfaces
{
    public interface IADO
    {
        string CurrentConnectionString { get; }

        void SetConnection(string ConnectionString);

        ADOModelResponse ExecuteQuery(ADOModelRequest QueryParams);

        System.Data.IDbDataParameter CreateTypedParameter();

        System.Data.IDbDataParameter CreateTypedParameter(string ParameterName, object ParameterValue);

        ADOModelRequest InitDocumentBatchGetRequest(ADOModelRequest QueryParams);
    }
}
