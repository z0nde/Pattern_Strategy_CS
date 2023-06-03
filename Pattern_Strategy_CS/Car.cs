namespace Pattern_Strategy_CS
{
    public class Car
    {
        public void DoCar(ISwapper swap)
        {
            if (swap != null)
            {
                swap.Swap();
            }
        }
    }
}
