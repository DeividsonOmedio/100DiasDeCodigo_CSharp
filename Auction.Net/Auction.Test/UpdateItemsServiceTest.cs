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
    public class UpdateItemsServiceTest
    {
        [Fact]
        public async Task GetAllItems_ShouldReturnListOfItemModels()
        {
            // ARRANGE
            var items = new Faker<ItemModel>()
                .RuleFor(item => item.Id, f => f.Random.Number(1, 500))
                .RuleFor(item => item.Name, f => f.Lorem.Word())
                .RuleFor(item => item.Brand, f => f.Lorem.Word())
                .RuleFor(item => item.Condition, f => f.PickRandom<ConditionItemEnum>())
                .RuleFor(item => item.BasePrice, f => f.Random.Decimal(20, 500))
                .RuleFor(item => item.AuctionId, f => f.Random.Number(1, 500))
                .Generate(3);  // Gerar uma lista de 3 elementos

            var mock = new Mock<IUpdateItemsService>();
            mock.Setup(i => i.GetAllItems()).ReturnsAsync(items);

            var result = new UpdateItemsService(mock.Object);

            // ACTION
            var resultItems = await result.GetAllItems();

            // ASSERT
            resultItems.Should().NotBeNull();
            resultItems.Should().BeOfType<List<ItemModel>>();
            resultItems.Should().HaveCount(3);
        }
        [Fact]
        public async Task GetItemsById_ShouldReturnListOfItemModels()
        {
            // ARRANGE
            var items = new Faker<ItemModel>()
                .RuleFor(item => item.Id, f => f.Random.Number(1, 500))
                .RuleFor(item => item.Name, f => f.Lorem.Word())
                .RuleFor(item => item.Brand, f => f.Lorem.Word())
                .RuleFor(item => item.Condition, f => f.PickRandom<ConditionItemEnum>())
                .RuleFor(item => item.BasePrice, f => f.Random.Decimal(20, 500))
                .RuleFor(item => item.AuctionId, f => f.Random.Number(1, 500))
                .Generate();  

            var mock = new Mock<IUpdateItemsService>();
            mock.Setup(i => i.GetItemsById(1)).ReturnsAsync(items);

            var result = new UpdateItemsService(mock.Object);

            // ACTION
            var resultItems = await result.GetItemsById(1);

            // ASSERT
            resultItems.Should().NotBeNull();
            resultItems.Should().BeOfType<ItemModel>();
        }
        [Fact]
        public async Task GetItemsByAuction_ShouldReturnListOfItemModels()
        {
            // ARRANGE
            var items = new Faker<ItemModel>()
                .RuleFor(item => item.Id, f => f.Random.Number(1, 500))
                .RuleFor(item => item.Name, f => f.Lorem.Word())
                .RuleFor(item => item.Brand, f => f.Lorem.Word())
                .RuleFor(item => item.Condition, f => f.PickRandom<ConditionItemEnum>())
                .RuleFor(item => item.BasePrice, f => f.Random.Decimal(20, 500))
                .RuleFor(item => item.AuctionId, f => f.Random.Number(1, 500))
                .Generate(3);  // Gerar uma lista de 3 elementos

            var mock = new Mock<IUpdateItemsService>();
            mock.Setup(i => i.GetItemsByAuction(1)).ReturnsAsync(items);

            var result = new UpdateItemsService(mock.Object);

            // ACTION
            var resultItems = await result.GetItemsByAuction(1);

            // ASSERT
            resultItems.Should().NotBeNull();
            resultItems.Should().BeOfType<List<ItemModel>>();
            resultItems.Should().HaveCount(3);
        }
        [Fact]
        public async Task CreateNewItem_ShouldReturnCreatedItem()
        {
            // ARRANGE
            var newItem = new Faker<ItemModel>().Generate();
            var mock = new Mock<IUpdateItemsService>();
            mock.Setup(i => i.CreateNewItem(newItem)).ReturnsAsync(newItem);
            var result = new UpdateItemsService(mock.Object);

            // ACTION
            var createdItem = await result.CreateNewItem(newItem);

            // ASSERT
            createdItem.Should().NotBeNull();
            createdItem.Should().Be(newItem);
        }

        [Fact]
        public async Task DeleteItem_ShouldReturnSuccessMessage()
        {
            // ARRANGE
            var itemId = 1;
            var successMessage = "Item deleted successfully.";
            var mock = new Mock<IUpdateItemsService>();
            mock.Setup(i => i.DeleteItem(itemId)).ReturnsAsync(successMessage);
            var result = new UpdateItemsService(mock.Object);

            // ACTION
            var message = await result.DeleteItem(itemId);

            // ASSERT
            message.Should().NotBeNull();
            message.Should().Be(successMessage);
        }
    }
}
