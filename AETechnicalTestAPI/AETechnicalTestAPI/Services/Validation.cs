using System.Data;

namespace AETechnicalTestAPI.Services
{
    public class Validation
    {
        public static bool CSVValidationChecks(string[] csvdata)
        {
            if (csvdata.Length < 7)
            {
                return false;
            }
            

            return true;
        }
    }
}
