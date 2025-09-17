namespace compuertas;
public class truthvalue : IInput
{
    public bool value;
    public truthvalue(bool value)
    {
        this.value = value;
    }
    public bool GetValue()
    {
        return this.value;
    }
}