using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

        /// <summary>
        /// Represents a message with a text content.
        /// </summary>
        /// <remarks>
        /// The text content is required and must be a string with a maximum length of 200 characters.
        /// </remarks>
        /// <example>
        /// <code>
        /// var message = new Message { Text = "Hello, world!" };
        /// </code>
        /// </example>
        /// <value>
        /// The text content of the message.
        /// </value>
        /// <exception cref="ValidationException">
        /// Thrown when the text content exceeds 200 characters.
        /// </exception>
        [Required]
        [DataType(DataType.Text)]

        [StringLength(200, ErrorMessage = "There's a 200 character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
