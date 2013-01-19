using System;
using UnityEngine;

namespace Uniject {

    public interface ITexture2D {

        UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);
    }
}
