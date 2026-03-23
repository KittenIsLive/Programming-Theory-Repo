using UnityEngine;

public class ObjectHandler : MonoBehaviour
{
    private float m_speed = 1f;

    // ENCAPSULATION
    public float speed
    {
        get
        {
            return m_speed;
        }

        set
        {
            // Object move speed should not be 0 or less
            if (value <= 0.0f)
            {
                Debug.LogError("Value cannot be 0 or less");
            }
            else
            {
                m_speed = value;
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveRight();
    }

    // ABSTRACTION
    public virtual void MoveRight()
    {
        transform.Translate(Vector3.right * m_speed * Time.deltaTime);
    }
}
