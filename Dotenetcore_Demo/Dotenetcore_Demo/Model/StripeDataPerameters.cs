using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Drawing;

namespace Dotenetcore_Demo.Model
{
    public class StripeDataPerameters
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? id { get; set; }
        public string? objectt { get; set; }    
        public string? account_country { get; set; }
        public string? account_name { get; set; }
        public string account_tax_ids { get; set; }
        public int? amount_due { get; set; }
        public int? amount_paid { get; set; }
        public int? amount_remaining { get; set; }
        public string application { get; set; }
        public string application_fee_amount { get; set; }
        public int? attempt_count { get; set; }
        public Boolean? attempted { get; set; }
        public Boolean? auto_advance { get; set; }

    }
}
