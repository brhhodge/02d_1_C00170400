# 02d_1_C00170400
CMPS358 _Assignment6

Programming Assignment:


1. Create a C# console project in Visual Studio Code and name it “02d_1_your-clid”. When the project
runs correctly, clean the project, zip the project folder and upload it in Moodle.


2. In a new file located in the same namespace as the default class, create a C# class to represent a dirt
sample that consists of the amount in grams of sand and clay in the sample. However, this will not be a
“normal” class. The class will have two private data members, but will NOT HAVE any constructors
and NOT HAVE any traditional get/set methods such as you would have written in Java. Instead, the
class will have properties. In the class, create


(a) two private fields as data members and their associated public properties to represent the state
information of the sample (the amount in grams of sand and clay). Each property must have a
get/set pair.

(b) one public read-only expression bodied property that returns the sum of the clay and sand in the
sample.

(c) an overriding of the method public string ToString() (inherited from class object) that returns a string
containing the amount of clay and sand in the sample with labels.


3. In the Main method of the default class, demonstrate that your dirt sample class can be used as a data
type by

(a) creating at least three dirt sample class reference variables that reference one each of three unique
dirt class objects. At least one dirt class object must be created using the default constructor that is
created by the compiler. At least one dirt class object must be created using the object initializer
notation.

(b) using the three dirt sample objects and their reference variables to demonstrate that properties and
the overridden ToString method of the dirt class work correctly and that the value in the private
fields in each object are unique to that object.


4. User input is optional.
