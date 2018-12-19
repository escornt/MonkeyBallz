using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public float startSpeed = 10f;
    public Rigidbody rigidBody;

    void Start()
    {
    }

    public void TakeDamage(float amount)
    {
    }

    public void Slow(float pct)
    {
    }

    void Die()
    {
    }

    public void Push(float x, float y, float z)
    {
        GetComponent<Rigidbody>().AddForce(x, y, z, ForceMode.Impulse);
    }
}