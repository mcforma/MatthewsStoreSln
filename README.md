# MatthewsStoreSln
This is a build of the demo MVC app from Adam Freeman's ASP.NET Core 3 textbook. This is for demonstration purposes only.
## Link
[https://www.apress.com/gp/book/9781484254394](https://www.apress.com/gp/book/9781484254394)

## Build Script

    dotnet new globaljson --sdk-version 5.0.2 --output MatthewsStoreSln/OutdoorProducts
    dotnet new web --no-https --output MatthewsStoreSln/OutdoorProducts --framework net5.0
    dotnet new sln -o MatthewsStoreSln
    dotnet sln MatthewsStoreSln add MatthewsStoreSln/OutdoorProducts 
    dotnet new xunit -o MatthewsStoreSln/OutdoorProducts.Tests --framework net5.0
    dotnet sln MatthewsStoreSln add MatthewsStoreSln/OutdoorProducts.Tests 
    dotnet add MatthewsStoreSln/OutdoorProducts.Tests reference MatthewsStoreSln/OutdoorProducts

## Step 1 Screenshot (pg 128)
## ![Step 1 Screenshot (pg 128)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/step1_pg128.JPG)
