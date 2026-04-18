using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private int currentPlayer = 0;
    private int turnNumber;

    private void ChangePlayer()
    {
        currentPlayer = (currentPlayer == 0) ? 1 : 0;
        Debug.Log("current player: " +  currentPlayer);
        turnNumber++;
    }
}
