using UnityEngine;
using UnityEngine.Rendering;

public enum States
{
    Loading,
    TurnStart,
    TurnEnd,
    GameOver
}
public class MatchStateMachine : MonoBehaviour
{
    private States currentState = States.Loading;
    public void ChangeState(States state)
    {
        currentState = state;
        Debug.Log("State changed to " + state);

    }
}
