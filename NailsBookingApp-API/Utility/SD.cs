﻿namespace NailsBookingApp_API.Utility
{
    /// <summary>
    /// STATIC DETAILS CLASS
    /// </summary>
    public static class SD
    {
        public const string SD_Storage_Container = "fullstack-store";
        public const string Role_Admin = "admin";
        public const string Role_Customer = "customer";

        public const string status_pending = "Pending";
        public const string status_confirmed = "Confirmed";
        public const string status_beingCooked = "Being Cooked";
        public const string status_readyForPickUp = "Ready for Pickup";
        public const string status_Completed = "Completed";
        public const string status_Cancelled = "Cancelled";

        public const string blobContainerName = "nailscontainer";
        public const string actualWebsite = "https://nailsbookingapp.netlify.app";

        public const string error = "All sections executed, unidentified error, contact server admin";
    }
}
