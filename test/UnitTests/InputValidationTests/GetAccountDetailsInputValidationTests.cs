namespace UnitTests.InputValidationTests
{
    using System;
    using Application.Boundaries.GetAccount;
    using Domain.Accounts.ValueObjects;
    using Xunit;

    public sealed class GetAccountDetailsInputValidationTests
    {
        [Fact]
        public void GivenEmptyAccountId_InputNotCreated_ThrowsInputValidationException()
        {
            EmptyAccountIdException actualEx = Assert.Throws<EmptyAccountIdException>(
                () => new GetAccountInput(
                    new AccountId(Guid.Empty)));
            Assert.Contains("accountId", actualEx.Message, StringComparison.OrdinalIgnoreCase);
        }

        [Fact]
        public void GivenValidData_InputCreated()
        {
            var actual = new GetAccountInput(
                new AccountId(Guid.NewGuid()));
            Assert.NotNull(actual);
        }
    }
}
