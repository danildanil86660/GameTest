using System.Collections.Generic;

public static class objGame{

    //Название всех ресурсов в игре
    public static string[] nameResurses = new string[5] { "gold", "boards", "beam", "bricks", "glass" };

    //Словарь для хранения ресурсов игрока
    private static Dictionary<string, int> resurses = new Dictionary<string, int>(5);

    //Методы доступа к словарю ресурсов
    public static int getResurse(string key)
    {
        return resurses[key];
    }
    public static void setResurse(string key, int value)
    {
        resurses[key] += value;
    }

    public static void startResurse()
    {
        //Инициализация начальных ресурсов и [загрузка (НЕ РЕАЛИЗОВАНО!)]
        resurses.Add("gold", 0);
        resurses.Add("boards", 0);
        resurses.Add("beam", 0);
        resurses.Add("bricks", 0);
        resurses.Add("glass", 0);
    }
}
