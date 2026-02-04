using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;

namespace BlockBreaker.Core
{
    public class Map
    {
        private int[][] mapData;

        public int TotalWidth { get => Width * TileSize.Width; }

        public int TotalHeight { get => Height * TileSize.Height; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Rectangle TileSize { get; set; } = new Rectangle(0, 0, 16, 8);


        public Map(int[][] mapData) 
        {
            AnalyseMapData(mapData);
        }

        private void AnalyseMapData(int[][] mapData)
        {
            Width = mapData[0].Length;
            Height = mapData.Length;
            this.mapData = mapData;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for(int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    Vector2 position = new Vector2(i * TileSize.Width, j * TileSize.Height);
                    if (mapData[j][i] == 1)
                    {
                        spriteBatch.FillRectangle(new Rectangle((int)position.X, (int)position.Y, TileSize.Width, TileSize.Height), Color.Red);
                    }
                }
            }
        }
    }
}
