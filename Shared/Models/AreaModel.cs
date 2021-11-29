﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRetail.Share.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AreaModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ObjectId { get; set; }
        //[PrimaryKey]
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string Description { get; set; }
        [JsonProperty]
        public string Icon { get; set; }
        [JsonProperty]
        public int LastUpdate { get; set; }
        [JsonProperty]
        public Dictionary<string, string> Infos { get; set; }
        public AreaModel()
        { }
        public AreaModel ShallowCopy()
        {
            return (AreaModel)this.MemberwiseClone();
        }
        public AreaModel DeepCopy()
        {
            var _tmpSerializeString = JsonConvert.SerializeObject(ShallowCopy());
            return JsonConvert.DeserializeObject<AreaModel>(_tmpSerializeString);
        }

    }
}
