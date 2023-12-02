using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject slotButton;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int j = 0; j < inventory.slots.Length; j++)
            {
                if (inventory.isFull[j] == false)
                {
                    Destroy(gameObject);
                    Instantiate(slotButton, inventory.slots[j].transform);
                    inventory.isFull[j] = true;
                    break;
                }
            }
        }
    }
}
