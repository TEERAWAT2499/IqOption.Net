﻿using iqoptionapi.ws.@base;
using IqOptionApi.Models;
using IqOptionApi.ws.request;
using Newtonsoft.Json;

namespace IqOptionApi.ws {


    public class GetCandleItemsResultMessage : WsMessageBase<CandleCollections> {

        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }

    public class CurrentCandleInfoResultMessage : WsMessageBase<CurrentCandle> {

    }
}