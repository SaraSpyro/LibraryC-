using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCard
{
    class Specifications
    {
        #region [Properties]

        /// <summary>
        /// شماره عضویت داوطلب
        /// </summary>
        public int MembershipNumber { get; set; }

        /// <summary>
        /// نام داوطلب
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// نام خانوادگی داوطلب
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// جنسیت
        /// </summary>
        public bool Gender { get; set; }

        #endregion

        #region [Read_Only Properties]

        /// <summary>
        /// سن
        /// </summary>
        public byte Age
        {
            get
            {
                return (byte)(DateTime.Now.Year - BirthDate.Year);
            }
        }

        /// <summary>
        /// عنوان
        /// </summary>
        public string Title
        {
            get
            {
                return Gender ? "Mr" : "Ms";
            }
        }

        /// <summary>
        /// نام کامل
        /// </summary> 
        public string FullName
        {
            get { return Title + " " + Name + " " + Family; }
        }

        /// <summary>
        /// تاریخ انقضا
        /// </summary>
        public DateTime ExpirationDate
        {
            get
            {
                return DateTime.Now.AddYears(1);
            }
        }

        #endregion

        #region [Constructor]

        public Specifications()
        {
            MembershipNumber = 0000;
            Name = "_DEFAULT_";
            Family = "_DEFAULT_";
            BirthDate = DateTime.Now;
            Gender = true;
            Telephones = new List<Telephone>();
            Emails = new List<Email>();
        }

        public Specifications(int membershipNumber) : this()
        {
            MembershipNumber = membershipNumber;
        }

        public Specifications(int membershipNumber, string name) : this()
        { 
            MembershipNumber = membershipNumber;
            Name = name;
        }

        public Specifications(int membershipNumber, string name, string family ) : this()
        {
            MembershipNumber = membershipNumber;
            Name = name;
            Family = family;
        }

        public Specifications(int membershipNumber, string name, string family, DateTime birthDate) : this()
        {
            MembershipNumber = membershipNumber;
            Name = name;
            Family = family;
            BirthDate = birthDate;
        }

        public Specifications(int membershipNumber, string name, string family, DateTime birthDate, bool gender) : this()
        {
            MembershipNumber = membershipNumber;
            Name = name;
            Family = family;
            BirthDate = birthDate;
            Gender = gender;
        }


        #endregion

        #region [Methods]
        public override string ToString()
        {
            string result = $" MembershipNumber :{MembershipNumber}\n Name : {FullName}\n Age : {Age}\n Exp : {ExpirationDate.Year}\n ";

            if (Telephones.Count > 0)
            {
              result += "*************Telephones*************\n";
                foreach (Telephone item in Telephones)
                {
                    result += item.ToString();
                    result += $"\n";
                }
            }

            if (Emails.Count>0)
            {
              result += " ************Emails*************\n";
                foreach (Email item in Emails)
                {
                    result += item.ToString();
                    result += $"\n";
                }
            }
            
            return result;

        }
        #endregion

        #region [Lists]

        public List<Telephone> Telephones { get; set; }
        public List<Email> Emails { get; set; } 
        #endregion
    }
}
