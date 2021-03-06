﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewModdingAPI
{
    /// <summary>Encapsulates access and changes to dictionary content being read from a data file.</summary>
    public interface IContentEventHelperForImage : IContentEventData<Texture2D>
    {
        /*********
        ** Public methods
        *********/
        /// <summary>Overwrite part of the image.</summary>
        /// <param name="source">The image to patch into the content.</param>
        /// <param name="sourceArea">The part of the <paramref name="source"/> to copy (or <c>null</c> to take the whole texture). This must be within the bounds of the <paramref name="source"/> texture.</param>
        /// <param name="targetArea">The part of the content to patch (or <c>null</c> to patch the whole texture). The original content within this area will be erased. This must be within the bounds of the existing spritesheet.</param>
        /// <param name="patchMode">Indicates how an image should be patched.</param>
        /// <exception cref="ArgumentNullException">One of the arguments is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The <paramref name="targetArea"/> is outside the bounds of the spritesheet.</exception>
        /// <exception cref="InvalidOperationException">The content being read isn't an image.</exception>
        void PatchImage(Texture2D source, Rectangle? sourceArea = null, Rectangle? targetArea = null, PatchMode patchMode = PatchMode.Replace);
    }
}
