using ECommerce.BLL.Abstract;
using ECommerce.DTO.Concrete;
using ECommerce.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;
        private IPublisherService _publisherService;
        private IImageService _imageService;
        private ILanguageService _languageService;
        private ITranslatorService _translatorService;
        private ICoverTypeService _coverTypeService;
        private IAuthorBookService _authorBookService;
        private IBookTranslatorService _bookTranslatorService;
        private IAuthorService _authorService;

        public BookController(IBookService bookService, IPublisherService publisherService, IImageService imageService, ILanguageService languageService, ITranslatorService translatorService, ICoverTypeService coverTypeService, IAuthorBookService authorBookService, IBookTranslatorService bookTranslatorService, IAuthorService authorService)
        {
            _bookService = bookService;
            _publisherService = publisherService;
            _imageService = imageService;
            _languageService = languageService;
            _translatorService = translatorService;
            _coverTypeService = coverTypeService;
            _authorBookService = authorBookService;
            _bookTranslatorService = bookTranslatorService;
            _authorService = authorService;
        }

        [HttpPost("add")]
        public IActionResult AddBook(AddBookDto bookdto)
        {
            Book book = new Book()
            {
                Name = bookdto.Name,
                TotalPages = bookdto.TotalPage,
                TotalPrinting = bookdto.TotalPrinting,
                Price = bookdto.Price,
                DiscountRate = bookdto.DiscountRate,
                TaxRate = bookdto.TaxRate,
                MaterialType = bookdto.MaterialType,
                PublicationDate = bookdto.PublicationDate,
                ISBN = bookdto.ISBN,
                Explanation = bookdto.Explanation,
                StockAmount = bookdto.StockAmount,
                Ratings = bookdto.Rate
            };

            Author author = new Author()
            {
                FirstName = bookdto.AuthorName,
                LastName = bookdto.AuthorLastName
            };

            Image image = new Image()
            {
                Road = bookdto.Image
            };

            Translator translator = new Translator()
            {
                Name = bookdto.TranslatorName,
                Surname = bookdto.TranslatorSurname,
                EMail = bookdto.TranslatorEmail
            };

            Language language = new Language()
            {
                Name = bookdto.Language
            };

            Publisher publisher = new Publisher()
            {
                Name = bookdto.PublisherName
            };

            CoverType coverType = new CoverType()
            {
                Name = bookdto.Name
            };

            BookTranslator bookTranslator = new BookTranslator();
            BookAuthor bookAuthor = new BookAuthor() {
            AuthorID = author.ID,
            BookID = book.ID
            };

            _coverTypeService.Add(coverType);
            book.CoverTypeID = coverType.ID;
            _publisherService.Add(publisher);
            book.PublisherID = publisher.ID;
            _languageService.Add(language);
            book.LanguageID = language.ID;
            image.BookID = book.ID;
            _authorService.Add(author);
            var result = _bookService.Add(book);
             bookAuthor.AuthorID= author.ID;
            bookAuthor.BookID = book.ID;
            _authorBookService.Add(bookAuthor);
            _translatorService.Add(translator);
            bookTranslator.TranslatorID = translator.ID;
            bookTranslator.BookID = book.ID;
            _bookTranslatorService.Add(bookTranslator);

            if (result.Success)
            {
                return Ok(result.Message);

            }
            return BadRequest(result.Message);


        }



    }
}
