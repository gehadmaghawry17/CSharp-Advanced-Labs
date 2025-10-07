namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball =new Ball() { Position= new Point()};
            Player p1 = new Player() { Id=1,Name="Haidy"};
            Player p2 = new Player() { Id = 2, Name = "Farida" };
            Player p3 = new Player() { Id = 3, Name = "asara" };

            ball.OnPositionChange += p1.MovePlayer;
            ball.OnPositionChange += p2.MovePlayer;
            ball.OnPositionChange += p3.MovePlayer;
            
            ball.SetPostion(10, 20);
            Console.WriteLine(ball);
            ball.SetPostion(40, 60);
            Console.WriteLine(ball);

            ball.OnPositionChange -= p1.MovePlayer;
            ball.OnPositionChange += p2.MovePlayer;
            ball.SetPostion(80, 50);
            Referee r1 = new Referee() { Name = "Mazen" };
            p1.OnBall += r1.Kick;
            p2.OnBall += r1.Kick;
            p1.KickBall(ball);
            p2.KickBall(ball);
        }
    }
}
