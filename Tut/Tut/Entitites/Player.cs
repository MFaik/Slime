using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Entities
{
    public class Player : AEntity
    {
        public Player(Vector2 pos, Texture2D tex) : base(pos, tex)
        {

        }
        public override void tick()
        {

        }
        public override void render(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture,Position);
        }
    }
}