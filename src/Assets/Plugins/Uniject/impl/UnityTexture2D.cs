using System;
using UnityEngine;

namespace Uniject.Impl {

    public class UnityTexture2D : ITexture2D {

        private Texture2D texture2D { get; set; }

        public UnityTexture2D(UnityEngine.Texture2D texture) {
            this.texture2D = texture;
        }

        public UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) {
            return texture2D.GetPixels(x, y, blockWidth, blockHeight);
        }
    }
}