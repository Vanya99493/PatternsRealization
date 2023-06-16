namespace Strategy.Random
{
    public static class MyRandom
    {
        private static System.Random _random = new System.Random();

        public static int GetRandom(int lowerBorder, int upperBorder) 
            => _random.Next(lowerBorder, upperBorder);
    }
}