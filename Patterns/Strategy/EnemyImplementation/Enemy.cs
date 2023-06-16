using Strategy.Strategy;
using Singleton;

namespace Strategy.EnemyImplementation
{
    public class Enemy
    {
        private IMoveStrategy _moveStrategy;
        private MyConsole _myConsole;
        private VectorInt2 _position;
        private char _enemySymbol;

        public Enemy(IMoveStrategy moveStrategy, VectorInt2 position, char enemySumbol)
        {
            _moveStrategy = moveStrategy;
            _myConsole = MyConsole.Instance;
            _position = position;
            _enemySymbol = enemySumbol;
        }

        public void MoveAndPrint()
        {
            Move();
            Print();
        }

        private void Move()
        {
            VectorInt2 _direction = _moveStrategy.GetDirection();
            _position = new VectorInt2(_position.X + _direction.X, _position.Y + _direction.Y);
        }

        private void Print()
        {
            _myConsole.PrintAtPosition(_enemySymbol, _position.X, _position.Y);
        }
    }
}