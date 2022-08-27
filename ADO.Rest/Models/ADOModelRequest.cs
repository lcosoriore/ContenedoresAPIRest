namespace ADO.Rest.Models
{
    public class ADOModelRequest
    {
        public string CommandText { get; set; }

        public List<System.Data.IDbDataParameter> Parameters { get; set; }

        public System.Data.CommandType CommandType { get; set; }

        public enumCommandExecutionType CommandExecutionType { get; set; }

    }
}
