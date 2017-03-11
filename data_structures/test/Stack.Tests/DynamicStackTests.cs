using System;
using ADT;
using Xunit;

namespace Stack.Tests
{
    public class DynamicStackTests
    {
        private readonly IStack<int> _sut;

        public DynamicStackTests()
        {
            _sut = new DynamicStack<int>();
        }

        [TheoryAttribute]
        [InlineDataAttribute(new int[] { }, 0, 4)]
        [InlineDataAttribute(new int[] { 0, 1 }, 2, 4)]
        [InlineDataAttribute(new int[] {1, -2, 0, 4, 2}, 5, 8)]
        public void Push(int[] data, int expectedSize, int expectedCapacity)
        {
            //Given
            foreach (var item in data)
                _sut.Push(item);

            //When

            //Then
            Assert.Equal(expectedSize, _sut.Size());
            Assert.Equal(expectedCapacity, ((DynamicStack<int>)_sut).Capacity);
        }

        [TheoryAttribute]
        [InlineDataAttribute(new int[] { 0, 1 }, 1, 1, 1, 4)]
        // [InlineDataAttribute(new int[] {1, -2, 0, 4, 2}, 1, 2, 4, 8)]
        // [InlineDataAttribute(new int[] {1, -2, 0, 4, 2}, 3, 0, 2, 4)]
        public void Pop(int[] data, int numerOfPops, int expectedItem, int expectedSize, int expectedCapacity)
        {
            //Given
            foreach (var item in data)
                _sut.Push(item);

            //When
            int result = -1;

            for (var i = 0; i < numerOfPops; i++)
            {
                result = _sut.Pop();
            }

            //Then
            Assert.Equal(expectedItem, result);
            Assert.Equal(expectedSize, _sut.Size());
            Assert.Equal(expectedCapacity, ((DynamicStack<int>)_sut).Capacity);
        }

        [Fact]
        public void Pop_ThrowsWhenEmpty()
        {
            Assert.Throws<Exception>(() => _sut.Pop());
        }

        [Fact]
        public void Peek_ThrowsWhenEmpty()
        {
            Assert.Throws<Exception>(() => _sut.Peek());
        }

        [TheoryAttribute]
        [InlineDataAttribute(new int[] { 1 }, 1, 1)]
        [InlineDataAttribute(new int[] {1, 2, 4}, 4, 3)]
        public void Peek(int[] data, int expectedItem, int expectedSize)
        {
           //Given
            foreach (var item in data)
                _sut.Push(item);

            //When
            var result = _sut.Peek();

            //Then
            Assert.Equal(expectedItem, result);
            Assert.Equal(expectedSize, _sut.Size());
        }

        [TheoryAttribute]
        [InlineDataAttribute(new int[] { }, true)]
        [InlineDataAttribute(new int[] {1, 2, 4}, false)]
        public void IsEmpty(int[] data, bool expected)
        {
            //Given
            foreach (var item in data)
                _sut.Push(item);

            //When
            var result = _sut.IsEmpty();

            //Then
            Assert.Equal(expected, result);
        }

        [TheoryAttribute]
        [InlineDataAttribute(new int[] { }, 0)]
        [InlineDataAttribute(new int[] {1, 2, 4}, 3)]
        public void Size(int[] data, int expected)
        {
            //Given
            foreach (var item in data)
                _sut.Push(item);

            //When
            var result = _sut.Size();

            //Then
            Assert.Equal(expected, result);
        }
    }
}
