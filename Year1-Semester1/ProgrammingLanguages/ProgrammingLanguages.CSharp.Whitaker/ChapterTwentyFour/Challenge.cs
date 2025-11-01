namespace ProgrammingLanguages.CSharp.Whitaker.ChapterTwentyFour;

public static class Challenge
{
    public static void ThePoint()
    {
        var point1 = new Point(2,3);
        var point2 = new Point(-4,0);
        var point3 = new Point();

        Console.WriteLine(point1);
        Console.WriteLine(point2);
        Console.WriteLine(point3);
    }

    public static void TheColor()
    {
        var color1 = new Color(0, 0, 9);
        var color2 = Color.White;

        Console.WriteLine(color1);
        Console.WriteLine(color2);
    }

    #region CardGame
    public static void TheCard()
    {
        var deck = new List<Card>();

        foreach (CardColor color in Enum.GetValues(typeof(CardColor)).Cast<CardColor>())
        {
            foreach (CardRank rank in Enum.GetValues(typeof(CardRank)).Cast<CardRank>())
            {
                var card = new Card(color, rank);
                deck.Add(card);
            }
        }
        deck.ShuffleDeck();

        for (int i = 0; i < deck.Count; i++)
        {
            if (i % 4 == 0)
                Console.WriteLine();

            Console.Write($"{CardName(deck[i])} ");
        }
    }

    private static void ShuffleDeck(this List<Card> deck)
    {
        var rand = new Random();
        var len = deck.Count;
        while (len > 1)
        {
            len--;
            var len2 = rand.Next(len + 1);

            var temp = deck[len2];
            deck[len2] = deck[len];
            deck[len] = temp;
        }
    }

    private static string CardName(Card card)
    {
        var name = "The ";
        
        switch(card.Color)
        {
            case CardColor.Red:
                name += "Red";
                break;
            case CardColor.Green:
                name += "Green";
                break; 
            case CardColor.Blue:
                name += "Blue";
                break;
            case CardColor.Yellow:
                name += "Yellow";
                break;
        }

        switch (card.Rank)
        {
            case CardRank.One:
                name += "One";
                break;
            case CardRank.Two:
                name += "Two";
                break;
            case CardRank.Three:
                name += "Three";
                break;
            case CardRank.Four:
                name += "Four";
                break;
            case CardRank.Five:
                name += "Five";
                break;
            case CardRank.Six:
                name += "Six";
                break;
            case CardRank.Seven:
                name += "Seven";
                break;
            case CardRank.Eight:
                name += "Eight";
                break;
            case CardRank.Nine:
                name += "Nine";
                break;
            case CardRank.Ten:
                name += "Ten";
                break;
            case CardRank.Dollar:
                name += "Dollar";
                break;
            case CardRank.Percentage:
                name += "Percentage";
                break;
            case CardRank.Pow:
                name += "Pow";
                break;
            case CardRank.And:
                name += "And";
                break;
        }

        return name;
    }

    #endregion

    #region DoorGame
    public static void TheLockedDoor()
    {
        Console.WriteLine("Enter a passkey: ");
        int.TryParse(Console.ReadLine(), out var passKey);

        var door = new Door(passKey);

        while (true) 
        {
            Console.WriteLine($"Current State: {door.State}");
            Console.WriteLine("open - close - lock - unlock - change (during closed)\n");

            var command = Console.ReadLine();

            switch (command)
            {
                case "open" when door.State == DoorState.Closed:
                    door.ChangeState(DoorState.Open);
                    break;
                case "close" when door.State == DoorState.Open:
                    door.ChangeState(DoorState.Closed);
                    break;
                case "lock" when door.State == DoorState.Closed:
                    door.ChangeState(DoorState.Locked);
                    break;
                case "unlock" when door.State == DoorState.Locked:
                    Console.WriteLine("Enter passkey: ");
                    var passKeyInput = int.Parse(Console.ReadLine());
                    if (passKeyInput == door.Passcode)
                        door.ChangeState(DoorState.Closed);
                    break ;
                case "change" when door.State == DoorState.Closed:
                    Console.WriteLine("Enter passcode and new passcode with space");
                    var input = Console.ReadLine();
                    var split = input.Split(" ");
                    if (int.Parse(split[0]) == door.Passcode)
                        door.ChangeKey(int.Parse(split[1]));
                    break;
            }
        }
    }
    #endregion

    #region PasswordGame
    public static void ThePasswordValidator()
    {
        
        var validator = new PasswordValidator();

        while (true)
        {
            Console.WriteLine("Enter a password: ");
            var password = Console.ReadLine();
            Console.WriteLine(validator.IsValid(password) ? "valid" : "not valid");
        }
    }
    #endregion
}

#region PointData
public class Point
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public Point()
    {
        X = 0;
        Y = 0;
    }

    public override string ToString() => $"({X}, {Y})";
}
#endregion

#region ColorData
public class Color
{
    public int R { get; private set; }
    public int G { get; private set; }
    public int B { get; private set; }

    public Color(int red, int green, int blue)
    {
        R = red;
        G = green;
        B = blue;
    }

