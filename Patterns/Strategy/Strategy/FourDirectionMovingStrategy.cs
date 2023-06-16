using Strategy.Random;

namespace Strategy.Strategy
{
    public class FourDirectionMovingStrategy : IMoveStrategy
    {
        public VectorInt2 GetDirection()
        {
            return MyRandom.GetRandom(0, 2) == 0 
                ? new HorizontalMovingStrategy().GetDirection() 
                : new VerticalMovingStrategy().GetDirection();
        }
    }
}