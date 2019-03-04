namespace Lab.DAL
{
    public class ApproveAdapter : IApproveAdapter
    {
        public string GetStatus()
        {
            var approve = new Services.Approve();
            return approve.GetStatus();
        }
    }
}