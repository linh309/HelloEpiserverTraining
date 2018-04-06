﻿using EPiServer.Core;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEpiserverSite.Models.Pages
{
    [ContentType(GUID = "bf2a6bbf-5ac1-49fb-aea5-919336501b37")]
    public class CommonPageUpdated: BasePage
    {
        public virtual string MainIntro { get; set; }

        public virtual XhtmlString MainBody { get; set; }
        public virtual ContentArea RelatedContentArea { get; set; }
    }
}