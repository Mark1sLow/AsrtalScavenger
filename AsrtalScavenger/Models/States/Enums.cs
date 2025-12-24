namespace AstralScavenger.Models.States;

public enum PlayerColor
{
    Blue,
    Red,
    Green,
    Orange
}

public enum ShipType
{
    Cargo,
    Transport
}

public enum GameDifficulty
{
    Easy,
    Normal,
    Hard,
    Extreme
}

public enum GameScreen
{
    Menu,
    Playing,
    Pause,
    Customization,
    LevelSelection,
    LevelComplete,
    GameOverScreen
}

public enum GameLevel
{
    Tutorial = 1,          
    ResourceHunt = 2,      
    ResourceGoal1 = 3,     
    InvertedControls = 4,  
    StaticHazards = 5,     
    ResourceGoal2 = 6,     
    RichHunt = 7,          
    DarkZone = 8,          
    StaticInverted = 9,    
    DarkStatic = 10,       
    DarkInverted = 11,     
    RichHuntPlus = 12,        
    RichHuntPlusDark = 13,    
    RichHuntPlusChaos = 14,  
    Survival = 15           
}

public enum BackgroundStyle
{
    Default,       
    DarkSpace,     
    MultiSpace,    
    PixelSpace,    
    Nebula         
}

public enum DebrisType
{
    Standard,
    Metal,
    Gold,
    Diamond,
    Energy,
    Fuel
}