# BookDetails

## Overview
This API allows users to perform CRUD operations on a collection of books, including retrieving sorted lists of books and calculating the total price.

## Endpoints

- GET /api/books/sortedByPublisherAuthorTitle
  - Returns a list of books sorted by Publisher, Author (Last, First), then Title.
- GET /api/books/sortedByAuthorTitle
  - Returns a list of books sorted by Author (Last, First), then Title.
- GET /api/books/sortedByPublisherAuthorTitle_Procedure
  - Returns a list of books sorted by Publisher, Author (Last, First), then Title. Uses a stored procedure.
- GET /api/books/sortedByAuthorTitle_Procedure
  - Returns a list of books sorted by Author (Last, First), then Title. Uses a stored procedure.
- GET /api/books/totalPrice
  - Returns the total price of all books in the database. Uses a stored procedure.
- POST /api/books
  - Adds a list of books to the database.

## Data Model

public class Book
{
    public int Id { get; set; }
    public string Publisher { get; set; }
    public string Title { get; set; }
    public string AuthorLastName { get; set; }
    public string AuthorFirstName { get; set; }
    public decimal Price { get; set; }
    public string MLA { get; }
    public string Chicago { get; }
}
