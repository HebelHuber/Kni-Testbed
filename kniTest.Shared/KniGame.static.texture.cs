using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace kniTest;

public partial class KniGame
{
    private static Texture2D LoadTexture(string path, GraphicsDevice graphicsDevice, bool premultiply = true)
    {
        using var titleStream = TitleContainer.OpenStream(path);
        var texture = Texture2D.FromStream(graphicsDevice, titleStream);
        if (premultiply) PreMultiply(ref texture);
        return texture;
    }

    private static void PreMultiply(ref Texture2D tex)
    {
        var buffer = new Color[tex.Width * tex.Height];
        tex.GetData(buffer);
        for (var i = 0; i < buffer.Length; i++)
            buffer[i] = Color.FromNonPremultiplied(buffer[i].R, buffer[i].G, buffer[i].B, buffer[i].A);
        tex.SetData(buffer);
    }
}