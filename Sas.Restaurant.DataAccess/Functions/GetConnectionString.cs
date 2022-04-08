using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sas.Restaurant.DataAccess.Functions
{
    public class GetConnectionString
    {
        private static string FilePath = Application.StartupPath + "\\Connection.dat";
        public static string Get()
        {
            if (File.Exists(FilePath)
            {
                File.ReadAllText
            }
        }
    }
}
