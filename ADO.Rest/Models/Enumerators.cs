namespace ADO.Rest.Models
{
    [System.ComponentModel.DefaultValue(NonQuery)]
    public enum enumCommandExecutionType
    {
        NonQuery,
        Scalar,
        DataTable,
        DataSet,

        PutItem,
        UpdateItem,
        DeleteItem,
        GetItem,
        Query,
        Scan,
        BatchGetItem,
        CreateBackup
    }
}
