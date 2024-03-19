# 01 - Namespaces

- Separate the files logically, as they **may have the same name, but in different folders**
- **Normally has the same name as the folder**

```c#
namespace MyApp
{
  class MyClass
  {
    // ...
  }
}

namespace MyApp.Folder2
{
  class MyClass
  {
    // ...
  }
}

namespace MyApp
{
  class MyAnotherClass
  {
    // ...
  }
}
```

- To use a created "namespace", you need to **import it with "using"**

```c#
using MyApp.Folder2;
```

# 02 - Variables and Constants

```c#
// VARIABLES
int idade = 22; // Created and initialized

int idade; // CORRECT: Initialized as ZERO
idade = 22;

var name = "John"; // Created and initialized

var name; // ERROR: With "var" we need to initialize

object name = "John"; // Created and initialized

object name; // CORRECT:: Created without initialization

// CONSTANTS
const int MIN_AGE; // CORRECT: Initialized with ZERO
const int MIN_AGE = 18; // CORRECT

const var MIN_AGE = 20; // ERROR: We cannot use "var" with "const"
const var MIN_AGE; // ERROR: We cannot use "var" with "const"
```

## When should I use "var"?

```c#
  // Before
  IEnumerable<MyComplexType> example = new IEnumerable<MyComplexType>();

  // After
  var example = new IEnumerable<MyComplexType>();
```

## When should I use "object"?

```c#
  object unknownValueType;

  unknownValueType = {unknown value here};
```

# 03 - Primitive and Complex Types

- All types derive from **"System" namespaces**

```c#
// PRIMITIVE

byte byteValue = 255; // from 0 to 255
sbyte byteWithSignal = -128; // from -128 to 127

short age = 21; // ushort (unsigned)
int age = 22; // uint (unsigned)
long age = 23; // ulong (unsigned)


float height = 1.72F;
double height = 1.72;
decimal height = 1.72M;

bool isOpen = true;

char inventoryKey = 'E';
string text = "Hello, World!";

object age = 22;
object name = "John";

// NULLABLE TYPES

void // An empty method return

null // An empty type

int? idade = null; // With "?" the "int" type can be nullable

// ALIAS

int total = 10;   // Alias
Int32 total = 10; // Type

string text = "Hello World!"; // Alias
String text = "Hello World!"; // Type

// STRUCTS
// NOTE: Structs are "Vaue Type" and classes are "Reference Type"

struct Product {
  // Properties
  public int Id;
  public float Price;
  public string Name;

  public Product(int id, float price)
  {
    Id = id;
    Price = price;
  }

  public Product(int id, string name)
  {
    Id = id;
    Name = name;
  }

  // Methods
  public float PriceInDolar(float dolar)
  {
    return Price * dolar;
  }
}

static void Main(string[] args)
{
  var product = new Product(1, 100.10F);
  product.Price = 99.99F;
  Console.WriteLine(product.PriceInDolar(5.7F));
}

// ENUMS

enum EMaritalStatus
{
  Single = 1,
  Married = 2,
  Divorced = 3
}

var maritalStatus = EMaritalStatus.Single; // var maritalStatus = 1;

Console.WriteLine(EMaritalStatus.Married) // Write "Married"
Console.WriteLine((int)EMaritalStatus.Married) // Write 2
```

# 04 Data Conversion

```c#
// OTHER EXAMPLE
decimal value = Convert.ToDecimal(10.ToString());

// IMPLICIT CONVERSION

float value = 25.8F;
int otherValue = 25;
value = otherValue;   // int TO float

// EXPLICIT CONVERSION

int value = 25.8F;
uint otherValue = (uint)value; // int TO uint

// PARSE

int value = int.Parse("100"); // string.Parse, bool.Parse, ...

// CONVERT (Class)

int value = Convert.ToInt32("100"); //  Convert.ToString, Convert.ToBoolean, ...

```

# 05 Math Operators

```c#
1 + 2

2 - 3

3 * 4

4 / 5

1 + (2 * 3)

float x = 0;
x += 1;
x *= 4;
x -= 1;
x /= 2;
x++;
x--;
```

# 06 Comparison Operators

```c#
1 == 2
2 != 3
4 < 5
5 > 6
6 <= 7
7 >= 8
```

# 07 Logical Pperators

```c#
false || true
false && true
!false
```

# 08 Conditionals

```c#
// IF, ELSE IF, ELSE

if (1 > 2)
{
  // ...
} else if (2 > 3)
{
  // ...
} else
{
  // ...
}

// SWITCH

int? option = 2;
switch (option)
{
  case 1:
    // ...
    break;
  case 2:
    // ...
    break;
  default:
    // ...
    break;
}
```

# 09 Repeating Loops

```c#
// FOR

for (int i = 0; i < 10; i++)
{
  // ...
}

// WHILE

int total = 5;

while(total > 0)
{
  // ...
  total--;
  // ...
}

// DO WHILE


int total = 5;

do
{
  // ...
  total--;
  // ...
} while(total > 0)
```

# 10 Method and Functions

```c#
public void SameMethod(string[] args) {}

public void SameMethod(int value, string text, bool isOpen = false) {} // NOTE: Different params = Different methods

SameMethod(["Hello", "World!"]);

SameMethod(100, "My Text");
```
