﻿// ReSharper disable CheckNamespace
using Newtonsoft.Json;

namespace Hangfire.Couchbase.Documents
{
    internal class Counter : DocumentBase
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("counter_type")]
        public CounterTypes Type { get; set; }

        public override DocumentTypes DocumentType => DocumentTypes.Counter;
    }

    internal enum CounterTypes
    {
        Raw = 1,
        Aggregate = 2
    }
}
