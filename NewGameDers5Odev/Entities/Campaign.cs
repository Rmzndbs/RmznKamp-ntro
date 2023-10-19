using NewGameDers5Odev.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGameDers5Odev.Entities
{
    public class Campaign:IEntity
    {
        public string  CampaignName { get; set; }
        public int CampaignId { get; set; }
        public int DiscountRate { get; set; }

    }
}
