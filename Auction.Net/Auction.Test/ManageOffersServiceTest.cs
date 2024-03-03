using Bogus;
using Domain.Interfaces.ServicesInterfaces;
using Domain.Services;
using Entities.Entities;
using Entities.Enums;
using FluentAssertions;
using Moq;
using Xunit;

namespace Auction.Test
{
    public class ManageOffersServiceTest
    {
        [Fact]
        public void GetAllOffers()
        {
            //ARRANGE
            var entity = new Faker<AuctionModel>()
                .RuleFor(auction => auction.Id, f => f.Random.Number(1, 500))
                .RuleFor(auction => auction.Name, f => f.Lorem.Word())
                .RuleFor(auction => auction.Starts, f => f.Date.Past())
                .RuleFor(auction => auction.Ends, f => f.Date.Future())
                .RuleFor(auction => auction.Items, (f, auction) => new List<ItemModel>
                {
                    new ItemModel
                    {
                        Id = f.Random.Number(1, 100),
                        Name = f.Commerce.ProductName(),
                        Brand = f.Commerce.Department(),
                        BasePrice = f.Random.Decimal(50, 200),
                        Condition = f.PickRandom<ConditionItemEnum>(),
                        AuctionId = auction.Id
                    }
                }).Generate(3);

            var mock = new Mock<IUpdateAuctionService>();
            mock.Setup(i => i.GetCurrent()).ReturnsAsync(entity);

            var result = new UpdateAuctionService(mock.Object);

            // ACTION
            var auction = result.GetCurrent();

            // ASSERT
            auction.Should().NotBeNull();
        }
    }
}
