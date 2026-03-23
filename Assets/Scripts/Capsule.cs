using UnityEngine;

// INHERITANCE
public class Capsule : ObjectHandler
{
    private float rotationSpeed = 360.0f;

    // POLYMORPHISM
    public override void MoveRight()
    {
        Rotate();
        base.MoveRight();
    }

    public void Rotate()
    {
        transform.Rotate(new Vector3(rotationSpeed * Time.deltaTime, 0, 0));
    }
}
