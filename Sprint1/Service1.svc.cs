﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Sprint1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool is_login(int id)
        {
            bool login = ClientsRecord.is_login(id);
            return login;
        }
        public int Add_Clients(string name, string problem, string addres, string cellno, string device, string mail)
        {
            int x =ClientsRecord.Add_Clients(name,problem,addres,cellno,device,mail);
            return x;
        }
       
       
        
        public void Add_Repairer(string name, string addres, string cellno, string cnic,int id)
        {
            RepairersRecords.Add_Repairer(name, addres, cellno, cnic,id);
        }
        public bool Repairer_NotBuzy(Repairer r)
        {
            return true;
        }
        public bool Assign_client(client c)
        {
            return true;
        }
        public bool Appoint_client(int id)
        {
            return true;
        }
        /*public Repairer Get_id_repairer(int id)
        {

        }
        public int Give_Bonus(Repairer r)
        {

        }
        public bool Remove_account(Repairer r)
        {

        }
        
        public bool Change_Password(string s)
        {

        }
        public Repairer Check_account(int id)
        {

        }
        public void Issue_Warning(int id)
        {

        }
        public bool Add_order(client c)
        {

        }
        public bool Appoint_Client(client c)
        {

        }
        public int Get_monthly_income()
        {

        }
        public void Remove_order(client c)
        {

        }

        public Repairer Check_account(int id)
        {
            
        }*/
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<Repairer> Get_repairers_list()     //Step5
        {
            return RepairersRecords.repairers;
        }

        public List<client> Get_client_list()
        {
            return ClientsRecord.clients;
        }

        public void make_admin(Admin a)
        {
            
        }

        public Admin get_admin()
        {
            Admin admin = new Admin();
            admin.Name = "Junaid";
            admin.Id = "12345";
            return admin;
        }
    }
}