    public static Color White => new Color(255, 255, 255);
    public static Color Black => new Color(0, 0, 0);
    public static Color Red => new Color(255, 0, 0);
    public static Color Orange => new Color(255, 165, 0);
    public static Color Yellow => new Color(255, 255, 0);
    public static Color Green => new Color(0, 128, 0);
    public static Color Blue => new Color(0, 0, 255);
    public static Color Purple => new Color(128, 0, 128);

    public override string ToString() => $"({R}, {G}, {B})";
}
#endregion

#region CardGameData
public enum CardColor
{
    Red, 
    Green, 
    Blue, 
    Yellow
}

public enum CardRank
{
    One = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Dollar,
    Percentage,
    Pow,
    And
}

public class Card
{
    public CardColor Color { get; private set; }
    public CardRank Rank { get; private set; }

    public Card(CardColor color, CardRank rank)
    {
        Color = color;
        Rank = rank;
    }
}
#endregion

#region DoorData
public enum DoorState
{
    Open,
    Closed,
    Locked
}
public class Door
{
    public DoorState State { get; private set; }
    public int Passcode { get; private set; }

    public Door(int passcode)
    {
        State = DoorState.Locked;
        Passcode = passcode;
    }

    public void ChangeState(DoorState state) =>
        State = state;

    public void ChangeKey(int key) => Passcode = key;
}
#endregion

#region PasswordData
public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if(password.Length > 13 || password.Length < 6)
            return false;
        if(password.Contains('T') || password.Contains('&'))
            return false;
        
        var hasDigit = false;
        var hasUpper = false;
        var hasLower = false;

        foreach (char c in password)
        {
            if (char.IsDigit(c)) hasDigit = true;
            if (char.IsUpper(c)) hasUpper = true;
            if (char.IsLower(c)) hasLower = true;
        }

        return hasDigit && hasUpper && hasLower;
    }
}
#endregion

#region Tic Tac Tow
public class Game
{
    public GameInput[,] GameBoard { get; private set; }
    public GameDisplay GameDisplay { get; private set; }

    public Game()
    {
        GameBoard = new GameInput[3, 3];
        GameDisplay = new();
    }
    public void Play()
    {
        var currentTurn = GameInput.X;
        GameDisplay.Draw(GameBoard);

        while (true)
        {
            var userInput = GetValidInput($"It is {currentTurn.ToString()}'s turn");
            var position = GetPosition(userInput);

            if (GameBoard[position.x, position.y] != GameInput.Empty)
                return;
            else
            {
                GameBoard[position.x, position.y] = currentTurn;
            }

            GameDisplay.Draw(GameBoard);
            if (IsWin(currentTurn))
            {
                Console.WriteLine($"{currentTurn.ToString()} won");
                break;
            }
            else
            {
                if (currentTurn == GameInput.X)
                    currentTurn = GameInput.O;
                else
                    currentTurn = GameInput.X;
            }
        }
    }

    private bool IsWin(GameInput input)
    {
        // Rows
        for (int i = 0; i < 3; i++)
        {
            if (GameBoard[i, 0] == input &&
                GameBoard[i, 1] == input &&
                GameBoard[i, 2] == input)
            {
                return true;
            }
        }

        // Columns
        for (int j = 0; j < 3; j++)
        {
            if (GameBoard[0, j] == input &&
                GameBoard[1, j] == input &&
                GameBoard[2, j] == input)
            {
                return true;
            }
        }

        // Diagonals
        if (GameBoard[0, 0] == input && GameBoard[1, 1] == input && GameBoard[2, 2] == input)
            return true;

        if (GameBoard[0, 2] == input && GameBoard[1, 1] == input && GameBoard[2, 0] == input)
            return true;
        return false;
    }
    private Position GetPosition(int input)
    {
        return input switch
        {
            1 => new Position { x = 0, y = 0 },
            2 => new Position { x = 0, y = 1 },
            3 => new Position { x = 0, y = 2 },
            4 => new Position { x = 1, y = 0 },
            5 => new Position { x = 1, y = 1 },
            6 => new Position { x = 1, y = 2 },
            7 => new Position { x = 2, y = 0 },
            8 => new Position { x = 2, y = 1 },
            9 => new Position { x = 2, y = 2 },
            _ => throw new NotImplementedException(),
        };
    }
    private int GetValidInput(string message)
    {
        while (true)
        {
            Console.WriteLine(message);
            Console.Write("Enter a valid input: ");
            var input = int.TryParse(Console.ReadLine(), out int userInput);
            if (userInput > 0 && userInput < 10)
                return userInput;
        }
    }
}

public class GameDisplay
{
    public void Draw(GameInput[,] gameBoard)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                char symbol = gameBoard[i, j] switch
                {
                    GameInput.X => 'X',
                    GameInput.O => 'O',
                    _ => ' '
                };
                Console.Write($" {symbol} ");
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2)
                Console.WriteLine("---+---+---");
        }
    }
}
public class Position
{
    public int x { get; set; }
    public int y { get; set; }
}
public enum GameInput
{
    Empty,
    X,
    O
}
#endregion