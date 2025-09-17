using UnityEngine;

public class MoreChicken : MonoBehaviour
{
    [SerializeField] float waitTime = 10.5f;
    Renderer renderers;
    CharacterController characterController;



    void Start()
    {
        renderers = GetComponentInChildren<Renderer>();
        characterController = GetComponent<CharacterController>();

        renderers.enabled = false;
    }

    void Update()
    {
        if (Time.time > waitTime)
        {
            renderers.enabled = true;
        }
    }
}
