using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedManager.Models
{
    public class ChargeCodeDataFeed
    {
        //ICMS Header
        string headerIdentifier;
        string senderIdentification;
        string recipientIdentification;
        string fileType;
        int extractFileNumber;

        //Record Type 0
        Int16 recordTypeId;
        int feedTypeId;
        DateTime extractDateTime;

        List<CodeItem> codeItemList;
        List<ProfitCentre> profitCentreList;


        //ICMS Trailer
        string trailerIdentifier;
        Int16 recordCount;
        string hashTotal;

        int createdById;
        DateTime createdDateTime;
        int amendedById;
        DateTime amendedDateTime;
    }

}