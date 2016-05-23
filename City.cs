using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Airplane
{
    class City
    {
        
        private string _cityCode;//کد شهر
        private string _cityName;//نام شهر
        

        private DataTable tblTemp = new DataTable();

        //سازنده پیش فرض
        public City() { }

        //سازنده برای ایجاد شهر 
        public City(string code, string name)
        {
            CityCode = code;
            //اگر کد صحیح وارد شد اسم را وارد کند
            if(CityCode != null)
                CityName = name;
        }

        //کدشهر
        public string CityCode
        {
            get { return _cityCode; }
            set
            {
                //کد شهر باید سه تا باشه
                if (value.Length == 3)
                    _cityCode = value;
                else
                    MessageBox.Show(null, "کد وارد شده صحیح نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
       
        //نام شهر
        public string CityName
        {
            get { return _cityName; }
            set 
            { 
                _cityName = value;
                //ثبت نام شهر در دیتا بیس
                Class1.SetData("INSERT INTO tblCity(city_code,city_name)  VALUES ('" + _cityCode + "',N'" + _cityName + "') ");
            }
        }
 
        //تابع حذف کردن
        public void Delete(string code, string name)
        {
            Class1.SetData("DELETE FROM tblCity WHERE tblCity.city_code = '"+code+"' AND tblCity.city_name = N'"+name+"'");
        }
    }
}
