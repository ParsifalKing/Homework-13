public abstract class Animal : Object
{
    public string Name { get; set; }

    public void SetName(string name)
    {
        Name = name;
    }
    public string GetName()
    {
        return Name;
    }
    public abstract void Eat();


}