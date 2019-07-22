namespace Data.Controllers.Helps
{
    public class MenuConectionString
    {
        public string Server { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int Posta { get; set; }

        public MenuConectionString(string server,string Banco, string Usuario, string Senha, int Posta)
        {
            this.Server = server;
            this.Banco = Banco;
            this.Usuario = Usuario;
            this.Senha = Senha;
            this.Posta = Posta;
        }
        public string GetAllConection(string conectionName)
        {
            if (conectionName.Equals("sqlServer"))
                return GetSqlServerConection();
            else if (conectionName.Equals("sqlPostGre"))
                return GetSqlPostgreConection();
            else if (conectionName.Equals("MySql"))
                return GetSqlMySqlConection();
            else if (conectionName.Equals("SqlLite"))
                return GetSqlLiteConection();
            else
                return GetSqlServerLoalConection();
        }
        private string GetSqlLiteConection()
        {
            return "";
        }
        private string GetSqlServerConection()
        {
            return $"Data Source = {Server};Initial Catalog={Banco}; User Id = {Usuario}; Password = {Senha}";
        }
        private string GetSqlPostgreConection()
        {
            return $"server = {Server}; database={Banco}; port=5432; User Id = {Usuario.Trim()}; Password = {Senha.Trim()};";
        }
        private string GetSqlMySqlConection()
        {
            return $"server = {Server}; database={Banco}; port=3306; User Id = {Usuario}; Password = {Senha};";
        }
        private string GetSqlServerLoalConection()
        {
            return string.Format(@"Data Source = (LocalDb)\MSSQLLocalDB; Initial Catalog = '"
                                 + Banco
                                 + "'; Integrated Security = True; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
    }
}
