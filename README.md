# 1. Strategy Pattern
## Theory
<p>The Strategy Pattern allows you to define a family of algorithms, encapsulate each one, and make them interchangeable. It enables a client to choose an algorithm from a family of algorithms at runtime. Strategy pattern decouples the code that uses the algorithm from the code that implements the algorithm.
</p>
<p>Use case: Situations where multiple algorithms (or behaviors) can be chosen at runtime, such as different sorting algorithms, payment processing methods, or pricing strategies.
</p>
<br>

# 2. Chain of Responsibility Pattern
## Theory
<p>The Chain of Responsibility Pattern is used to pass a request along a chain of handlers. Each handler either processes the request or passes it to the next handler in the chain. This pattern allows handling requests in a sequence and makes it easy to add or remove handlers without altering the structure of the request chain.
</p>
<p>Use case: Situations where multiple objects may handle a request, such as support ticket levels (basic, advanced, expert), logging with different levels (info, warning, error), or validation chains.
</p>
<br>


# 3. Factory Pattern
## Theory
<p>The Factory Pattern is a creational pattern that provides an interface for creating objects but allows subclasses to alter the type of objects that will be created. It abstracts the object creation process and decouples the client code from the instantiation logic.
</p>
<p>Use case: Situations where the exact type of object isn’t known until runtime, such as database connections, shape creation in graphics applications, or notifications.
</p>

# 4. Builder Pattern
## Theory
<p>The Builder Pattern is used to construct complex objects step by step. It separates the construction of a complex object from its representation, allowing different representations to be created with the same construction process.
</p>
<p>Use case: When creating objects with complex structures or configurations, like building a computer with various components or creating a custom configuration for an application.
</p>