using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Sql;

namespace WCF
{
    // NOTE: If you change the class name "TempService2" here, you must also update the reference to "TempService2" in Web.config.
    public class TempService : ITempService
    {
        
        #region ITempService Members

        public float PobierzTemp()
        {
            DataClasses1DataContext context = new DataClasses1DataContext();

            var temperatury = from t in context.Temperaturas where t.czas > DateTime.Now.AddHours(-24) select t;

            return (float) temperatury.FirstOrDefault().temp;
        }

        #endregion
    }
}
