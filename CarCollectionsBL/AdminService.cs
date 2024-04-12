using CarCollectionsDL;

namespace CarCollectionsBL
{
    public class AdminService
    {
        public bool VerifyAdmin (string adminNumber)
        {
            AdminData admin = new AdminData();
            var result = admin.GetAdmin(adminNumber);
            
            return result.adminNumber !=null ? true : false;
        }
    }
}
