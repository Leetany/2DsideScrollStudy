using UnityEngine;

public class PlayerJumpState : PlayerState
{
    public PlayerJumpState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        player.SetVelocity(rb.linearVelocityX, player.jumpForce);
        SoundManager.instance.PlaySFX(2, PlayerManager.instance.player.transform);
    }

    public override void Update()
    {
        base.Update();
        if(rb.linearVelocityY < 0)
            stateMachine.ChangeState(player.airState);
    }

    public override void Exit()
    {
        base.Exit();
    }
}
