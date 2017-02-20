using System;
using ADT;
using Xunit;

namespace Stack.Tests
{
    public class Tests
    {
        private readonly IStack<int> _sut;

        public Tests()
        {
            _sut = new Stack<int>(5);
        }

        [Fact]
        public void Push()
        {
            //Given

            //When
            _sut.Push(5);

            //Then
            Assert.Equal(_sut.Size(), 1);
        }

        [Fact]
        public void Push_ThrowsWhenFull()
        {
            //Given
            for (var i = 0; i < 5; i++)
                _sut.Push(i);

            //When

            //Then
            Assert.Throws<Exception>(() => _sut.Push(10));
        }

        [TheoryAttribute]
        [InlineDataAttribute(new int[] { 0 }, 0, 0)]
        [InlineDataAttribute(new int[] {1, -2}, -2, 1)]
        public void Pop(int[] data, int expectedItem, int expectedSize)
        {
            //Given
            foreach (var item in data)
                _sut.Push(item);

            //When
            var result = _sut.Pop();

            //Then
            Assert.Equal(expectedItem, result);
            Assert.Equal(expectedSize, _sut.Size());
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
