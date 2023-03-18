# Microservices Project for Course Sales

This is a microservices project for course sales. It consists of 6 microservices: cart, catalog, discount, order, payment, and file/photo services.

Ocelot Gateway used as a gateway. All microservices are protected with JWT. 

Mvc Web App created to communicate with all these systems.


## Technologies Used

- .NET Core
- Docker
- Ocelot
- IdentityServer4
- MongoDB
- PostgreSQL
- MSSQL

## Microservices

- Cart Service
- Catalog Service
- Discount Service
- Order Service
- Payment Service
- File/Photo Service

## Architecture

This project follows the principles of Domain Driven Design (DDD) and uses the following architecture:

- API Gateway
- Identity Server
- Microservices

## Getting Started

To get started with the project, follow these steps:

1. Clone the repository.
2. Run `docker-compose up` command to start all microservices.
3. Start the User Management Service.
4. Start the web app.
