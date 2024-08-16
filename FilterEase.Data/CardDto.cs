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

        /// <summary>
        /// The text to  be displayed on the primary button
        /// </summary>
        public required string PrimaryActionLinkText { get; init; }
        /// <summary>
        /// The Primary Action that you wan tthe user to take
        /// </summary>
        public required string PrimaryActionLinkUrl { get;init; }
        /// <summary>
        /// The text to  be displayed on the Secondary button
        /// </summary>
        public required string SecondaryActionLinkText { get; init; }

        /// <summary>
        /// An acceptable secondary action the user could take. 
        /// For instance a link for more information.
        /// </summary>
        public required string SecondaryActionLinkUrl { get;init; }

    }
}
