﻿using Newtonsoft.Json;

namespace Todoist.Net.Models
{
    /// <summary>
    /// Represent a collection of Todoist resources.
    /// </summary>
    public class Resources
    {
        /// <summary>
        /// Gets the filters.
        /// </summary>
        /// <value>The filters.</value>
        [JsonProperty("filters")]
        public Filter[] Filters { get; internal set; }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <value>The items.</value>
        [JsonProperty("items")]
        public Item[] Items { get; internal set; }

        /// <summary>
        /// Gets the labels.
        /// </summary>
        /// <value>The labels.</value>
        [JsonProperty("labels")]
        public Label[] Labels { get; internal set; }

        /// <summary>
        /// Gets or sets the last read notification identifier.
        /// </summary>
        /// <value>The last read notification identifier.</value>
        [JsonProperty("live_notifications_last_read_id")]
        public int? LastReadNotificationId { get; set; }

        /// <summary>
        /// Gets the notes.
        /// </summary>
        /// <value>The notes.</value>
        [JsonProperty("notes")]
        public Note[] Notes { get; internal set; }

        /// <summary>
        /// Gets the project notes.
        /// </summary>
        /// <value>The project notes.</value>
        [JsonProperty("project_notes")]
        public Note[] ProjectNotes { get; internal set; }

        /// <summary>
        /// Gets the notifications.
        /// </summary>
        /// <value>The notifications.</value>
        [JsonProperty("live_notifications")]
        public Notification[] Notifications { get; internal set; }

        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <value>The projects.</value>
        [JsonProperty("projects")]
        public Project[] Projects { get; internal set; }

        /// <summary>
        /// Gets the reminders.
        /// </summary>
        /// <value>The reminders.</value>
        [JsonProperty("reminders")]
        public Reminder[] Reminders { get; internal set; }

        /// <summary>
        /// Gets the user information.
        /// </summary>
        /// <value>The user information.</value>
        [JsonProperty("user")]
        public UserInfo UserInfo { get; internal set; }
    }
}
