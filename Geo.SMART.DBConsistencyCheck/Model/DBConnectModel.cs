namespace Geo.SMART.DBConsistencyCheck.Model
{
    /// <summary>
    /// 資料庫連線
    /// </summary>
    public class DBConnectModel
    {
        /// <summary>
        /// 伺服器名稱或IP
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// 資料庫名稱
        /// </summary>
        public string DBName { get; set; }

        /// <summary>
        /// 使用者帳號
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 連線字串
        /// </summary>
        public string ConnectionString =>
            $"Data Source={ServerName};Initial Catalog={DBName};User Id={Account};Password={Password};MultipleActiveResultSets=True;";
    }
}
