using CarCollectionsModel;
using System.Collections.Generic;


namespace CarCollectionsDL;

    public class AdminData
    {
        List<Admin> adminList = new List<Admin>();

        public AdminData() 
        {
            CreateAdminData();
        }

        private void CreateAdminData()
        {
            Admin adminOne = new Admin { adminNumber = "OBRA-0001", adminPassword = "OBRA1"};
            adminList.Add(adminOne);

            Admin adminTwo = new Admin { adminNumber = "OBRA-0002", adminPassword = "OBRA2" };
            adminList.Add(adminTwo);

            Admin adminThree = new Admin { adminNumber = "OBRA-0003", adminPassword = "OBRA3" };
            adminList.Add(adminThree);


        }

        public Admin GetAdmin(string adminNumber, string adminPassword)
        {
            Admin foundAdmin = new Admin();

            foreach (var admins in adminList)
            {
                if (adminNumber == admins.adminNumber && adminPassword == admins.adminPassword)
                {
                    foundAdmin = admins;
                }
            }
            return foundAdmin;
        }

    }

