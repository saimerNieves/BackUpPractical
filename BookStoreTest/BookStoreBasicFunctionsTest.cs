using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MidtermPractical;
namespace BookStoreTest
{
    public class BookStoreBasicFunctionsTest
    {

        [Fact]

        public void GetBookByBookTitleTest()
        {
            var result = BookStoreBasicFunctions.GetAllBooksByBookTitle("The Travels of Marco Polo");

            Assert.True(result.Count==1);

        }


        [Fact]

        public void GetAllBooks()
        {
            var result = BookStoreBasicFunctions.GetAllBooks();

            Assert.True(result.Count == 2);


        }

        [Fact]

        public void GetAllBooksByAuthorLastNameTest()
        {
            var result = BookStoreBasicFunctions.GetAllBooksByAuthorLastName("polo");

            Assert.True(result.Count == 1);

        }




    }
}
