using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp_Shared.Utilities.Results.Abstract
{
    //categoriy tek taşıyabilirim , IEnumerable olara veya Liste olarak taşıyabilirim o yüzden out verdik
    public interface IDataResult<out T> : IResult 
    {
        public T Data { get; }// new DataResult<Category>(ResultStatus.Success,category)
    }
}
