﻿using System;
using Newtonsoft.Json;


namespace TakeBlipTest.Model
{
    public partial class GitHubRepository
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }
    public partial class Owner
    {
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }
    }
}
