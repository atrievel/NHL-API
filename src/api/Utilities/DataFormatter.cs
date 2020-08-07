using System;

namespace NHL_API.Utilities
{
    public static class DataFormatter
    {
        public static string SplitSeasonYears(string years)
        {
            if(string.IsNullOrEmpty(years) || years.Length != 8)
            {
                throw new ArgumentException("Years cannot be null or less than 8 characters");
            }

            return years.Substring(0, 3) + " - " + years.Substring(4);
        }

        public static int GetIdFromLink(string link)
        {
            if (string.IsNullOrEmpty(link) || !link.Contains('/') || string.Equals("null", link))
            {
                throw new ArgumentException("Link cannot be null or was formatted incorrectly");
            }

            return Convert.ToInt32(link.Split('/')[^1]);  // id is always the last element of the array, ex: /api/v1/venues/5034
        }
    }
}
