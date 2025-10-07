using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class BallKicked : EventArgs
    {
        public Player Player {  get; set; }
        public Ball Ball { get; set; }
    }
    internal class Player
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public event EventHandler<BallKicked> OnBall;
        public void KickBall(Ball b)
        {
            Console.WriteLine($"{this} Kicked the ball");
            OnBall?.Invoke(this, new BallKicked()
            {
                Player = this,
                Ball = b
            });
            
        }
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
        public void MovePlayer(object sender,PositionChangedEventArgs e)
        {
            Ball b1=sender as Ball;
            Console.WriteLine($"from player {this}::ball position changed {b1.Position}");
        }
    }
    internal class Referee
    {
        public string Name { get; set; }
        public void Kick(object sender, BallKicked e)
        {
            Console.WriteLine($"Referee {Name} - {e.Player.Name}  kicked the ball at position {e.Ball.Position}");
        }
    }
}
