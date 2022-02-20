using IntegrationEvent.Events.Attributes;
using IntegrationEvent.Interfaces;
using Newtonsoft.Json;
using System;

namespace File.Application.Commands
{
    [EventName("createFile")]
    public class CreateFileCommand : IIntegrationEvent
    {
        [JsonProperty("fileName")]
        public string FileName { get; init; }
        [JsonProperty("bucketName")]
        public string BucketName { get; init; }
        [JsonProperty("body")]
        public string Body { get; init; }
        [JsonProperty("guid")]
        public Guid Guid { get; init; }
        [JsonProperty("createDateTime")]
        public DateTime CreateDateTime { get; init; }
    }
}
