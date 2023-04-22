using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDI.Context;

public class SearchContext
{
    public SearchContext()
    {
        this.searchTerm = String.Empty;
    }
    public String searchTerm;
}
