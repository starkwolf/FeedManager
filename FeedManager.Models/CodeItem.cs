using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedManager.Models
{
    public class CodeItem
    {
        int extractFileNumber;
        DateTime extractDateTime;

        string code;
        string type;
        string accountAssignmentCategory;
        string chargeableIndicator;
        string description;
        string contactName;
        string profitCentre;
        string companyCode;
        string userDefinedFileId;
        string valid_for_sales;
        string valid_for_alloc;

        int createdById;
        DateTime createdDate;
        int amendedById;
        DateTime amendedDate;
    }

}