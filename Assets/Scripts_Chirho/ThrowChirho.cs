using UnityEngine;

public class ThrowChirho : MonoBehaviour
{
    public Transform spawnPointChirho;
    public GameObject granadePrefabChirho;
    public float rangeChirho = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            ThrowsChirho();
        }
    }

    void ThrowsChirho()
    {
        GameObject newGranadeChirho = Instantiate(granadePrefabChirho, spawnPointChirho.position, spawnPointChirho.rotation);
        newGranadeChirho.GetComponent<Rigidbody>().AddForce(spawnPointChirho.forward * rangeChirho, ForceMode.Impulse);
    }
}
