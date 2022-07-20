namespace Factory
{
    public class AsyncFactory
    {
        private AsyncFactory()
        {
        }
        private async Task<AsyncFactory> InitAsync(){
            await Task.Delay(1000);
            return this;
        }
        public static Task<AsyncFactory> CreateAsync(){
            var result = new AsyncFactory();
            return result.InitAsync();
        }
    }
}