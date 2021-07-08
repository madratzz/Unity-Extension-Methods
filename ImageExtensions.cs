using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ExtensionMethods
{
    public static class ImageExtensions
    {
        public static void SetOpacity(this Image image, float alpha)
        {
            var currentColor = image.color;
            currentColor.a = alpha;
            image.color = currentColor;
        }

    }
}