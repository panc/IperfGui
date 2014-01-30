namespace Iperf.Gui
{
    public class ComboBoxItem<T>
    {
        public ComboBoxItem(T value, string text)
        {
            Value = value;
            Text = text;
        }

        public T Value { get; private set; }
        
        public string Text { get; private set; }

        public override string ToString()
        {
            return Text;
        }
    }
}