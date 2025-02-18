using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace kniTest;

public class ContentManager : IDisposable
{
    public readonly Texture2D Cubes;

    private ContentManager(Game game)
    {
        Cubes = game.Content.Load<Texture2D>("cubes");
    }

    public void Dispose()
    {
        Cubes?.Dispose();
    }

    public static ContentManager LoadContent(Game game)
    {
        return new ContentManager(game);
    }
}