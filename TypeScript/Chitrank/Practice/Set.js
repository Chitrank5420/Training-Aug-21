let studentEntrie = new Set();
//Add Values  
studentEntrie.add("John");
studentEntrie.add("Peter");
studentEntrie.add("Gayle");
studentEntrie.add("Kohli");
studentEntrie.add("Dhawan");
studentEntrie.add(10);
//Returns Set data  
console.log(studentEntrie);
//Check value is present or not  
console.log(studentEntrie.has("Kohli"));
console.log(studentEntrie.has(10));
//It returns size of Set  
console.log(studentEntrie.size);
//Delete a value from set  
console.log(studentEntrie.delete("Dhawan"));
//Clear whole Set  
studentEntrie.clear();
//Returns Set data after clear method.  
console.log(studentEntrie);
