using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace kniTest;

/// <summary>
///     This is the main type for your game.
/// </summary>
public partial class KniGame : Game
{
    private ContentManager _cm;
    private readonly GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public KniGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        _graphics.PreferredBackBufferHeight = 640;
        _graphics.PreferredBackBufferWidth = 640;
        Content.RootDirectory = "Content";

        IsMouseVisible = true;

        _graphics.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;

#if (ANDROID || iOS)
            graphics.IsFullScreen = true;
#endif
    }

    /// <summary>
    ///     Allows the game to perform any initialization it needs to before starting to run.
    ///     This is where it can query for any required services and load any non-graphic
    ///     related content.  Calling base.Initialize will enumerate through any components
    ///     and initialize them as well.
    /// </summary>
    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    /// <summary>
    ///     LoadContent will be called once per game and is the place to load
    ///     all of your content.
    /// </summary>
    protected override void LoadContent()
    {
        // Create a new SpriteBatch, which can be used to draw textures.
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: Use this.Content to load your game content here
        _cm = ContentManager.LoadContent(this);

        // Load texture from file
        // _cubes = LoadTexture("Content/cubes.png", GraphicsDevice);
    }

    /// <summary>
    ///     UnloadContent will be called once per game and is the place to unload
    ///     game-specific content.
    /// </summary>
    protected override void UnloadContent()
    {
        // TODO: Unload any non ContentManager content here
        _cm.Dispose();
    }

    /// <summary>
    ///     Allows the game to run logic such as updating the world,
    ///     checking for collisions, gathering input, and playing audio.
    /// </summary>
    /// <param name="gameTime">Provides a snapshot of timing values.</param>
    protected override void Update(GameTime gameTime)
    {
        var mouseState = Mouse.GetState();
        var keyboardState = Keyboard.GetState();
        var gamePadState = GamePad.GetState(PlayerIndex.One);

        if (keyboardState.IsKeyDown(Keys.Escape) ||
            keyboardState.IsKeyDown(Keys.Back) ||
            gamePadState.Buttons.Back == ButtonState.Pressed)
            try
            {
                Exit();
            }
            catch (PlatformNotSupportedException)
            {
                /* ignore */
            }

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    /// <summary>
    ///     This is called when the game should draw itself.
    /// </summary>
    /// <param name="gameTime">Provides a snapshot of timing values.</param>
    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        _spriteBatch.Begin();

        var boundsSize = new Point(_cm.Cubes.Bounds.Width / 2, _cm.Cubes.Bounds.Height / 2);
        _spriteBatch.Draw(_cm.Cubes, new Rectangle(new Point(50, 50), boundsSize), Color.White);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}