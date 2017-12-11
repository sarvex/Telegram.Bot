﻿using Newtonsoft.Json;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Send phone contacts
    /// </summary>
    public class SendContactRequest : RequestBase<Message>
    {
        /// <summary>
        /// Unique identifier for the target chat or username of the target channel
        /// </summary>
        public ChatId ChatId { get; set; }

        /// <summary>
        /// Contact's phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Contact's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Contact's last name
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Sends the message silently. Users will receive a notification with no sound.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DisableNotification { get; set; }

        /// <summary>
        /// If the message is a reply, ID of the original message
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ReplyToMessageId { get; set; }

        /// <summary>
        /// Additional interface options. A JSON-serialized object for a custom reply keyboard, instructions to hide keyboard or to force a reply from the user.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IReplyMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Initializes a new request
        /// </summary>
        public SendContactRequest()
            : base("sendContact")
        { }

        /// <summary>
        /// Initializes a new request with chatId, contacts's phone number and first name
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel</param>
        /// <param name="phoneNumber">Contact's phone number</param>
        /// <param name="firstName">Contact's first name</param>
        public SendContactRequest(ChatId chatId, string phoneNumber, string firstName)
            : this()
        {
            ChatId = chatId;
            PhoneNumber = phoneNumber;
            FirstName = firstName;
        }

        /// <summary>
        /// Initializes a new request with chatId, contacts's phone number, first name and last name
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel</param>
        /// <param name="phoneNumber">Contact's phone number</param>
        /// <param name="firstName">Contact's first name</param>
        /// <param name="lastName">Contact's last name</param>
        public SendContactRequest(ChatId chatId, string phoneNumber, string firstName, string lastName)
            : this(chatId, phoneNumber, firstName)
        {
            LastName = lastName;
        }
    }
}
