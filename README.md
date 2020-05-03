# mutable-string

[![Build Status](https://travis-ci.org/vanashimko/mutable-string.svg?branch=master)](https://travis-ci.org/vanashimko/mutable-string)

Funny example of how two different strings can be equal:

```csharp

Assert.That("test", Is.EqualTo("teot"));

```

See [tests](https://github.com/vanashimko/mutable-string/blob/master/MutableString.Tests/MutableStringTests.cs).

Also see related StackOverflow [question](https://stackoverflow.com/questions/58705351/why-does-using-fieldoffset0-in-c-sharp-end-up-with-different-pointers-for-char).

