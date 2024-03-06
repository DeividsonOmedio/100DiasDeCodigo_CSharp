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
            var entity = new Faker<OfferModel>()
                .RuleFor(auction => auction.Id, f => f.Random.Number(1, 500))
                .RuleFor(auction => auction.CreatedOn, f => f.Date.Past())
                .RuleFor(auction => auction.Price, f => f.Random.Decimal(50, 1000))
                .RuleFor(auction => auction.ItemId, f => f.Random.Number(1, 10))
                .RuleFor(auction => auction.UserId, f => f.Random.Number(1, 4))
                .Generate(3);

            var mock = new Mock<IManageOffersService>();
            mock.Setup(i => i.GetAllOffers()).ReturnsAsync(entity);

            var result = new ManageOffersService(mock.Object);

            // ACTION
            var auction = result.GetAllOffers();

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        [Fact]
        public void GetAllOfferByIdAuction()
        {
            //ARRANGE
            var entity = new Faker<OfferModel>()
                .RuleFor(auction => auction.Id, f => f.Random.Number(1, 5))
                .RuleFor(auction => auction.CreatedOn, f => f.Date.Past())
                .RuleFor(auction => auction.Price, f => f.Random.Decimal(50, 1000))
                .RuleFor(auction => auction.ItemId, f => f.Random.Number(1, 10))
                .RuleFor(auction => auction.UserId, f => f.Random.Number(1, 4))
                .Generate(3);

            var mock = new Mock<IManageOffersService>();
            mock.Setup(i => i.GetAllOfferByIdAuction(1)).ReturnsAsync(entity);

            var result = new ManageOffersService(mock.Object);

            // ACTION
            var auction = result.GetAllOfferByIdAuction(1);

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        [Fact]
        public void GetAllOffersByItem()
        {
            //ARRANGE
            var entity = new Faker<OfferModel>()
                .RuleFor(auction => auction.Id, f => f.Random.Number(1, 5))
                .RuleFor(auction => auction.CreatedOn, f => f.Date.Past())
                .RuleFor(auction => auction.Price, f => f.Random.Decimal(50, 1000))
                .RuleFor(auction => auction.ItemId, f => f.Random.Number(1, 10))
                .RuleFor(auction => auction.UserId, f => f.Random.Number(1, 4))
                .Generate(3);

            var mock = new Mock<IManageOffersService>();
            mock.Setup(i => i.GetAllOffersByItem(1)).ReturnsAsync(entity);

            var result = new ManageOffersService(mock.Object);

            // ACTION
            var auction = result.GetAllOffersByItem(1);

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        [Fact]
        public void GetAllOffersByUser()
        {
            //ARRANGE
            var entity = new Faker<OfferModel>()
                .RuleFor(auction => auction.Id, f => f.Random.Number(1, 5))
                .RuleFor(auction => auction.CreatedOn, f => f.Date.Past())
                .RuleFor(auction => auction.Price, f => f.Random.Decimal(50, 1000))
                .RuleFor(auction => auction.ItemId, f => f.Random.Number(1, 10))
                .RuleFor(auction => auction.UserId, f => f.Random.Number(1, 4))
                .Generate(3);

            var mock = new Mock<IManageOffersService>();
            mock.Setup(i => i.GetAllOffersByUser(1)).ReturnsAsync(entity);

            var result = new ManageOffersService(mock.Object);

            // ACTION
            var auction = result.GetAllOffersByUser(1);

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        [Fact]
        public void GetMoreOfferByItem()
        {
            //ARRANGE
            var entity = new Faker<OfferModel>()
                .RuleFor(auction => auction.Id, f => f.Random.Number(1, 5))
                .RuleFor(auction => auction.CreatedOn, f => f.Date.Past())
                .RuleFor(auction => auction.Price, f => f.Random.Decimal(50, 1000))
                .RuleFor(auction => auction.ItemId, f => f.Random.Number(1, 10))
                .RuleFor(auction => auction.UserId, f => f.Random.Number(1, 4))
                .Generate();

            var mock = new Mock<IManageOffersService>();
            mock.Setup(i => i.GetMoreOfferByItem(3)).ReturnsAsync(entity);

            var result = new ManageOffersService(mock.Object);

            // ACTION
            var auction = result.GetMoreOfferByItem(3);

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        [Fact]
        public void GetOffersByUserByItem()
        {
            //ARRANGE
            var entity = new Faker<OfferModel>()
                .RuleFor(auction => auction.Id, f => f.Random.Number(1, 3))
                .RuleFor(auction => auction.CreatedOn, f => f.Date.Past())
                .RuleFor(auction => auction.Price, f => f.Random.Decimal(50, 1000))
                .RuleFor(auction => auction.ItemId, f => f.Random.Number(1, 10))
                .RuleFor(auction => auction.UserId, f => f.Random.Number(1, 4))
                .Generate(3);

            var mock = new Mock<IManageOffersService>();
            mock.Setup(i => i.GetOffersByUserByItem(2,3)).ReturnsAsync(entity);

            var result = new ManageOffersService(mock.Object);

            // ACTION
            var auction = result.GetOffersByUserByItem(2,3);

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        [Fact]
        public void GetOffersInLeiloesActive()
        {
            //ARRANGE
            var entity = new Faker<OfferModel>()
                .RuleFor(auction => auction.Id, f => f.Random.Number(1, 500))
                .RuleFor(auction => auction.CreatedOn, f => f.Date.Past())
                .RuleFor(auction => auction.Price, f => f.Random.Decimal(50, 1000))
                .RuleFor(auction => auction.ItemId, f => f.Random.Number(1, 10))
                .RuleFor(auction => auction.UserId, f => f.Random.Number(1, 4))
                .Generate(3);

            var mock = new Mock<IManageOffersService>();
            mock.Setup(i => i.GetOffersInLeiloesActive()).ReturnsAsync(entity);

            var result = new ManageOffersService(mock.Object);

            // ACTION
            var auction = result.GetOffersInLeiloesActive();

            // ASSERT
            auction.Should().NotBeNull();

            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        [Fact]
        public void GetOffersInLeiloesClosed()
        {
            //ARRANGE
            var entity = new Faker<OfferModel>()
                .RuleFor(auction => auction.Id, f => f.Random.Number(1, 500))
                .RuleFor(auction => auction.CreatedOn, f => f.Date.Past())
                .RuleFor(auction => auction.Price, f => f.Random.Decimal(50, 1000))
                .RuleFor(auction => auction.ItemId, f => f.Random.Number(1, 10))
                .RuleFor(auction => auction.UserId, f => f.Random.Number(1, 4))
                .Generate(3);

            var mock = new Mock<IManageOffersService>();
            mock.Setup(i => i.GetOffersInLeiloesClosed()).ReturnsAsync(entity);

            var result = new ManageOffersService(mock.Object);

            // ACTION
            var auction = result.GetOffersInLeiloesClosed();

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }

       


    }
}
