using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Entities
{
    public abstract class AEntity
    {
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; set; }
        public AEntity(Vector2 pos,Texture2D tex)
        {
            Position = pos;
            Texture = tex;
        }
        public abstract void render(SpriteBatch spriteBatch);
        public abstract void tick();
    }
}