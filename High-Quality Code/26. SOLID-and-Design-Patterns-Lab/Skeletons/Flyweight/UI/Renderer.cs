﻿namespace ReaperInvasion.UI
{
    using System.Collections.Generic;
    using System.Windows.Controls;
    using Contracts;

    public class Renderer
    {
        private static Dictionary<IRenderable, Image> images = new Dictionary<IRenderable, Image>();

        public Renderer(Canvas canvas, AssetLoader assetLoader)
        {
            this.Canvas = canvas;
            this.AssetLoader = assetLoader;
        }

        public AssetLoader AssetLoader { get; private set; }

        public Canvas Canvas { get; private set; }
        
        public void Render(IRenderable obj)
        {
            var image = this.AssetLoader.GetImage(obj.Type);

            Canvas.SetLeft(image, obj.X);
            Canvas.SetTop(image, obj.Y);
            this.Canvas.Children.Add(image);
        }
    }
}
