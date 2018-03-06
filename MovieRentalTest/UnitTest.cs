namespace MovieRental
{
    using System;
    using NUnit.Framework;
    
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestStatement()
        {
            Movie movie = new Movie("Transformer", Movie.REGULAR);

            Rental rental = new Rental(movie, 3);

            Customer customer = new Customer("jpartogi");
            customer.AddRental(rental);

            String statement = customer.Statement();
            StringAssert.Contains("Transformer", statement);
        }
    }
}
