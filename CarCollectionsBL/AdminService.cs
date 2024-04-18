using CarCollectionsDL;
using CarCollectionsModel;
using System.Collections.Generic;

namespace CarCollectionsBL
{
    public class AdminService
    {
        public bool VerifyAdmin(string adminNumber, string adminPassword)
        {
            AdminData admin = new AdminData();
            var result = admin.GetAdmin(adminNumber, adminPassword);

            return result.adminNumber != null ? true : false;
        }
        
        public List <Car> carcollect = new List<Car> ();
        public List <Car> GetCars()
        {
            Collection callcar = new Collection ();
            return callcar.GetCars();
        }

        public void addCar(Car cars)
        {
            carcollect.Add(cars);
        }
    }   
}
