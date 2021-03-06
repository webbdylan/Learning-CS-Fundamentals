﻿using System;
using ADT;
using Xunit;

namespace Bag.Tests
{
    public class BagTests
    {
        private readonly IBag<int> _sut;

        public BagTests()
        {
            _sut = new Bag<int>();
        }

        [Fact]
        public void Add_IncrementsCount()
        {
            //Given

            //When
            _sut.Add(1);

            //Then
            Assert.Equal(1, _sut.Size());
        }

        [Fact]
        public void Add_ThrowsException_BagIsFull()
        {
            //Given
            IBag<int> localSut = new Bag<int>(3);

            localSut.Add(1);
            localSut.Add(2);
            localSut.Add(3);

            //When

            //Then
            Assert.Throws<Exception>(() => localSut.Add(4));
        }

        [Fact]
        public void Clean_BagIsEmpty()
        {
            //Given
            _sut.Add(1);
            _sut.Add(2);
            _sut.Add(3);

            //When
            _sut.Clean();

            //Then
            Assert.Equal(0, _sut.Size());
        }

        [Fact]
        public void IsEmpty_TrueIfNoItems()
        {
            //Given

            //When
            var result = _sut.IsEmpty();

            //Then
            Assert.True(result);
        }

        [Fact]
        public void Size_ReturnsCountOfItems()
        {
            //Given
            _sut.Add(1);

            //When
            var result = _sut.Size();

            //Then
            Assert.Equal(1, result);
        }
    }
}