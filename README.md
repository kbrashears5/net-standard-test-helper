<h1 align="center">Net Standard Test Helpers</h1>

<div align="center">
    
<b>Collection of helpers for unit testing with Net Standard</b>
    
[![Build Status](https://dev.azure.com/kbrashears5/github/_apis/build/status/kbrashears5.net-standard-test-helper?branchName=master)](https://dev.azure.com/kbrashears5/github/_build/latest?definitionId=5&branchName=master)
[![Tests](https://img.shields.io/azure-devops/tests/kbrashears5/github/4)](https://img.shields.io/azure-devops/tests/kbrashears5/github/4)
[![Code Coverage](https://img.shields.io/azure-devops/coverage/kbrashears5/github/4)](https://img.shields.io/azure-devops/coverage/kbrashears5/github/4)

[![nuget](https://img.shields.io/nuget/v/NetStandardTestHelper.svg)](https://www.nuget.org/packages/NetStandardTestHelper/)
[![nuget](https://img.shields.io/nuget/dt/NetStandardTestHelper)](https://img.shields.io/nuget/dt/NetStandardTestHelper)
</div>

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