using DeseretMegaDesk.Data;
using Microsoft.EntityFrameworkCore;

namespace DeseretMegaDesk.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DeseretMegaDeskContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DeseretMegaDeskContext>>()))
            {
                if (context == null || context.DeskQuote == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.DeskQuote.Any())
                {
                    return;   // DB has been seeded
                }

                context.DeskQuote.AddRange(
                    new DeskQuote
                    {
                        CustomerName = "Tom Bombadil",
                        DeskWidth = 50,
                        DeskDepth = 12,
                        DeskDrawers = 2,
                        RushDays = 0,
                        DesktopMaterial = DesktopMaterial.Oak,
                        QuoteDate = DateTime.Now.Subtract(TimeSpan.FromDays(30)),
                    },
                    new DeskQuote
                    {
                        CustomerName = "Clark Kent",
                        DeskWidth = 48,
                        DeskDepth = 22,
                        DeskDrawers = 3,
                        RushDays = 5,
                        DesktopMaterial = DesktopMaterial.Rosewood,
                        QuoteDate = DateTime.Now.Subtract(TimeSpan.FromDays(12)),
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
