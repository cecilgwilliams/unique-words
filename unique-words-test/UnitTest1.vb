Imports System.Text
Imports FluentAssertions
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports unique_words

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestCountsSingleWord()
        Dim inputPage As New _Default()
        Const input As String = "hello"

        Dim result = inputPage.GetCount(input)

        result.Count().ShouldBeEquivalentTo(1)
        result.Item(input).ShouldBeEquivalentTo(1)
    End Sub

    <TestMethod()> Public Sub TestCountsMultipleWords()
        Dim inputPage As New _Default()
        Const input As String = "hello hello goodbye goodbye hello"

        Dim result = inputPage.GetCount(input)

        result.Count().ShouldBeEquivalentTo(2)
        result.Should().Contain("hello", 3)
        result.Should().Contain("goodbye", 2)
    End Sub

End Class