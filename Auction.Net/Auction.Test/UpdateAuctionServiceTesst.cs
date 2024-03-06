using Bogus;
using Domain.Interfaces.ServicesInterfaces;
using Domain.Services;
using Entities.Entities;
using Entities.Enums;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Auction.Test
{
    public class UpdateAuctionServiceTesst
    {
        [Fact]
        public void GetAllOAuction()
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
            mock.Setup(i => i.GetAll()).ReturnsAsync(entity);

            var result = new UpdateAuctionService(mock.Object);

            // ACTION
            var auction = result.GetAll();

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        
        [Fact]
        public void GetCurrent()
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
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        
        [Fact]
        public void GetByClosed()
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
                }).Generate(5);

            var mock = new Mock<IUpdateAuctionService>();
            mock.Setup(i => i.GetByClosed()).ReturnsAsync(entity);

            var result = new UpdateAuctionService(mock.Object);

            // ACTION
            var auction = result.GetByClosed();

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        
        [Fact]
        public void GetByDate()
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
                }).Generate(5);

            var mock = new Mock<IUpdateAuctionService>();
            mock.Setup(i => i.GetByDate(DateTime.Now)).ReturnsAsync(entity);

            var result = new UpdateAuctionService(mock.Object);

            // ACTION
            var auction = result.GetByDate(DateTime.Now);

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        
        [Fact]
        public void GetById()
        {
            //ARRANGE
            var entity = new Faker<AuctionModel>()
                .RuleFor(auction => auction.Id, f => f.Random.Number(200, 200))
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
                }).Generate();

            var mock = new Mock<IUpdateAuctionService>();
            mock.Setup(i => i.GetById(200)).ReturnsAsync(entity);

            var result = new UpdateAuctionService(mock.Object);

            // ACTION
            var auction = result.GetById(200);

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        
        [Fact]
        public void GetByName()
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
                }).Generate(5);

            var mock = new Mock<IUpdateAuctionService>();
            mock.Setup(i => i.GetByName("teste")).ReturnsAsync(entity);

            var result = new UpdateAuctionService(mock.Object);

            // ACTION
            var auction = result.GetByName("teste");

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        
        [Fact]
        public void GetByPeriod()
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
                }).Generate(5);

            var mock = new Mock<IUpdateAuctionService>();
            mock.Setup(i => i.GetByPeriod(new DateTime(2024, 02, 25), new DateTime(2024, 03, 25))).ReturnsAsync(entity);

            var result = new UpdateAuctionService(mock.Object);

            // ACTION
            var auction = result.GetByPeriod(new DateTime(2024, 02, 25), new DateTime(2024, 03, 25));

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }
        
        [Fact]
        public void GetByProgrammed()
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
                }).Generate(5);

            var mock = new Mock<IUpdateAuctionService>();
            mock.Setup(i => i.GetByProgrammed()).ReturnsAsync(entity);

            var result = new UpdateAuctionService(mock.Object);

            // ACTION
            var auction = result.GetByProgrammed();

            // ASSERT
            auction.Should().NotBeNull();
            //auction.Id.Should().Be(entity[0].Id);
            //auction[.Name.Should().Be(entity.Name);
        }

        [Fact]
        public async Task ChangeAuction_ShouldReturnUpdatedAuction()
        {
            // ARRANGE
            var id = 1;
            var updatedAuction = new Faker<AuctionModel>().Generate();
            var mock = new Mock<IUpdateAuctionService>();
            mock.Setup(i => i.ChangeAuction(id, updatedAuction)).ReturnsAsync(updatedAuction);
            var result = new UpdateAuctionService(mock.Object);

            // ACTION
            var auction = await result.ChangeAuction(id, updatedAuction);

            // ASSERT
            auction.Should().NotBeNull();
            auction.Should().Be(updatedAuction);
        }

        [Fact]
        public async Task CreateNewAuction_ShouldReturnCreatedAuction()
        {
            // ARRANGE
            var newAuction = new Faker<AuctionModel>().Generate();
            var mock = new Mock<IUpdateAuctionService>();
            mock.Setup(i => i.CreateNewAuction(newAuction)).ReturnsAsync(newAuction);
            var result = new UpdateAuctionService(mock.Object);

            // ACTION
            var auction = await result.CreateNewAuction(newAuction);

            // ASSERT
            auction.Should().NotBeNull();
            auction.Should().Be(newAuction);
        }
    }
}
