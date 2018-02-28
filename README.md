Movie Rental
===========

This source code follows Martin Fowler's book " Refactoring, Improving the Design of Existing Code".

When you find you have to add a feature to a program, and the program's code is not
structured in a convenient way to add the feature, first refactor the program to make it
easy to add the feature, then add the feature.

Whenever you do refactoring, the first step is always the same.
You need to build a solid set of tests for that section of code. The tests are essential because even
though you follow refactorings structured to avoid most of the opportunities for introducing bugs,
you are still human and still make mistakes. Thus you need solid tests.

Usage
-----

The purpose of this is to provide good examples for the refactoring workshop.


Evolution
---------

The owner of the video store wants to have also an HTML version of the rental statement:

    <h1>Rental Record for <em>Jhon Doe</em></h1>
    <table>
      <tr><td>Star Wars</td><td>3.5</td></tr>
      <tr><td>Assasin's creed</td><td>3</td></tr>
    </table>
    <p>Amount owed is <em>6.5</em></p>
    <p>You earned <em>2</em> frequent renter points</p>

Note: do not remove the text version
