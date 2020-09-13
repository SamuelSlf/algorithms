using System;
using Xunit;

namespace CSharpAlgorithms.Tests
{
    public class BinarySearchTests
    {
        private readonly IBinarySearch _binarySearch;

        public BinarySearchTests()
        {
            _binarySearch = new BinarySearch();
        }

        [Theory]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 4, 0)]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 16, 3)]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 23, 4)]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 42, 5)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 8, 7)]
        [InlineData(new int[] { 1, 3, 5, 7, 9, 11, 23, 55, 99 }, 9, 4)]
        [InlineData(new int[] { 1, 3 }, 3, 1)]
        [InlineData(new int[] { 1, 3, 5, 7, 9, 11, 23, 55, 99 }, 8, -1)]
        public void BinarySearch_ShouldReturnRigthPosition(int[] input, int target, int expected)
        {
            // Arrange

            // Act
            int result = _binarySearch.Execute(input, target);

            // Assert
            Assert.Equal(result, expected);
        }
    }
}
