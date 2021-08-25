using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Static
{
    public static class Endpoints
    {
        private static string Prefix = "api";

        public static string BookingsEndpoint = $"{Prefix}/bookings";
        public static string CustomersEndpoint = $"{Prefix}/customers";
        public static string ColoursEndpoint = $"{Prefix}/colours";
        public static string MakesEndpoint = $"{Prefix}/makes";
        public static string ModelsEndpoint = $"{Prefix}/models";
        public static string VehiclesEndpoint = $"{Prefix}/vehicles";

    }
}
