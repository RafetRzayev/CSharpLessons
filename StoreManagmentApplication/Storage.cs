using StoreManagmentApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentApplication
{
    class Storage
    {
        public static AdminForm AdminForm { get; set; }

        public static List<User> Users { get; set; } = [new ("Kenan", "1234", UserType.Admin), new ("Ferid", "5555", UserType.Client)];

        public static List<Product> Products { get; set; } =
        [
            new ("Kitab",12),
            new ("Hef", 45),
            new ("Saat", 567)
        ];
    }
}
