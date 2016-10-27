namespace MiniORMLive.Entities
{
    using System;
    using MiniORMLive.Attributes;

    [Entity(TableName = "Books")]
    class Book
    {
        [Id]
        private int id;

        [Column(ColumnName = "Title")]
        private string title;

        [Column(ColumnName = "Author")]
        private string author;

        [Column(ColumnName = "PublishedOn")]
        private DateTime publishedOn;

        [Column(ColumnName = "Language")]
        private string language;

        [Column(ColumnName = "IsHardCovered")]
        private bool isHardCovered;

        [Column(ColumnName = "Rating")]
        private decimal rating;

        public Book(string title, string author, DateTime publishedOn, string language, bool isHardCovered, decimal rating)
        {
            this.Title = title;
            this.Author = author;
            this.PublishedOn = publishedOn;
            this.Language = language;
            this.IsHardCovered = isHardCovered;
            this.Rating = rating;
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
                this.author = value;
            }
        }

        public DateTime PublishedOn
        {
            get
            {
                return this.publishedOn;
            }

            set
            {
                this.publishedOn = value;
            }
        }

        public string Language
        {
            get
            {
                return this.language;
            }

            set
            {
                this.language = value;
            }
        }

        public bool IsHardCovered
        {
            get
            {
                return this.isHardCovered;
            }

            set
            {
                this.isHardCovered = value;
            }
        }

        public decimal Rating
        {
            get
            {
                return this.rating;
            }

            set
            {
                if (value < 0 | value > 10)
                {
                    throw new ArgumentException("The rating should be between 0 and 10 inclusive.");
                }

                this.rating = value;
            }
        }
    }
}
