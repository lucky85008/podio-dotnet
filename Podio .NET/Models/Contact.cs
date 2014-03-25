﻿using Newtonsoft.Json;
using System;
using System.Globalization;

namespace PodioAPI.Models
{
    public class Contact
    {
        [JsonProperty("profile_id")]
        public int ProfileId { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The file id of the avatar
        /// </summary>
        [JsonProperty("avatar")]
        public int Avatar { get; set; }

        public DateTime? BirthDate {
            get
            {
                if (!string.IsNullOrEmpty(BirthDateString))
                    return DateTime.ParseExact(BirthDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                return null;
            }
            set 
            { 
                BirthDateString = value.Value.ToString("yyyy-MM-dd"); 
            } 
        }

        [JsonProperty("birthdate")]
        internal string BirthDateString { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("vatin")]
        public string Vatin { get; set; }

        [JsonProperty("skype")]
        public string Skype { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("address")]
        public String[] Address { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("im")]
        public String[] IM { get; set; }

        [JsonProperty("location")]
        public String[] Location { get; set; }

        [JsonProperty("mail")]
        public String[] Mail { get; set; }

        [JsonProperty("phone")]
        public String[] Phone { get; set; }

        [JsonProperty("title")]
        public String[] Title { get; set; }

        [JsonProperty("url")]
        public String[] Url { get; set; }

        [JsonProperty("skill")]
        public String[] Skill { get; set; }

        [JsonProperty("linkedin")]
        public string LinkedIn { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("space_id")]
        public int? SpaceId { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("rights")]
        public String[] Rights { get; set; }

        [JsonProperty("app_store_about")]
        public string AboutAppStore { get; set; }

        [JsonProperty("app_store_organization")]
        public string AppStoreOrganization { get; set; }

        [JsonProperty("app_store_location")]
        public string AppStoreLocation { get; set; }

        [JsonProperty("app_store_title")]
        public string AppStoreTitle { get; set; }

        [JsonProperty("app_store_url")]
        public string AppStoreUrl { get; set; }

        [JsonProperty("last_seen_on")]
        public DateTime? LastSeenOn { get; set; }

        [JsonProperty("is_employee")]
        public bool? IsEmployee { get; set; }

        // Only available for space contacts

        [JsonProperty("role")]
        public int? Role { get; set; }

        [JsonProperty("removable")]
        public bool? Removable { get; set; }

        [JsonProperty("image")]
        public FileAttachment Image { get; set; }
       
    }
}