namespace ADO.Rest.Interfaces
{
    using ADO.Rest.Models;
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
