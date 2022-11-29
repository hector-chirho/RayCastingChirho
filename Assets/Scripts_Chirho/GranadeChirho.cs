using UnityEngine;

public class GranadeChirho : MonoBehaviour
{
    public float delayChirho = 3f;
    public float radiusChirho = 20f;
    public float burstForceChirho = 10f;

    void Start()
    {
        Invoke("GranadeBurstChirho", delayChirho);
    }

    void GranadeBurstChirho()
    {
        Collider[] collidersChirho = Physics.OverlapSphere(transform.position, radiusChirho);
        foreach(Collider nearChirho in collidersChirho)
        {
            Rigidbody rigidBodyChirho = nearChirho.GetComponent<Rigidbody>();
            if(rigidBodyChirho != null)
            {
                rigidBodyChirho.AddExplosionForce(burstForceChirho, transform.position, radiusChirho, 1f, ForceMode.Impulse);
            }
        }
        Destroy(gameObject);
    }
}
