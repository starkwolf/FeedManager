using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedManager.Models
{
    public class DriverDeclaration
    {
        int driverDeclarationId;
        string fileNumber;
        int companyId;

        string staffNumber;
        Int16 salutationId;
        string firstname;
        string lastname;
        string emailAddress;

        Int16 affiliationId;
        Int16 driverDeclarationStatusId;
        DateTime driverDeclarationExpiryDate;

        int createdById;
        DateTime createdDate;
        int amendedById;
        DateTime amendedDate;

    }

}