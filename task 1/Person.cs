class Person : Object
{
    public string Name { get; set; }
    public Person(string name)
    {

    }
    public override string ToString()
    {
        return Name;
    }



}