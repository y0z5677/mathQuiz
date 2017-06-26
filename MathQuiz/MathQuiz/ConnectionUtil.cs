using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MathQuiz
{
    internal class ConnectionUtil
    {
        internal static string GetConnectionString()
        {
            string returnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings["MathQuiz.Properties.Settings.ExamplesConnectionString"];
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}
