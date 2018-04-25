﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization; //step1
namespace Sprint1
{
    [DataContract]//step2
    public class client
    {
        private string name_client;
        private string address;
        private string cell_client;
        private int id_client;
        private string device;
        
        
        private string problem;
        //private int rate;
        private string mail;
        private string comment;
        private string complaint;

        [DataMember]   //Step3
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        [DataMember]
        public string Cell_client
        {
            get
            {
                return cell_client;
            }

            set
            {
                cell_client = value;
            }
        }
        [DataMember]
        public string Comment
        {
            get
            {
                return comment;
            }

            set
            {
                comment = value;
            }
        }
        [DataMember]
        public string Complaint
        {
            get
            {
                return complaint;
            }

            set
            {
                complaint = value;
            }
        }
        [DataMember]
        public string Device
        {
            get
            {
                return device;
            }

            set
            {
                device = value;
            }
        }




        [DataMember]
        public string Name_client
        {
            get
            {
                return name_client;
            }

            set
            {
                name_client = value;
            }
        }
        [DataMember]
        public string Problem { get => problem; set => problem = value; }
        [DataMember]
        public string Mail { get => mail; set => mail = value; }
        [DataMember]
        public int Id_client { get => id_client; set => id_client = value; }

        /*public static Repairer Repair()
        {

        }*/
    }
}