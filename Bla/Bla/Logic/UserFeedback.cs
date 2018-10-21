using System;

namespace Bla.Logic
{
    public class UserFeedback
    {
        /// <summary>
        /// Attributes
        /// </summary>
        private int _id;
        private string _feedbackText;
        private int _rating;
        private DateTime _creationDate;

        /// <summary>
        /// getter/setter for the Id
        /// </summary>
        public int Id { get => _id; set => _id = value; }
        /// <summary>
        /// getter/setter for the FeedbackText
        /// </summary>
        public string FeedbackText { get => _feedbackText; set => _feedbackText = value; }
        /// <summary>
        /// getter/setter for the Rating
        /// </summary>
        public int Rating { get => _rating; set => _rating = value; }
        /// <summary>
        /// getter/setter for the CreationDate
        /// </summary>
        public DateTime CreationDate { get => _creationDate; set => _creationDate = value; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="feedbackText"></param>
        public UserFeedback(int id, string feedbackText, int rating, DateTime creationDate)
        {
            this._id = id;
            this._feedbackText = feedbackText;
            this._rating = rating;
            this._creationDate = creationDate;
        }
    }
}
