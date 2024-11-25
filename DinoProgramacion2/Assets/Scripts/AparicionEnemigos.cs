using UnityEngine;

public class AparicionEnemigos : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public Vector3 areaDeSpawn = new Vector3(10, 1, 10); 
    public float tiempoEntreSpawn = 3f;

    void Start()
    {
        if (enemigoPrefab == null)
        {
            Debug.LogError("No se ha asignado un prefab de enemigo en el inspector.");
            return;
        }

        InvokeRepeating("SpawnEnemigo", 0f, tiempoEntreSpawn);
    }

    void SpawnEnemigo()
    {
        Vector3 spawnPos = GenerarPosicionAleatoria();
        Instantiate(enemigoPrefab, spawnPos, Quaternion.identity);
    }

    Vector3 GenerarPosicionAleatoria()
    {
        float spawnX = Random.Range(transform.position.x - areaDeSpawn.x / 2, transform.position.x + areaDeSpawn.x / 2);
        float spawnY = Random.Range(transform.position.y - areaDeSpawn.y / 2, transform.position.y + areaDeSpawn.y / 2);
        float spawnZ = Random.Range(transform.position.z - areaDeSpawn.z / 2, transform.position.z + areaDeSpawn.z / 2);

        return new Vector3(spawnX, spawnY, spawnZ);
    }
}
