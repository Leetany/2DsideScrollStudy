using Unity.Profiling;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerGroundState : PlayerState
{
    public PlayerGroundState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName)
    : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        base.Update();

        if (!player.IsGroundDetected())
            stateMachine.ChangeState(player.airState);
        if (Input.GetKeyDown(KeyCode.Space) && player.IsGroundDetected())
            stateMachine.ChangeState(player.jumpState);
        if (Input.GetKeyDown(KeyCode.Mouse0))
            stateMachine.ChangeState(player.attackState);
    }

    public override void Exit()
    {
        base.Exit();
    }
}
