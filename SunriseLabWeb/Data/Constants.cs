using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunriseLabWeb.Data
{
    public class Constants
    {
        public static string UserLogin = "/User/Login";
        public static string KeyAccountData = "/User/GetKeyAccountData";
        public static string GetUserProfilePicture = "/User/GetUserProfilePicture";
        public static string IP_Wise_Login_Detail = "/User/IP_Wise_Login_Detail";
        public static string LogoutWithoutToken = "/User/LogoutWithoutToken";

        public static string LabDataUpload_Ora = "/LabStock/LabDataUpload_Ora";
        public static string LabStockDataDelete = "/LabStock/LabStockDataDelete";
        public static string LabStockStatusGet = "/LabStock/LabStockStatusGet";
        public static string LabStockRefresh = "/LabStock/LabStockRefresh";
        public static string LabData_ExcelGen = "/LabStock/LabData_ExcelGen";
        public static string LabDataGetURLApi = "/LabStock/LabDataGetURLApi";

        public static string GetSearchParameter = "/LabStock/GetListValue";
        public static string GetUserMas = "/LabStock/GetUserMas";
        public static string UserwiseCompany_select = "/LabStock/UserwiseCompany_select";
        public static string GetApiColumnsDetails = "/LabStock/GetApiColumnsDetails";
        public static string Lab_Column_Auto_Select = "/LabStock/Lab_Column_Auto_Select";
        public static string VendorInfo = "/LabStock/GetVendorInfo";
        public static string GetKeyToSymbolList = "/LabStock/GetKeyToSymbol";

        public static string SaveLab = "/LabStock/SaveLab";
        public static string GetLab = "/LabStock/GetLab";

    }
}