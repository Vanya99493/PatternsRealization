using Strategy.Random;

namespace Strategy.Strategy
{
    public class HorizontalMovingStrategy : IMoveStrategy
    {
        public VectorInt2 GetDirection()
        {
            return new VectorInt2(MyRandom.GetRandom(-1, 2), 0);
        }
    }
}