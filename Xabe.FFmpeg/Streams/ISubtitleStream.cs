﻿using Xabe.FFmpeg.Enums;

namespace Xabe.FFmpeg.Streams
{
    /// <summary>
    ///     Subtitle stream
    /// </summary>
    public interface ISubtitleStream : ILocalStream
    {
        /// <summary>
        ///     Subtitle language
        /// </summary>
        string Language { get; }

        /// <summary>
        ///     Set subtitle format
        /// </summary>
        /// <param name="format">Subtitle format</param>
        /// <returns>ISubtitleStream</returns>
        ISubtitleStream SetFormat(SubtitleFormat format);

        /// <summary>
        ///     Set subtitle language
        /// </summary>
        /// <param name="language">Language</param>
        /// <returns>ISubtitleStream</returns>
        ISubtitleStream SetLanguage(string language);
    }
}
