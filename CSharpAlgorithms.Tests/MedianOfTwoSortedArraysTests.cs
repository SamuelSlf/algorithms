using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpAlgorithms.Tests
{
    public class MedianOfTwoSortedArraysTests
    {
        private readonly IMedianOfTwoSortedArrays _medianOfTwoSortedArrays;

        public MedianOfTwoSortedArraysTests()
        {
            _medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
        }

        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        [InlineData(new int[] { 0, 0 }, new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { }, new int[] { 1 }, 1)]
        [InlineData(new int[] { 2 }, new int[] { }, 2)]
        [InlineData(new int[] { 13, 15, 18 }, new int[] { 21, 32, 45, 46 }, 21)]
        [InlineData(new int[] { 15, 18, 21, 32 }, new int[] { 38, 40 }, 26.5)]

        public void Median_ShouldReturnExpected(int[] nums1, int[] nums2, decimal expected)
        {
            // Arrange

            // Act
            var result = _medianOfTwoSortedArrays.Execute(nums1, nums2);

            // Assert
            Assert.Equal(result, expected);
        }
    }
}
