using JetBrains.Annotations;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public int facingDir { get; private set; } = 1;
    protected bool facingRight = true;

    #region Components
    public Rigidbody2D rb { get; private set; }
    public Animator anim { get; private set; }
    #endregion
    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }


    protected virtual void Update()
    {

    }

    #region Velocity
    public void SetZeroVelocity()
    {
        rb.linearVelocity = new Vector2(0, 0);
    }

    public void SetVelocity(float _xVelocity, float _yVelocity)
    {
        rb.linearVelocity = new Vector2(_xVelocity, _yVelocity);
        FlipController(_xVelocity);
    }
    #endregion

    #region Flip
    public virtual void Flip()
    {
        facingDir = facingDir * -1;
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }

    public virtual void FlipController(float _x)
    {
        if(_x > 0 && !facingRight)
            Flip();
        else if(_x <0 && facingRight)
            Flip();
    }
    #endregion
}
