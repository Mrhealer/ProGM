﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGM.Business.Model
{
    public class responseAccountDetail
    {
        public Accountdetail[] accountDetails { get; set; }
    }

    public class Accountdetail
    {
        public string strId { get; set; }
        public string companyId { get; set; }
        public string strParentCompanyId { get; set; }
        public string companyName { get; set; }
        public string strManagerPcIP { get; set; }
        public string strManagerPcMac { get; set; }
        public string strName { get; set; }
        public string strPhoneNumber { get; set; }
        public string strEmail { get; set; }
        public string strFullName { get; set; }
        public string strAvatar { get; set; }
        public string strCityId { get; set; }
        public string strAddress { get; set; }
        public int iActive { get; set; }
        public string iVerifyStatus { get; set; }
        public string iIsEmployee { get; set; }
        public string strCreatedDate { get; set; }
        public string strModifiedDate { get; set; }
        public string strRoleId { get; set; }
        public string strRoleName { get; set; }
        public string strRoleDesc { get; set; }
        public decimal dBalance { get; set; }
    }

}