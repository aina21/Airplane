using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Airplane
{
    class Passenger
    {
        private int _passengerCode;//کد مسافر
        private string _lastName;//نام خانوادگی مسافر
        private string _name;//نام مسافر
        private string _melliCode;//ملی کد مسافر
        private string _tel;//تلفن مسافر

        //جدولی برای ارتباط با دیتابیس
        public DataTable tblPassenger = new DataTable();

        public string Tel
        {
            get { return _tel; }
            set
            {
                _tel = value;

                if(PassengerCode != 0)
                //ثبت تلفن مشتری در دیتا بیس
                    Class1.SetData("UPDATE tblPerson SET person_tel = N'" + _tel + "'WHERE tblPerson.person_code =" + PassengerCode);
            }
        }

        public string MelliCode
        {
            get { return _melliCode; }
            set 
            {
                _melliCode = value;

                if (PassengerCode != 0)
                //ثبت کد ملی مسافر در دیتا بیس
                    Class1.SetData("UPDATE tblPerson SET person_mellicode = N'" + _melliCode + "'WHERE tblPerson.person_code =" + PassengerCode);
            }
        }

        public string Name
        {
            get { return _name; }
            set 
            {
                _name = value;

                if (PassengerCode != 0)
                //ثبت نام مسافر در دیتابیس
                    Class1.SetData("UPDATE tblPerson SET person_name = N'" + _name + "'WHERE tblPerson.person_code ="+PassengerCode);
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set 
            { 
                _lastName = value;
                
                if (PassengerCode != 0)
                //ثبت نام خانوادگی در دیتابیس
                    Class1.SetData("UPDATE tblPerson SET person_lastName = N'" + _lastName + "'WHERE tblPerson.person_code =" + PassengerCode);
            }
        }

        public int PassengerCode
        {
            get { return _passengerCode; }
        }

         public Passenger(string code,string name,string last, string melli,string tel)
         {
             //ثبت مشتری جدید در فیلدهای کلاس
             _name = name;
             _lastName = last;
             _melliCode = melli;
             _tel = tel;

             //ایجاد کد جدید
            tblPassenger = Class1.GetData("SELECT TOP 1 tblPerson.person_code FROM tblPerson ORDER BY tblPerson.person_code DESC");
            _passengerCode = Convert.ToInt32(tblPassenger.Rows[0][0]) + 1;
             

             //ثبت مسافر جدید
            Class1.SetData("INSERT INTO tblPerson (person_code,person_name,person_lastName,person_mellicode,person_tel)" +
                                     "VALUES("+_passengerCode+",'"+_name+"','"+_lastName+"','"+_melliCode+"','"+_tel+"')");
        }

        //سازنده برای ویرایش و حذف
        public Passenger(int code)
        {
            _passengerCode = code;
        }

        //سازنده پیش فرض
        public Passenger()
        { }

        //حذف 
        public void Delete(int code)
        {
            _passengerCode = code;
            //حذف مسافر از دیتابیس
            Class1.SetData("DELETE FROM tblPerson WHERE tblPerson.person_code = " + PassengerCode);
        }

        //فراخوانی داده ها
        public void Call(int code)
        {
            try
            {
                //فراخوانی اطلاعات از دیتا بیس و قرار دادن در جدول
                tblPassenger = Class1.GetData("SELECT * FROM tblPerson WHERE tblPerson.person_code = " + code);

                //قرار دادن اطلاعات مسافر فراخوانی شده در فیلدهای جدول
                Name = tblPassenger.Rows[0][1].ToString();
                LastName = tblPassenger.Rows[0][2].ToString();
                MelliCode = tblPassenger.Rows[0][3].ToString();
                Tel = tblPassenger.Rows[0][4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //جستجو
        public void Search(string type, string value)
        {
            try
            {
                //پیدا کردن فیلدانتخاب شده کاربر در دیتا بیس
                if (type == "نام")
                    type = "person_name";
                else if (type == "نام خانوادگی")
                    type = "person_lastName";
                else
                    return;

                //وارد کردن اطلاعات داخل جدول کلاس
                tblPassenger = Class1.GetData("SELECT * FROM tblPerson WHERE tblPerson." + type + " LIKE N'%" + value + "%'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
