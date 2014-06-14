using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Repository
{
    public class AlbumRepository
    {
        public static List<Album> GetTopSellingAlbums(int count)
        {
            MusicStoreEntities storeDB = new MusicStoreEntities();
            // Group the order details by album and return
            // the albums with the highest count
            return storeDB.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
    }
}