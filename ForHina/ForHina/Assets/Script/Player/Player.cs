using UnityEngine;

public class Player : Entity
{
    public float moveSpeed = 5f;
    

    public PlayerStateMachine stateMachine { get; private set; }

    public PlayerIdleState idleState { get; private set; }
    public PlayerMoveState moveState { get; private set; }

    public void Awake()
    {
        stateMachine = new PlayerStateMachine();
        idleState = new PlayerIdleState(this, stateMachine, "Idle");
        moveState = new PlayerMoveState(this, stateMachine, "Move");
    }


    protected override void Start()
    {
        base.Start();
        stateMachine.Initialize(idleState);
    }


    protected override void Update()
    {
        base.Update();
        stateMachine.currentState.Update();
    }

    
}
