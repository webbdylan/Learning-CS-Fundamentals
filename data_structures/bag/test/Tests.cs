using System;
using Xunit;

public class Tests
{
    private readonly IBagADT<int> _sut;

    public Tests()
    {
        _sut = new BagADT<int>();
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
        IBagADT<int> localSut = new BagADT<int>(3);

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
        Assert.Equal(true, _sut.IsEmpty());
    }
}
