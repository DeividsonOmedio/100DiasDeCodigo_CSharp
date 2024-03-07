using Bogus;
using Domain.Interfaces.ServicesInterfaces;
using Domain.Services;
using Entities.Entities;
using FluentAssertions;
using Moq;
using Xunit;

namespace Auction.Test
{
    public class CreateOfferServiceTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void SucessOffer(int itemId)
        {
            //ARRANGE
            var request = new Faker<RequestCreateOfferJson>()
                .RuleFor(request => request.Price, f => f.Random.Decimal(50, 500)).Generate();

            var offerRepository = new Mock<ICreateOfferService>();

            var execute = new CreateOfferService(offerRepository.Object);

            //ACT
            var act = () => execute.Execute(itemId, request);

            //ASSERT
            act.Should().NotThrowAsync();
        }
    }
}
