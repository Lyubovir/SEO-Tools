namespace SeoTools.Data.Seeding
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore.Internal;
    using SeoTools.Data.Models;

    public class GoogleServersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.GoogleServers.Any())
            {
                return;
            }

            using (var streamReader = File.OpenText(@"..\..\Resources\google_Servers.txt"))
            {
                var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines)
                {
                    string[] tokens = line.Split(", ");
                    await dbContext.GoogleServers.AddAsync(new GoogleServer
                    {
                        Country = tokens[0],
                        Tld = tokens[1],
                        Lang = tokens[2],
                    });
                }
            }

            await dbContext.SaveChangesAsync();
        }
    }
}
