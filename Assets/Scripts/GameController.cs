using UnityEngine;

public static class GameController
{
    private static int collectableCount;
    private static bool playerDefeated = false;
    private static bool playerWon = false;

    public static bool GameOver => playerDefeated || playerWon;

    public static void Init()
    {
        collectableCount = 4;
        playerDefeated = false;
        playerWon = false;
    }

    public static void Collect()
    {
        collectableCount--;
        if (collectableCount <= 0)
        {
            playerWon = true;
        }
    }

    public static void HitByEnemy()
    {
        playerDefeated = true;
    }

    public static bool PlayerWon => playerWon;
    public static bool PlayerDefeated => playerDefeated;

}
