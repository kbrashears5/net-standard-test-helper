# Net Standard Test Helpers
Collection of helpers for unit testing with Net Standard

## Usage
Use the static class `TestHelper` to help assert guard clause, exceptions, and more.

### Test Values
Use the static class `TestValues` to use some common objects in a way that doesn't clutter your testing, and let your code be your comments for your tests. Pass the following to your functions:
```c#
Class.Function(TestValues.EmptyString);
```
instead of 
```c#
Class.Function(null);
```

### Xunit
```c#
[Fact]
public void Test()
{
    var ex = Assert.Throws<ArgumentNullException>(() => Class.Function(null));

    TestHelper.AssertArgumentNullException(exception: exception,
        parameterName: "parameterName");
}
```

### Nunit
```c#
[TestCase]
public void Test()
{
    var ex = Assert.Throws<ArgumentNullException>(() => Class.Function(null));

    TestHelper.AssertArgumentNullException(exception: exception,
        parameterName: "parameterName");
}
```