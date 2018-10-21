using System;

namespace Bla.Logic
{
    public class NewsFeedEntry
    {
        /// <summary>
        /// Attributes
        /// </summary>
        private int _id;
        private string _newsfeedText;
        private string _short_description;
        private int _author_id;
        private DateTime _createdate;
        private String _author_name;

        /// <summary>
        /// getter/setter for the Id
        /// </summary>
        public int id
        {
            get => _id;
            set => _id = value;
        }

        /// <summary>
        /// getter/setter for the FeedbackText
        /// </summary>
        public string newsfeedText
        {
            get => _newsfeedText;
            set => _newsfeedText = value;
        }

        /// <summary>
        /// getter/setter for the Author
        /// </summary>
        public int author_id
        {
            get => _author_id;
            set => _author_id = value;
        }

        /// <summary>
        /// getter/setter for the date of creation
        /// </summary>
        public DateTime createdate
        {
            get => _createdate;
            set => _createdate = value;
        }

        /// <summary>
        /// getter/setter for the date of creation
        /// </summary>
        public String author_name
        {
            get => _author_name;
            set => _author_name = value;
        }

        /// <summary>
        /// getter/setter for the date of creation
        /// </summary>
        public String short_description
        {
            get => _short_description;
            set => _short_description = value;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="feedbackText"></param>
        public NewsFeedEntry(int id, string newsfeedText, int author_id, DateTime createdate, String author_name,
            String short_description)
        {
            this.id = id;
            this.newsfeedText = newsfeedText;
            this.author_id = author_id;
            this.createdate = createdate;
            this.author_name = author_name;
            this.short_description = short_description;
        }
    }
}