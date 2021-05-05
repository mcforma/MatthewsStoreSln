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

## Figure 7-9 Screenshot (pg 154)
## ![Figure 7-9 Screenshot (pg 154)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%207-9%20equivalent.png)

## Figure 8-9 Screenshot (pg 177)
## ![Figure 8-9 Screenshot (pg 177)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Shopping%20Cart%20placeholder%20(Fig%208-9).png)

## Figure 8-10 Screenshot (pg 186)
## ![Figure 8-10 Screenshot (pg 186)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%208-10.png)

## Figure 8-11 Screenshot (pg 186)
## ![Figure 8-11 Screenshot (pg 186)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%208-11.png)

## Successful Unit Tests through Chapter 8 Screenshot
## ![Successful Unit Tests through Chapter 8 Screenshot](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Unit%20Tests%20thru%20Ch.%208_.png)

## Figure 9-3 Screenshot (pg 201)
## ![Figure 9-3 Screenshot (pg 201)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%209-3_Cart.png)

## Figure 9-4 Screenshot (pg 203)
## ![Figure 9-4 Screenshot (pg 203)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%209-4_Shipping%20Details%20Form.png)

## Figure 9-6 Screenshot (pg 211)
## ![Figure 9-6 Screenshot (pg 211)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%209-6_Completed%20order.png)

## Successful Unit Tests through Chapter 9 Screenshot
## ![Successful Unit Tests through Chapter 9 Screenshot](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Unit%20Tests%20thru%20Ch.%209.png)

## Figure 10-5_Presenting list of products (pg 225)
## ![Figure 10-5_Presenting list of products (pg 225)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%2010-5_Presenting%20list%20of%20products.png)

## Figure 10-6_Displaying details of a product (pg 227)
## ![Figure 10-6_Displaying details of a product (pg 227)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%2010-6_Displaying%20details%20of%20a%20product.png)

## Figure 10-7_Using the Editor component (pg 229)
## ![Figure 10-7_Using the Editor component (pg 229)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%2010-7_Using%20the%20Editor%20component.png)

## Figure 10-7 New product successfully created and added to DB (pg 229)
## ![Figure 10-7 New product successfully created and added to DB (pg 229)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%2010%20New%20product%20successfully%20created%20and%20added%20to%20DB.png)

## Figure 10-8_Editing products (pg 229)
## ![Figure 10-8_Editing products (pg 229)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%2010-8_Editing%20products.png)

## Figure 10-9_Deleting objects from DB_1 (pg 231)
## ![Figure 10-9_Deleting objects from DB_1 (pg 231)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%2010-9_Deleting%20objects%20from%20DB_1.png)

## Figure 10-9_Deleting objects from DB_2 (pg 231)
## ![Figure 10-9_Deleting objects from DB_2 (pg 231)](https://github.com/mcforma/MatthewsStoreSln/blob/master/Images/Figure%2010-9_Deleting%20objects%20from%20DB_2.png)
