using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISCM
{
    public interface call_web_service
    {
        string hello_world();
        string[] get_farm_status(string email);
    }
}
