
**Project Overview:**
- **Type**: .Net 8 WPF Application
- **Architecture**: Model-View-ViewModel (MVVM)

**Key Components:**
1. **Navigation Bar**:
   - Location: Left side of the app.
   - Features: 4 buttons with labels "A", "B", "C", "D".
   - Functionality: Button "A" opens the "Connections" screen.

2. **Connections Screen**:
   - **Layout**:
     - Left Side: List of all connections displaying the connection name (bold), description (tiny text), and last-run time (red, tiny text).
     - Right Side: Connection details area with buttons for [add], [edit], [test], [delete]. [test] and [delete] have yellow and red hues respectively.

3. **Add/Edit Connection Dialog**:
   - **Structure**: Tab Panel with three tabs - "Files", "Database", "OData".
      - **Tab selection sets a connection type value on the connection model**
      - **Files Tab**:
        - Folder selection field.  Has a [...] button to utilize the system folder selection dialog.
        - File name pattern field.  Has a (?) tooltip help icon [described below]
      - **Database Tab**:
        - Connection string field.
        - SQL Query field.  Has a (?) tooltip help icon.
      - **OData Tab**:
        - Single field for OData URL.
   - **Buttons** (positioned at the bottom of the dialog):
      - [Test] button.
      - [OK] button (enabled only after a successful test).
      - [Cancel] button (always active).
   - **Data Storage**: Connections are managed in "connections.json". 

This structure should provide a clear and organized reference for the development of the add/edit connections dialog in your application.   

4. **Help Tooltip Feature** (for fields requiring additional explanation):
   - **Icon**: Small blue circle with a white question mark, approximately 10-12 pixels in diameter.
   - **Placement**: Next to labels of fields like "File Name Pattern" and "SQL Query".
   - **Behavior**: Icon is always visible.  A tooltip appears on mouse hover over the icon; disappears when the mouse moves away.
   - **Content**: Concise explanations, e.g., usage of wildcards for "File Name Pattern".
   - **Styling**: Legible font (sans-serif), readable size, light background.
   - **Accessibility**: Responsive and accessible, keyboard navigable.
   - **Implementation**: Is there a standard WPF tooltip control?

**Additional Functional Requirements:**
- CRUD operations for connections.
- Validations (e.g., connection test) before saving.
- Test validation is a stub function that returns True for all current tests.
- User prompted to type in connection name before deletion is accepted. Name match is case-insensitive.  

**Technical Considerations:**
- Ensure responsive UI design.
- Adhere to accessibility standards.
- Implement efficient data handling and validation mechanisms.
- Use MVVM practices for maintainability and testability.


