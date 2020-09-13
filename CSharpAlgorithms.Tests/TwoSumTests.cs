using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpAlgorithms.Tests
{
    public class TwoSumTests
    {
        private readonly ITwoSum _twoSum;

        public TwoSumTests()
        {
            _twoSum = new TwoSum();
        }

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSum_ShouldReturnExpected(int[] nums, int target, int[] expected)
        {
            // Arrange

            // Act
            var result = _twoSum.Execute(nums, target);

            // Assert
            Assert.Equal(result, expected);
        }
    }
}
