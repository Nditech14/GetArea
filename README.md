I declared GetArea method in the Parent class and implement it under the child classes, because  by declaring the GetArea method in the Shape class we have one advantage.

The advantage is that the method name is going to be the same in all four classes, and even if tomorrow a new class inherits the from the Shape class, then also the method name is going to be the same i.e. GetArea. Along with the method name, the method signature is also going to be the same in all the child classes.
