using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Airplane
{
    class Line
    {
        private int _numberOfAircraft;//شماره هواپیما
        private string _destinationCode;//کد مقصد
        private string _sourceCode;//کد مبدا
        private string _dataWent;//تاریخ رفت
        private string _clockWent;//ساعت رفت
        private string _dataReturn;//تاریخ بازگشت
        private string _clockReturn;//ساعت بازگشت

        //جدولی برای ذخیره جواب کوری
        public DataTable tblLine = new DataTable();

        public string ClockWent
        {
            get { return _clockWent; }
            set 
            { 
                _clockWent = value;

                if (NumberOfAircraft != 0)
                //ثبت تاریخ رفت در دیتابیس
                    Class1.SetData("UPDATE tblLine SET line_clockWent= '" + _clockWent+ "'WHERE tblLine.line_code =" + NumberOfAircraft);
            }
        }

        public string DataReturn
        {
            get { return _dataReturn; }
            set
            { 
                _dataReturn = value;

                if (NumberOfAircraft != 0)
                //ثبت تاریخ بازگشت در دیتابیس
                    Class1.SetData("UPDATE tblLine SET line_dateReturn= '" + _dataReturn+ "'WHERE tblLine.line_code =" + NumberOfAircraft);
            }
        }

        public string ClockReturn
        {
            get { return _clockReturn; }
            set 
            { 
                _clockReturn = value;

                if (NumberOfAircraft != 0)
                //ثبت ساعت برگشت در دیتا بیس
                    Class1.SetData("UPDATE tblLine SET line_clockReturn= '" + _clockReturn+ "'WHERE tblLine.line_code =" + NumberOfAircraft);
            }
        }

        public int NumberOfAircraft
        {
            get { return _numberOfAircraft; }
        }

        public string SourceCode
        {
            get { return _sourceCode; }
            set
            {
                _sourceCode = value;

                if (NumberOfAircraft != 0)
                //ثبت نام مبدا در دیتا بیس
                    Class1.SetData("UPDATE tblLine SET line_source = '" + SourceCode + "'WHERE tblLine.line_code =" + NumberOfAircraft);
            }
        }

        public string DestinationCode
        {
            get { return _destinationCode; }
            set
            {
                _destinationCode = value;

                if (NumberOfAircraft != 0)
                //ثبت نام مقصد در دیتا بیس
                    Class1.SetData("UPDATE tblLine SET line_dis= '" + _destinationCode + "'WHERE tblLine.line_code =" + NumberOfAircraft);
            }
        }


        public string DataWent
        {
            get { return _dataWent; }
            set
            {
                _dataWent = value;

                if (NumberOfAircraft != 0)
                //ثبت تاریخ رفت در دیتا بیس
                    Class1.SetData("UPDATE tblLine SET line_dateWent= '" + _dataWent + "'WHERE tblLine.line_code =" + NumberOfAircraft);
            }
        }

        //سازنده برای ایجاد خط جدید
        public Line(string code,string source,string dis, string dwent,string cwent,string dreturn,string creturn)
        {
            //ایجاد کد جدید
            tblLine = Class1.GetData("SELECT TOP 1 tblLine.line_code FROM tblLine ORDER BY tblLine.line_code DESC");
            _numberOfAircraft = Convert.ToInt32( tblLine.Rows[0][0])+ 1;
            //اضافه کردن اطلاعات خط جدید
            _sourceCode = source;
            _destinationCode = dis;
            _dataWent = dwent;
            _dataReturn = dreturn;
            _clockWent = cwent;
            _clockReturn = creturn;

            //ثبت خط جدید در دیتا بیس
            Class1.SetData("INSERT INTO tblLine (line_code,line_source,line_dis,line_dateWent,line_clockWent,line_dateReturn,line_clockReturn)" +
                                     "VALUES("+_numberOfAircraft+",'"+_sourceCode+"','"+_destinationCode+"','"+_dataWent+"','"+_clockWent+"','"+_dataReturn+"','"+_clockReturn+"')");
        }

        //سازنده برای حذف و ویرایش
        public Line(int code)
        {
            _numberOfAircraft = code;
        }

        //سازنده پیش فرض
        public Line()
        { }

        //حذف 
        public void Delete(int code)
        {
            _numberOfAircraft = code;
            //حذف اطلاعات خط از دیتا بیس
            Class1.SetData("DELETE FROM tblLine WHERE tblLine.line_code = "+NumberOfAircraft);
        }

        //فراخوانی داده ها
        public void Call(int code)
        {
            try
            {
                //فراخوانی داده ها از دیتا بیس داخل جدول
                tblLine = Class1.GetData("SELECT * FROM tblLine WHERE tblLine.line_code = " + code);
                //قرار دادن اطلاعات فراخوانی شده داخل فیلدهای کلاس
                SourceCode = tblLine.Rows[0][1].ToString();
                DestinationCode = tblLine.Rows[0][2].ToString();
                DataWent = tblLine.Rows[0][3].ToString();
                DataReturn = tblLine.Rows[0][4].ToString();
                ClockWent = tblLine.Rows[0][5].ToString();
                ClockReturn = tblLine.Rows[0][6].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //جستجو
        public void Search(string type, string value)
        {
            //پیدا کردن نام فیلد دیتابیس از روی انتخاب کاربر
            if (type == "مبدا")
                type = "line_source";
            else if (type == "مقصد")
                type = "line_dis";
            else if (type == "تاریخ رفت")
                type = "line_dateWent";
            else if (type == "تاریخ برگشت")
                type = "line_dateReturn";
            else if (type == "ساعت رفت")
                type = "line_clockWent";
            else if (type == "ساعت برگشت")
                type = "line_clockReturn";
            else
                return;

            //قرار دادن اطلاعات جستجو شده داخل جدول کلاس
            tblLine = Class1.GetData("SELECT * FROM tblLine WHERE tblLine." + type + " LIKE N'%" + value + "%'");
        }
    }
}
