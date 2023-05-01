namespace LeaveManagement.Web.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime LeaveCreated { get; set; }
        public DateTime LeaveModified { get; set; }
    }
}
