namespace YegorAndMisha;

public class Cat
{
    #region PrivateFields
    private double _weight;
    private double _fur;
    private double _height;
    private string _name;
    #endregion
    #region Properties
    public string Name 
    { 
        get => _name;
        set
        {
            if (value.Trim() != String.Empty) _name = value;
        }
    }
    public double Fur
    {
        get => _fur;
        set
        {
            if (value >= 0) _fur = value;
        }
    }
    public double Weight
    {
        get => _weight;
        set
        {
            if (value > 0 && value < 30) _weight = value;
        }
    }
    public double Height
    {
        get => _height;
        set
        {
            if (value > 0 && value < 100) _height = value;
        }
    }
    #endregion
    #region Methods
    public void Play() => Console.WriteLine($"{Name} start playing");   
    public void Eat() => Console.WriteLine($"{Name} start eating");
    public void Purrr() => Console.WriteLine($"{Name} start making purrr!");
    public void ShowInfo() => Console.WriteLine($"Name: {Name}\nWeight: {Weight}\nHeight: {Height}");
    #endregion
    #region Constructors
    public Cat()
    {
        Name = "Kitty";
        Weight = 0.2;
        Height = 10;
       
    }
    public Cat(string name, double weight, double height)
    {
        Name = !string.IsNullOrWhiteSpace(name) ? name : "Kitty"; 
        Weight = weight;
        Height = height;
        
    }
    #endregion
}