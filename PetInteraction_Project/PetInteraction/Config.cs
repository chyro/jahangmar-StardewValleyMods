using System;
namespace PetInteraction
{
    public class Config
    {
        //public int catch_up_distance { set; get; } = 3;
        public int pet_speed { set; get; } = 6;
        public int pet_fast_speed { set; get; } = 10;
        public int pet_friendship_decrease_onhit = 20;
        public int pet_fetch_friendship_chance = 40;
        public int pet_fetch_friendship_increase = 10;
        public int pet_petting_friendship_increase = 12;
        public float stick_range = 12;
        public bool show_message_on_warp = true;
        public bool unconditional_love = false;
        public bool love_everytime_at_max_friendship = false;

        public string safe_unknown_locations = "Custom_BlueMoonVineyard";
        public bool getLocationSafe(string locationName)
        {
            return this.safe_unknown_locations.Split(',').Contains(locationName);
        }
        public void setLocationSafe(string locationName, bool isSafe)
        {
            List<string> safeLocationNames = this.safe_unknown_locations.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
            if (!isSafe)
            {
                // remove if there (does nothing if not)
                safeLocationNames.Remove(locationName);
            }
            else if (!safeLocationNames.Contains(locationName))
            {
                // add if not there
                safeLocationNames.Add(locationName);
            }
            this.safe_unknown_locations = string.Join(',', safeLocationNames);
        }
    }
}
