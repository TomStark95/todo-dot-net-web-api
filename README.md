# todo-dot-net-web-api

Very basic CRUD style ASP.NET Core Web API.

## Minimal API vs Full/Controller based API

- Generally minimal APIs are designed to be SIMPLE smaller API services. With that being said minimal APIs can grow into larger API services and controller based APIs can be kept simple if done right...
- Micro-services can benefit from being coded as a minimal API.
- Controller based APIs are classes that derive from the ControllerBase class. Classes that derive off ControllerBase define the API route (controller) and assocated logic for any HTTP methods on that route.
- Minimal APIs simply define routes and associated logic using lambdas.

## Model class

A model class is used to represent a state of data that the app manages. Model class files in this repo sit under the Models folder by convention.

## Services

The TodoService connects to MongoDB via the MongoClient instance. This service is registered in the dependency injection container within Program.cs as a singleton.

## Prevent over-posting

- The act of limiting the data that's input and returned from a model
- DTOs (Data Transfer Objects) represent a subset of a model to be returned (also referred to sometimes as a the view model or input model)
- DTOs are used to prevent over-posting, hide fields that should not be viewed by the client (security), return payload size, and give the client more manageable data
