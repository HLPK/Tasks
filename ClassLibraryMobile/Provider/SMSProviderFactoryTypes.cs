using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMSSimulation;

namespace ClassLibraryMobile.Provider {
    public static class SMSProviderFactoryTypes {
        public static SMSProvider GetProviderType(string sType)
        {
            Type pType = Type.GetType("SMSProvider." + sType);
            object oType = Activator.CreateInstance(pType,true);
            return oType as SMSProvider;
        }
    }
}
