## Glossary

1. **Entity**
   - *Definition*: Represents a data record, such as an "Event," which includes essential fields to capture its essence. Entities are conceptual and can exist in various contexts, each with enough fields to encapsulate what the entity represents.

2. **Connection**
   - *Definition*: Refers to the source from which data is obtained. There are three primary types of connections: files, database, and OData. Each connection type includes necessary details for data location and authentication. Connections are also assigned an entity type, linking them to specific entities they represent or provide data for.

3. **Files Connection**
   - *Definition*: Specifies a location for file-based data retrieval, using patterns with wildcard characters ("*"). Patterns can indicate a single file, multiple files, or all files in a folder, depending on the inclusion and arrangement of wildcards. Example: "theater events*.csv" would match any CSV file starting with "theater events."

4. **Database Connection**
   - *Definition*: Consists of a connection string and a SQL query. Unlike a general database connection, it targets specific datasets within the database. Each query, whether it’s a simple 'SELECT' statement, a complex join, or a stored procedure call, requires individual testing and verification due to varying user permissions at the database object level.

5. **OData Connection**
   - *Definition*: Represents a dataset provided by another application, typically easier to handle than API calls. OData connections rely on a protocol that allows the application to retrieve all necessary information from a single URL, in contrast to APIs which often require multiple interaction steps.
