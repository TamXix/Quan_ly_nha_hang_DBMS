using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.PresentationLayer
{
     public class cAccount
    {
        private string user;
        private string passWord;
        private string ten;
        private int id;
        private int isAdmin;
        private string sex;
        private DateTime dateOfBirth;
        private string identityCard;
        private string address;
        private string phoneNumber;
        private string work;
        private DateTime startDay;
        private int shift;

        public string PassWord { get => passWord; set => passWord = value; }
        public string Ten { get => ten; set => ten = value; }
        public int IsAdmin { get => isAdmin; set => isAdmin = value; }
        public string User { get => user; set => user = value; }
        public int Id { get => id; set => id = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string IdentityCard { get => identityCard; set => identityCard = value; }
        public string Address { get => address; set => address = value; }
        public DateTime StartDay { get => startDay; set => startDay = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Work { get => work; set => work = value; }
        public int Shift { get => shift; set => shift = value; }

        public cAccount(DataRow row)
        {
            try
            {
                this.User = row["USERNAME"].ToString();
                this.Id = Convert.ToInt32(row["IDEMPLOYEE"]);
                this.ten = row["NAME"].ToString();
                this.isAdmin = Convert.ToInt32(row["ISADMIN"]);

                this.PassWord = row["PASSWORD"].ToString();
                this.sex = row["SEX"].ToString();
                this.dateOfBirth = (DateTime)row["DATEOFBIRTH"];
                this.phoneNumber = row["PHONENUMBER"].ToString();
                this.identityCard = row["IDENTITYCARD"].ToString();
                this.address = row["ADDRESS"].ToString();
                this.work = row["WorkName"].ToString();
                this.startDay = (DateTime)row["STARTDAY"];
                this.shift = Convert.ToInt32(row["SHIFT"]);
            }
            catch { };
        }
        public cAccount()
        { }
    }
}
