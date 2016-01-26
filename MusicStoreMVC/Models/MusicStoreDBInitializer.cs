using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreMVC.Models
{
    public class MusicStoreDBInitializer: DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name = "Cult of Luna" });
            context.Genres.Add(new Genre { Name = "Post-metal" });
            context.Albums.Add(new Album
                                    {
                                        Artist = new Artist { Name="Primus"},
                                        Genre = new Genre { Name="Rock"},
                                        Price=5.99m,
                                        Title="Sailing in the Seas of Cheese"
                                    });
            base.Seed(context);
        }
    }
}
