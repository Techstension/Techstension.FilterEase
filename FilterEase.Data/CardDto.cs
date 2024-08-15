namespace FilterEase.Data
{
    /// <summary>
    /// Card data structure that is expected to be received from the API
    /// </summary>
    public record CardDto
    {
        /// <summary>
        /// Primary Id for the card.
        /// </summary>
        public required string Id { get; init; }
        /// <summary>
        /// The Primary Title for the card
        /// </summary>
        public required string Title { get; init; }

        /// <summary>
        /// Subtitle for the card
        /// </summary>
        public string SubTitle { get; init; } = string.Empty;

        /// <summary>
        /// Image url to be prominently displayed on the card,
        /// </summary>
        public string Image { get; init; } = string.Empty;

        /// <summary>
        /// Description for the card. 
        /// </summary>
        public string Description { get; init; } = string.Empty;

    }
}
