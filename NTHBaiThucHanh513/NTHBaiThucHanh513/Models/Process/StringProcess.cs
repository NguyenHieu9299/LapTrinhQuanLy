using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace NTHBaiThucHanh513.Models.Process
{
    public class StringProcess
    {

        public string AutoGenerateKey(string id) //truyen vao ID vd: ST009
        {
            // khai bao 1 bien de luu tru gia tri khoa chinh duoc sinh ra
            string strkey = ""; //ID moi
            // khai bao cac bien so de luu gia tri phan so va phan chu tach tu tham so id
            string numPart = "", strPart = "";
            int intPart;
            // tach phan so và phan chu
            numPart = Regex.Match(id, @"\d+").Value; //Lay ra phan so của key "013"
            strPart = Regex.Match(id, @"\D+").Value; // Lay ra phanchu cua key ="STD"
            //chuyen numPart sang kieu int va tang len 1 don vi
            intPart = Convert.ToInt16(numPart) + 1; //=> intPart = 14
            // bo sung cac ky tu 0 con thieu
            int Phanso = Convert.ToInt32(numPart) + 1; // 2
            for (int i = intPart.ToString().Length;  i < numPart.Length; i++)
                {
                // chen them ky tu 0
            }
            //gan gia tri strKey

            strkey = strPart +;
                // tra gia tri khoa chinh duoc sinh ra

            return strkey;
        }
    }
}