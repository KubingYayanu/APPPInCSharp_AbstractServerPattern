namespace APPPInCSharp_AbstractServerPattern
{
    public class Switch
    {
        public Switch(Switchable switchable)
        {
            this.switchable = switchable;
        }

        private Switchable switchable;

        public void TurnOn()
        {
            switchable.TurnOn();
        }

        public void TurnOff()
        {
            switchable.TurnOff();
        }
    }
}