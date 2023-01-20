using Shared.ViewModel.EnumFol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ViewModel
{
    public class APIResponse
    {
        public string Description { get; set; } = null;
        public APIResponseCodes Code { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
        public bool HAsErrors => Errors.Any();

    }


    public class APIResponse<T> : APIResponse
    {
        public T Payload { get; set; } = default;
        public int TotalCount { get; set; }
        public string ResponseCode { get; set; } = null;

        public APIResponse(T data = default, string message = "", APIResponseCodes codes = APIResponseCodes.OK, int? totalCount = 0, params string[] errors)
        {
            Payload = data;
            Errors = errors.ToList();
            Code = !errors.Any() ? codes : codes == APIResponseCodes.OK ? APIResponseCodes.ERROR : codes;
            Description =  message;
            TotalCount = totalCount ?? 0;
        }
    }
}
