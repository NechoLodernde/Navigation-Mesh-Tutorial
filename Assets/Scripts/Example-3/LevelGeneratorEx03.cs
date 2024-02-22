using Unity.AI.Navigation;
using UnityEngine;

public class LevelGeneratorEx03 : MonoBehaviour
{
    public NavMeshSurface surface;

    public int width = 20;
    public int height = 20;

    public GameObject wall;
    public GameObject player;

    private bool playerSpawned = false;

    //  Instantiate the level
    private void Start()
    {
        GenerateLevel();

        // Update Nav Mesh
        surface.BuildNavMesh();
    }

    // Create a grid based level
    public void GenerateLevel()
    {
        // Loop over the grid
        for (int x = 0; x <= width; x += 2)
        {
            for (int y = 0; y <= height; y += 2)
            {
                // Should we place a wall?
                if (Random.value > 0.7f)
                {
                    // Spawn a wall
                    Vector3 pos = new Vector3(x - width / 2f, 1f, y - height / 2f);
                    Instantiate(wall, pos, Quaternion.identity, transform);
                }
                else if (!playerSpawned) // Should we spawn a player?
                {
                    // Spawn the player
                    Vector3 pos = new Vector3(x - width / 2f, 1.25f, y - height / 2f);
                    Instantiate(player, pos, Quaternion.identity);
                    playerSpawned = true;
                }
            }
        }
    }
}
