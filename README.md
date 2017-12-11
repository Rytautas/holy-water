# Introduction

Holy Water is a C# application that lets the user record data regarding their glass of beer at a bar, 
most importantly how much of the glass is filled. It was created by software engineering students Rytautas Kvašinskas,
Neringa Chlemevskytė and Jonas Danielius.

# How do you use it?

First of all, each user must sign up and then log in to the application. Then the user is allowed access to their account's 
recorded data. If the user wishes to add more data, they may do so in the Bar window. In the same window the user can view the
data of all bars and drinks they've recorded, including the average fill of each bar and the number of times they've drunk beer 
at that bar. The user may filter the results if they wish.

# How does it work?

All data entered and saved by the user is recorded in the database, in the Bars and Drinks tables. The data between those tables
is connected by the Bar_ID column. A bar ID is assigned when a bar with a new name is entered. The count and average of bars and drinks
are calculated in a seperate table, called BarsTotals. All data is displayed in a form.
