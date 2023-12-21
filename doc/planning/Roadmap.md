# Software Roadmap

## 1. Basic Skeleton/Scaffolding Application
- Initial setup and basic structure of the application.
- Define the core architecture and technology stack.

## 2. Add CRUD for Connections
  - **A. File/Folder Connections**
    - **Data Point for Folder:** Specify the target folder for operations.
    - **Data Point for File Name Pattern:** Define the pattern for file selection.
    - **Usage:** Operate on one or multiple files matching the given pattern.
  - **B. Database Connections**
    - **Data Point for Connection String:** Establish the database connection.
    - **Data Point for SQL Query:** Specify the SQL query for data manipulation.
  - **C. OData Connections**
    - **Data Point for OData URL:** Set up the connection to OData service.

## 3. Connections List
- Develop a reusable list item component for displaying connections.
- **Features of List Item:**
  - Connection name.
  - Icon indicating connection type.
  - Status indicators (details pending).

## 4. Connection Details Area
- Displaying connection details upon selection from the list.
- **Default Mode:** Read-only.
- Show both data-entry data and history log (details to be determined).
- **Interactive Buttons:**
  - **[Test]:** Reuse the testing functionality implemented during the connection creation phase.
  - **[Edit]:** Enable editing of connection details using a form similar to the initial add form.
  - **[Delete]:**
    - Remove the selected connection.
    - Implement a confirmation prompt requiring users to manually enter the connection name for verification.
    - Note: The confirmation check is case-sensitive to prevent accidental deletions.

## 5. Connections Persistent Storage
- Connection data will be stored in a local JSON file named "connections.json".
- For database connections, the connection string will be encrypted using the AES algorithm.

## 6. Add CRUD for Entities
- TBD
