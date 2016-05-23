using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Airplane
{
    class Ticket
    {
        
        private int _coponCode;//کد کپن
        private double _cost;//هزینه
        private int _lineCode;//کد خط
        private string _tiketCode;// کد بلیط

        public const int IRLine = 096;//
        //جدولی برای ارتباط با دیتا بیس
        public DataTable tblTicket = new DataTable();

        public string TiketCode
        {
            get { return _tiketCode; }
            set
            {
                //کد باید ده رقمی باشد
                if (value.Length == 10)
                    _tiketCode = value;
            }
        }

        public int CoponCode
        {
            get { return _coponCode; }
            set
            {
                //کد کپن باید تک رقمی باشد
                if (value / 10 == 0)
                    _coponCode = value;

                //ثبت در دیتا بیس اگر کد بلیط نال نبود
                if(TiketCode != null)
                    Class1.SetData("UPDATE tblTiket SET copon_code = " + _coponCode + "WHERE tblTiket.tiket_code ='" + TiketCode + "'");
            }
        }

        public int LineCode
        {
            get { return _lineCode; }
            set 
            { 
                _lineCode = value;

                //ثبت در دیتا بیس اگر کد بلیط نال نبود
                if (TiketCode != null)
                    Class1.SetData("UPDATE tblTiket SET line_code = " + _lineCode + "WHERE tblTiket.tiket_code ='" + TiketCode + "'");
            }
        }

        public double Cost
        {
            get { return _cost; }
            set 
            { 
                _cost = value;

                //ثبت در دیتا بیس اگر کد بلیط نال نبود
                if (TiketCode != null)
                    Class1.SetData("UPDATE tblTiket SET tiket_cost= " + _cost + "WHERE tblTiket.tiket_code ='" + TiketCode + "'");
            }
        }

        //سازنده برای ایجاد بلیط جدید
        public Ticket(string code,int copon,int line, double cost)
         {
            //ثبت مقادیر
            _coponCode = copon;
            _lineCode = line;
            _cost = cost;
            _tiketCode = code;

            //ثبت اطلاعات در دیتا بیس
            Class1.SetData("INSERT INTO tblTiket (tiket_code,copon_code,line_code,tiket_cost)" +
                                     "VALUES('"+TiketCode+"',"+CoponCode+","+LineCode+","+Cost+")");
        }

        //سازنده برای ویرایش و حذف
        public Ticket(string code)
        {
            try
            {
                //کد بلیط صادر شده برای مسافر شامل کدکپن+کدایران+کدبلیط که باید تفکیک کنیم 
                CoponCode = Convert.ToInt32(code.Substring(0, 1));
                TiketCode = code.Substring(4, 10);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //سازنده پیش فرض
        public Ticket()
        { }

        //فراخوانی داده ها
        public void Call(string code)
        {
            try
            {
                //فراخوانی اطلاعات
                CoponCode = Convert.ToInt32(code.Substring(0, 1));
                TiketCode = code.Substring(4, 10);

                //قرار دادن اطلاعات در جدول
                tblTicket = Class1.GetData("SELECT * FROM tblTiket WHERE tblTiket.tiket_code  = '" + TiketCode + "' ");

                //قرار دادن اطلاعات در فیلدهای کلاس
                Cost = Convert.ToDouble(tblTicket.Rows[0][2]);
                LineCode = Convert.ToInt32(tblTicket.Rows[0][3]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //جستجو
        public void Search(string type, string value)
        {
            //پیدا کردن نوع فیلد از اطلاعات گرفته شده از کاربر
            if (type == "شماره کپن")
                type = "copon_code";
            else if (type == "هزینه")
                type = "tiket_cost";
            else
                return;

            //قرار دادن اطلاعات جستجو شده در جدول کلاس
            tblTicket = Class1.GetData("SELECT * FROM tblTiket WHERE tblTiket." + type + " LIKE N'%" + value + "%'");
        }

  
    }
}
