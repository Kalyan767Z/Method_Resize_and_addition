# Program: Array Resizing and Element Addition/Deletion Methods

## Task

1. Write a method `Resize` to change the number of elements in an array (the method should allow increasing or decreasing the array size).
2. Write methods to add an element to the beginning, end, or at a specified index of the array.
3. Write methods to remove the first element, the last element, or an element at a specified index of the array.

---

## Program Description

### 1. **Resize Method**:
   - This method allows resizing an array by either increasing or decreasing its size. It takes the array and a new size as parameters and creates a new array with the specified size. It copies the existing elements to the new array, ensuring that no data is lost in the process.

### 2. **Adding and Deleting Elements**:
   - **Add First Element**: This method inserts an element at the beginning of the array, shifting all other elements one position to the right.
   - **Add Last Element**: This method appends an element to the end of the array.
   - **Add Element at Index**: This method allows inserting an element at a specific index, shifting elements as needed to accommodate the new element.
   - **Delete First Element**: This method removes the first element of the array and shifts the remaining elements to the left.
   - **Delete Last Element**: This method removes the last element of the array.
   - **Delete Element by Index**: This method deletes an element at a specified index, and shifts the remaining elements to fill the gap.

### Program Structure

1. **Resize Method**:
   - The `Resize` method takes a reference to the array and the new size as parameters. If the new size is valid, it creates a new array of the specified size and copies elements from the old array to the new one.

2. **Add/Remove Methods**:
   - The program provides several methods for adding and removing elements at various positions (beginning, end, and by index). These methods create a new array with the desired size, copy over the necessary elements, and modify the array accordingly.

3. **Input Validation**:
   - Before performing any operation (such as resizing, adding, or deleting), the program validates user input, ensuring that the size, index, and elements are correct and within valid ranges.

---

## Summary:

This program demonstrates array manipulation in C# by providing methods for resizing an array and adding/removing elements at specific positions. The array operations are dynamic, allowing the user to modify the array in various ways. The program includes input validation to ensure the array operations are performed correctly and safely.

--- 

## Key Operations:

- **Resize**: Allows changing the number of elements in the array.
- **Add Element**: Adds an element at the start, end, or specified index.
- **Delete Element**: Deletes an element from the start, end, or specified index.

These operations are useful for managing arrays dynamically, which is often required in various programming scenarios.
