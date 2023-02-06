using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Model
{
    public class CustomResponse
    {
        public bool Success { get; set; }
        
    }

    public class CustomResponse<T>:CustomResponse where T : class
    {
        public T Data { get; set; }

    }


}
