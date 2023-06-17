namespace Hillel_Lesson25_HW_2;

public class UnitTest1
{

    [Fact]
    public void Result_ConcatenateStrings()
    {
        //Arrange
        var stringManipulator = new StringManipulator();
        string hello = "Hello";
        string everyone = "Everyone";


        //Act
        string result = stringManipulator.ConcatenateStrings(hello, everyone);

        //Assert
        Assert.Equal("HelloEveryone", result);
    }


    [Fact]
    public void Result_GetStringLength()
    {
        //Arrange
        var stringManipulator = new StringManipulator();
        string hello = "Hello";

        //Act
        int result = stringManipulator.GetStringLength(hello);

        //Assert
        Assert.Equal(5, result);
    }


    [Fact]
    public void Result_ReverseString()
    {
        //Arrange
        var stringManipulator = new StringManipulator();
        string pool = "pool";
        string loop = "loop";

        //Act
        string result = stringManipulator.ReverseString(pool);

        //Assert
        Assert.Equal(result, loop);
    }


    [Fact]
    public void Result_IsPalindrome()
    {
        //Arrange
        var stringManipulator = new StringManipulator();
        string civic = "civic";

        //Act
        bool result = stringManipulator.IsPalindrome(civic);

        //Assert
        Assert.True(result);
    }


}
