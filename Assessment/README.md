# Tech Assessment Challenge

This repo houses the tech assessment challenge.

## Specification

The specification asks the developer to build Web API application, which consists of three main endpoints (/Posts, /Users, /Albums).
The solution needs to demonstrate the CRUD operation for one endpoint (/Posts). 
The specification details can be found in the following link. https://bitbucket.org/silverhorsetechteam/recruitment-tests/src/master/backend-dot-net.md

## Solution Details

The solution is called "Assessment". It contains total four projects. It uses CQRS design pattern and domain centric design.
The projects are
1.Domain
2.Application
3.Persistence
4.WebApi

## Setup and Testing

- Open the solution in Visual Studio 2022 (Visual Studio 2019 or above should be installed)
- This also needs SQL server (version 15.0.2000.5)
- Set WebApi project as Startup project
- Build the solution
- Run the solution (F5)
- Then each endpoint can be tested by using the browser or POSTMAN API test tool

NOTE: API_Test folder is located in WebApi project, and this folder contains POSTMAN test collection. These can be run using POSTMAN application. (POSTMAN app can be downloaded and installed)