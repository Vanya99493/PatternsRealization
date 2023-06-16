namespace FacadePattern.FacadeImplementation
{
    public class GameManager
    {
        private DataModule _dataModule;
        private GameLogicModule _gameLogicModule;
        private ViewModule _viewModule;

        public GameManager(DataModule dataModule, GameLogicModule gameLogicModule, ViewModule viewModule)
        {
            _dataModule = dataModule;
            _gameLogicModule = gameLogicModule;
            _viewModule = viewModule;
        }

        public void LoadGame()
        {
            _dataModule.GetData();
            _gameLogicModule.SetData();
            _viewModule.ShowData();
        }

        public void PlayInGame()
        {
            _gameLogicModule.ExecuteGameLogic();
            _viewModule.ShowData();
        }

        public void CloseGame()
        {
            _dataModule.SaveData();
        }
    }
}