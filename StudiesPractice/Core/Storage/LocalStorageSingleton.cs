using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiesPractice.Core.Storage
{
    public static class LocalStorageSingleton
    {
        public static List<string> LocalStorage = new() {
            "1x1",
            "2x2",
            "3x3",
            "4x4",
            "5x5",
            "6x6",
            "7x7",
            "8x8",
            "9x9",
            "10x10"
        };
    }
}
