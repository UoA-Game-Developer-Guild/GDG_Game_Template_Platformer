using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

    Player player;
    [SerializeField] float sizeOfInteractableArea = 1.2f;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          Interact();
        }
    }

    private void Interact()
    {
      Collider2D[] colliders = Physics2D.OverlapCircleAll(player.transform.position, sizeOfInteractableArea);

      foreach (Collider2D collider in colliders)
      {
          Interactable obj = collider.GetComponent<Interactable>();
          if (obj != null)
          {
            obj.Interact();
            break;
          }
      }
    }
}
