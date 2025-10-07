using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04

{   class PositionChangedEventArgs
    {
        public int DeltaX { get; set; }
        public int DeltaY { get; set; }
    }
    internal class Ball
    {
        Point position;
        public event  EventHandler<PositionChangedEventArgs> OnPositionChange;
        internal Point Position
        {
            get => position;
            set => position = value;
        }
        public void SetPostion(int x,int y)
        {

            PositionChangedEventArgs e = new PositionChangedEventArgs() { DeltaX=Position.x-x , DeltaY = position.y - y };
            position.x= x;
            position.y= y;
            OnPositionChange.Invoke(this,e);
        }
        public override string ToString()
        {
            return $"ball position-{position}";
        }
    }
}
