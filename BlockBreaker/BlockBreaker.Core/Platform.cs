using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using MonoGame.Extended.Input;

namespace BlockBreaker.Core
{
    public class Platform
    {
        private Map map;
        public Rectangle Size { get; set; } = new Rectangle(0, 0, 16, 8);

        public Vector2 Position { get; set; } = Vector2.Zero;

        public Platform(Map map) { this.map = map; }

        public void HandleInput(GameTime gameTime)
        {

        }

        public void Update(GameTime gameTime)
        {
            HandleInput(gameTime);
            KeyboardState state = Keyboard.GetState();
            Vector2 newPosition = Position;
            if(state.IsKeyDown(Keys.Left))
            {
                newPosition = new Vector2(Position.X - 100 * (float)gameTime.ElapsedGameTime.TotalSeconds, Position.Y);
            }
            else if (state.IsKeyDown(Keys.Right))
            {
                newPosition = new Vector2(Position.X + 100 * (float)gameTime.ElapsedGameTime.TotalSeconds, Position.Y);
            }

            if(newPosition.X < 0)
            {
                newPosition = new Vector2(0, newPosition.Y);
            }
            else if(newPosition.X + Size.Width > map.TotalWidth)
            {
                newPosition = new Vector2(map.TotalWidth - Size.Width, newPosition.Y);
            }

            Position = newPosition;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.FillRectangle(new Rectangle((int)Position.X, (int)Position.Y, Size.Width, Size.Height), Color.Green);
        }
    }
}
