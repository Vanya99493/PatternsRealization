using Strategy.Random;

namespace Strategy.Strategy
{
    public class VerticalMovingStrategy : IMoveStrategy
    {
        public VectorInt2 GetDirection()
        {
            return new VectorInt2(0, MyRandom.GetRandom(-1, 2));
        }
    }
}