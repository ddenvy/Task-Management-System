# Task Management System
A task management system built on a microservice architecture using gRPC and Docker.
Services

User Service: Handles user management.
Task Service: Manages tasks.
Tracking Service: Tracks task statuses.
Comment Service: Manages task comments.

# Local Hosts

User Service: Now listening on: http://0.0.0.0:5004
Task Service: Now listening on: http://0.0.0.0:5002
Tracking Service: Now listening on: http://0.0.0.0:5003
Comment Service: Now listening on: http://0.0.0.0:5001

# Setup

Build and run:docker-compose up --build



# Testing

Install Postman.
Create a new gRPC request for each service and import the respective proto file.
Configure all requests with:
Server Reflection: off
SSL: off (Plaintext)


# Use the corresponding ports for each service.

