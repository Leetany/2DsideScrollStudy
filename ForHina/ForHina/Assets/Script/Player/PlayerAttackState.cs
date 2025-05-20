using UnityEngine;

public class PlayerAttackState : PlayerState
{
    public int comboCount { get; private set; }

    private float lastTimeAttacked;
    private float comboWindow = 2;
    public PlayerAttackState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();

        xInput = 0;

        if (comboCount > 2 || Time.time >= lastTimeAttacked + comboWindow)
            comboCount = 0;

        player.anim.SetInteger("ComboCount", comboCount);

        float attackDir = player.facingDir;

        if (xInput != 0)
            attackDir = xInput;

        stateTimer = 0.1f;
    }

    public override void Update()
    {
        base.Update();

        if (stateTimer < 0)
            player.SetZeroVelocity();

        if (triggerCalled)
            stateMachine.ChangeState(player.idleState);
    }

    public override void Exit()
    {
        base.Exit();
        comboCount++;
        lastTimeAttacked = Time.time;
    }
}
