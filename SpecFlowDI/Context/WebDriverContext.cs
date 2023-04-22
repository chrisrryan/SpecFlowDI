using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDI.Context;

public class WebDriverContext
{
    public WebDriverContext()
    {
        this.chromeDriver = String.Empty;
    }
    public string chromeDriver;
}
