using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ViewModel.EnumFol
{
    public enum APIResponseCodes
    {
        [Description("Exception Error")]
        EXCEPTION = -5,

        [Description("Unauthorized Access")]
        UNAUTHORIZED = -4,
        
        [Description("Not Found")]
        NOT_FOUND = -3,
        
        [Description("Invallid Request")]
        INVALID_REQUEST = -2,
        
        [Description("Server error occured, please try again")]
        ERROR = -1,
        
        [Description("SUCCESS")]
        OK = 1,
        
        [Description("FAILED")]
        FAILED = 2
    }
}
