using UnityEngine;
using System.Collections;

public class SpawnEat : MonoBehaviour
{
    private float[] TimeSpawn = { 2f, 3f, 4f, 4f,};
    public GameObject[] Food;
    private float[] PositionSpawn = { 0f, -1f, 1 };
    private float speedSpawn = 0f;
    void Start()
    {
        StartCoroutine(spawn());
        
    }
    IEnumerator spawn()
    {
        while (true)
        {
            if (TimeSpawn[0] > 0.5f & (speedSpawn % 7 == 0))
            {
                if (speedSpawn % 5 == 0)
                {
                    TimeSpawn[0] = TimeSpawn[0] - 0.1f;
                    TimeSpawn[1] = TimeSpawn[1] - 0.1f;
                    TimeSpawn[2] = TimeSpawn[2] - 0.1f;
                    TimeSpawn[3] = TimeSpawn[3] - 0.1f;
                }
            }
            Instantiate(
                Food[Random.Range(0, Food.Length)],
                new Vector3 (-4f, PositionSpawn[Random.Range(0, PositionSpawn.Length)], 0), 
                Quaternion.identity
                );
            speedSpawn = speedSpawn + 1f;
            yield return new WaitForSeconds(TimeSpawn[Random.Range(0, TimeSpawn.Length)]);
        }
    }
}
