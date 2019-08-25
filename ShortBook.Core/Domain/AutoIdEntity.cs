namespace ShortBook.Domain
{
    /// <summary>
    /// 拥有自增ID的实体
    /// </summary>
    public abstract class AutoIdEntity
    {
        /// <summary>
        /// 标识ID
        /// </summary>
        public long Id { get; set; }
    }
}