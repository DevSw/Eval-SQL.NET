###Eval .NET expression in SQL stored procedure, function and trigger.###

*From simple expression*
```csharp
int result = Eval.Execute<int>("x + y", new { x = 1, y = 2})
```
*To complex code*
```csharp
var sum = Eval.Execute(@"var list = new List<int>(x, y, z);
return list.Where(x => x > 2).Sum(x);", new { x = 1, y = 2, z = 3 });
```

## Download
zip file...

*Setup script*

1. Open the script with Microsoft SQL Server Management Studio (SSMS).
2. Change script mode to SQLCMD Mode (Query -> SQLCMD Mode).
3. Change DatabaseName variable for your database name (See 'CHANGE ME' section).
4. Run the sql script in your database server to install assemblies & objects.

## Eval
**Evaluate and execute a code or expression.**

*Using Anonymous Class*
```csharp
int result = Eval.Execute<int>("x + y", new { x = 1, y = 2})
```

*Using Ordinal Value*
```csharp
int result = Eval.Execute<int>("{0} + {1}", x, y)
```

*Using Extension Methods*
```csharp
string s = "x + y";
int result = s.Eval<int>(new { x = 1, y = 2 });
```
[Learn more](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)

## Eval.Compile
**Compile the code or expression and return a delegate of type Func or Action to execute.**

*Using custom Delegate*
```csharp
int result = Eval.Compile<Func<int>>("x + y", new { x = 1, y = 2})
```

*Using Extension Methods*
```csharp
string code = "x + y";
var compiled = code.Compile<Func<int, int>>("x", "y");
foreach(var item in list)
{
}
```
[Learn more](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)

## Free VS Pro
Features | FREE Version | [PRO Version](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)
------------ | ------------- | -------------
Maximum Characters | 50 | Unlimited
Maximum Variables | 2 | Unlimited
Learn more about the [PRO Version](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)

## Support
- [Documentation](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)
- [Forum](https://zzzprojects.uservoice.com/forums/327759-eval-expression-net)
- sales@zzzprojects.com

Contact our outstanding customer support for any request. We usually answer within the next business day, hour, or minutes!

## More Projects
  - [Entity Framework Plus.NET](sales@zzzprojects.com)
  - [NET Bulk Operations](sales@zzzprojects.com)
  - [Eval Expression.NET](sales@zzzprojects.com)
  - [Eval SQL.NET](sales@zzzprojects.com)


