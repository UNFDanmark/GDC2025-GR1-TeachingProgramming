using UnityEngine;

public class coinspawn : MonoBehaviour
{
    
    [SerializeField] float cooldown = 2f;
    [SerializeField]float currentSpawnTime;
    public GameObject coin;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentSpawnTime = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        currentSpawnTime -= Time.deltaTime;
        if (currentSpawnTime <= 0)
        {
            Vector3 spawnposition = transform.position;
            spawnposition.x = spawnposition.x + Random.Range(-5, 5);
            spawnposition.z = spawnposition.z + Random.Range(-5, 5);
            spawnposition.y = spawnposition.y + Random.Range(0, 5);
            Instantiate(coin, spawnposition, Quaternion.identity);
            currentSpawnTime = cooldown;
        }
    }
}
