using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBuessinesLayer
{
    public class clsCountries
    {
        public static string GetCountryNameByID(int countryID)
        {
            // Assuming clsDataCountries.GetCountryByID is a method that retrieves the country name by ID
            return DataAcessLayer.clsDataCountries.GetCountryByID(countryID);
        }
      public static DataTable GetAllCountries()
        {
            // Assuming clsDataCountries.GetAllCountries is a method that retrieves all countries
            DataTable countries = DataAcessLayer.clsDataCountries.GetAllCountry();
          
            return countries;
        }
    }
}
