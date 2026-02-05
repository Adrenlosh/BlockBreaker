using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;

namespace BlockBreaker.Core
{
    public class Ball
    {
        private Map map;
        public Rectangle Size { get; set; } = new Rectangle(0, 0, 8, 8);

        public Vector2 Position { get; set; } = Vector2.Zero;

        public Ball(Map map) { this.map = map; }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawCircle(new CircleF(Position, Size.Width), 50, Color.Blue);
        }
    }
}