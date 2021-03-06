﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JCSoft.WX.Framework.Models.ApiResponses
{
    public class TemplateSendResponse : ApiResponse
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonProperty("msgid")]
        public long MsgID { get; set; } 
    }
}
