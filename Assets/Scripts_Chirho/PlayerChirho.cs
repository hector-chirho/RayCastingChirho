using UnityEngine;


public class PlayerChirho : MonoBehaviour
{
    public float speedChirho = 2f;
    public float timeChirho = 0f;

    Vector3 positionInitialChirho;

    public GameObject positionChirho;
    public Rigidbody rigidBodyChirho;
    public Vector3 positionNewChirho;

    int randomXChirho;
    int randomYChirho;
    int randomZChirho;

    void Start()
    {
        positionInitialChirho = transform.position;
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        MovementPlayerChirho();
        RespawnChirho();
    }

    void MovementPlayerChirho()
    {
        float movXChirho = Input.GetAxis("Horizontal");
        float movYChirho = Input.GetAxis("Vertical");
        Vector3 inputPlayerChirho = new Vector3(movXChirho, 0, movYChirho);
        //transform.Translate(inputPlayerChirho * Time.deltaTime * speedChirho);
        rigidBodyChirho.AddForce(inputPlayerChirho * speedChirho);
        //rigidBodyChirho.AddForceAtPosition(inputPlayerChirho * speedChirho, positionNewChirho);
    }

    void RespawnChirho()
    {
        if(transform.position.y < -10)
        {
            transform.position = positionInitialChirho;
        }
    }

}
