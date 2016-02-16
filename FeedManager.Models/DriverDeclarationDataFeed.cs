using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedManager.Models
{
    public class DriverDeclarationDataFeed
    {
        DateTime extractDate;
        string fileNumber;
        Int16 recordCount;

        List<DriverDeclaration> driverDeclarationList;

        int createdById;
        DateTime createdDate;
    }


}