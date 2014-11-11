namespace Core.Dal
{
    /// <summary>
    /// Support for IsDirty property.
    /// </summary>
    public interface ITracksDirty
    {
        /// <summary>
        /// Inicates that object has some changes that are not persisted
        /// </summary>
        bool IsDirty { get; set; }
    }
}
