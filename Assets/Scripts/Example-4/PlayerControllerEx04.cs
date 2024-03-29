using UnityEngine;
using UnityEngine.AI;

public class PlayerControllerEx04 : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;

    private void Awake()
    {
        cam = FindAnyObjectByType<Camera>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Move our agent
                agent.SetDestination(hit.point);
            }
        }
    }
}
