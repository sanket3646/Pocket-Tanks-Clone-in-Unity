using UnityEngine;

public class MatchController : MonoBehaviour
{
    [SerializeField] private TurnManager turnManager;
    [SerializeField] private MatchStateMachine matchStateMachine;
    private float timer = 0;
    private void Start()
    {
        Debug.Log("Match started");
        matchStateMachine.ChangeState(States.TurnStart);
        Debug.Log("State : TurnStart");
        Debug.Log("player 1 turn");
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 2)
        {
            matchStateMachine.ChangeState(States.TurnEnd);
            Debug.Log("TurnEnd");
            matchStateMachine.ChangeState(States.TurnStart);
            Debug.Log("TurnStart");
            Debug.Log("player changed");
            timer = 0;
        }
    }
}
