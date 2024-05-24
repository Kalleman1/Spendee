![Spendee Logo](images/spendee-logo.png)
# Spendee

Spendee is a web-based expense tracker application developed using ASP.NET Core for the backend and Blazor WebAssemly for the frontend. The application allows users to track their expenses, categorize them, and view reports.

## Workflow statuses
[![Build Backend](https://github.com/Kalleman1/Spendee/actions/workflows/backend-build.yml/badge.svg)](https://github.com/Kalleman1/Spendee/actions/workflows/backend-build.yml)
[![Build Frontend](https://github.com/Kalleman1/Spendee/actions/workflows/frontend-build.yml/badge.svg)](https://github.com/Kalleman1/Spendee/actions/workflows/frontend-build.yml)

## Features

- User authentication and registration

## Project Structure

- **SpendeeApi**: The backend project built with ASP.NET Core.
- **SpendeeClient**: The frontend project built with Blazor WebAssembly.

## Setup and Installation

### Prerequisites

- .NET SDK 7.0 or later
- Node.js (for frontend build if needed)
- PostgreSQL

### Backend

1. Navigate to the `SpendeeApi` directory:
    ```bash
    cd SpendeeApi
    ```

2. Restore dependencies and build the project:
    ```bash
    dotnet restore
    dotnet build
    ```

3. Update the database:
    ```bash
    dotnet ef database update
    ```

4. Run the backend:
    ```bash
    dotnet run
    ```

### Frontend

1. Navigate to the `SpendeeClient` directory:
    ```bash
    cd SpendeeClient
    ```

2. Restore dependencies and build the project:
    ```bash
    dotnet restore
    dotnet build
    ```

3. Run the frontend:
    ```bash
    dotnet run
    ```

## Contact

For questions or suggestions, please contact [kaper1@live.dk].